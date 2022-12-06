using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Cloud_Cloning : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cloudPrefab;
    public GameObject coinPrefab;
    public float numberOfclouds;
    public int numberOfCoins;
    public float interval = 5;
    float timer;
    Vector2 positionCloud;
    Vector2 positionCoin;

    void Start()
    {
        positionCloud = new Vector2(1,1);
        positionCoin = new Vector2(1,1);

       
 
    
    }
/*    void createCoins(int coinsNumber)
    {
        for (int i = 0; i < coinsNumber; i++)
        {
            Vector2 position = new Vector2(UnityEngine.Random.Range(-222f, 222f), UnityEngine.Random.Range(-52F, 167F));
            Instantiate(coinPrefab, position, Quaternion.identity);

        }
    }*/
    void Update()
    {
        timer += Time.deltaTime;
        
        if (Math.Truncate(timer) % 10 == 0)
        {
            positionCloud = new Vector2(UnityEngine.Random.Range(-222,222),-100);
            positionCoin = new Vector2(UnityEngine.Random.Range(-220,190),-70);
            
            
                Instantiate(cloudPrefab, positionCloud, Quaternion.identity);
                Instantiate(coinPrefab, positionCoin, Quaternion.identity);

                //position = new Vector2(position.x + 0.5f, this.transform.position.y);

                timer = 1;
            
        }
    }
    
}
