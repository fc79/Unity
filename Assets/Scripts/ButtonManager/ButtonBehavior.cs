using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    int n;
    public void OnButtonPress()
    {
        
        SceneManager.LoadScene("MainGame");

    }
    void Start()
    {
        if (PlayerPrefs.GetInt("Menu") == 0)
        {
            PlayerPrefs.SetInt("Menu", 1);

            SceneManager.LoadScene("MainGame");
        }
    }

}
