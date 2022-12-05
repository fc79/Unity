using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud_Cloning : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cloudPrefab;
    public int numberOfclouds;

    void Start()
    {
        createClouds(numberOfclouds);
    }

    // Update is called once per frame
    void createClouds (int cloudsNumber)
    {
        for(int i = 0; i< cloudsNumber; i++)
        {
            Vector2 position = new Vector2(Random.Range(-222f, 222f), Random.Range(-52F, 167F));
            Instantiate(cloudPrefab, position, Quaternion.identity);

        }
    }
    void Update()
    {
        
    }
}
