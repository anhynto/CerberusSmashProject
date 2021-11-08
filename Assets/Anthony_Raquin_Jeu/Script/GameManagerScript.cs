using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagerScript : MonoBehaviour
{

    public Text scoreLabel;
    public Text vieLabel;
    private static int score;
    private static int vie;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        vie = 40;
        scoreLabel.text = "Score : " + score;
        vieLabel.text = "Vies : " + vie;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ajoutPointScore()
    {
        Debug.Log("j'ai ajouté un point");
        score = score + 1;
        scoreLabel.text = "Score : " + score;

    }

    public int getScore()
    {
        return score;
    }

    public void enleverUneVie ()
    {

        Debug.Log("vie : " + vie);

        vie = vie - 1;

        vieLabel.text = "Vies : " + vie;

        if (vie <= 0)
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene("GameOverScene");
        }
    }

    public int getVie()
    {
        return vie;
    }

    public void gameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }

}
