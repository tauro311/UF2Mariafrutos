using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuManager : MonoBehaviour

{
    public Text scoreText;
    public int score; 

    // Start is called before the first frame update
    void Start()
    {
        LoadScore();
    }

    void LoadScore()
    {
         scoreText.Text = " Puntuacion " score.ToString();
    }
     

    public void LoadFristLevel( )
    {
        SceneManager.LoadScene("Nivel 1");
    }
}
