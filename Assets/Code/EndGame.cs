using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "pacman")
        {
            //Check if the isTrigger option on th Collider2D is set to true or false

            SceneManager.LoadScene("EndScene");
        }
    }
}
