using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class Pou : MonoBehaviour
{
    // Start is called before the first frame update
    // Movement speed
    public float speed =1 ;

    // Flap force
    public float force = 10;
    private int score;
    public int life = 5;



    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI lifeText;

    private void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    private void UpdateLife(int fault)
    {
        life -= fault;
        if(life < 0)
        {
            Debug.Log("GAME OVER");
        }
        lifeText.text = "Life: " + life + "/5";

    }

    void OnCollisionEnter2D(Collision2D collisionInfo)


    {
        Debug.Log("Detected collision between " + gameObject.name + " and " + collisionInfo.gameObject.name);
        if (collisionInfo.gameObject.name.Contains("Cloud"))
        {

            UpdateLife(1);
            //collisionInfo.gameObject.SetActive(false);
            collisionInfo.gameObject.transform.position = new Vector2(Random.Range(222f,-222f),Random.Range(-40f,177f));


        }
        else if (collisionInfo.gameObject.name.Contains("Coin"))
        {

            UpdateScore(1);
            //Destroy(collisionInfo.gameObject);
            collisionInfo.gameObject.SetActive(false);
        }


    }
    void Start()
    {
        UpdateScore(0);
        UpdateLife(0);



    }

  
    void Update()
    {

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

