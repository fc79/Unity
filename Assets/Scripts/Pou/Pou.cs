using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class Pou : MonoBehaviour
{
    // Movement speed
    public float speed =1 ;

    // Flap force
    public float force = 10;
    private int score;
    public int life = 5;



    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI lifeText;

    Vector2 pos;
    private void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    private void UpdateLife(int fault)
    {
        life -= fault;
        if(life == 0)
        {
            //Destroy(gameObject);

            pos = new Vector2(this.transform.position.x, -this.transform.position.y);
            Debug.Log("pos" + pos);
            SceneManager.LoadScene("Menu");
            //Time.timeScale = 0;



        }
        lifeText.text = "Life: " + life + "/5";

    }

    void OnCollisionEnter2D(Collision2D collisionInfo)


    {
        //Debug.Log("Detected collision between " + gameObject.name + " and " + collisionInfo.gameObject.name);
        if (collisionInfo.gameObject.name.Contains("Cloud"))
        {

            UpdateLife(1);
            //collisionInfo.gameObject.SetActive(false);
            //collisionInfo.gameObject.transform.position = new Vector2(Random.Range(-226f,220f),-108f );


        }
        else if (collisionInfo.gameObject.name.Contains("Coin"))
        {

            UpdateScore(1);
            Destroy(collisionInfo.gameObject);
            //collisionInfo.gameObject.transform.position = new Vector2(Random.Range(200f, -199f), Random.Range(-30f, 150f));

        }


    }
  


    void Start()
    {
        this.transform.position = pos;
        UpdateScore(0);
        UpdateLife(0);



    }

  
    void Update()
    {
        if(this.transform.position.x < -248)
        {
            this.transform.position = new Vector2( 250,this.transform.position.y);
        }
        if(this.transform.position.x > 250)
        {
            this.transform.position = new Vector2(-248, this.transform.position.y);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.left * force);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * force);
        }
    }
}

