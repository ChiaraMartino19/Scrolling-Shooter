using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PrimerLevel()
    {
        SceneManager.LoadScene("Scrolling Shooter");
    }


    public void MenuInicio()
    {
        SceneManager.LoadScene("MenuInicio");
    }


    public void SegundoNivel()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("Winner");
        }
    }
}
