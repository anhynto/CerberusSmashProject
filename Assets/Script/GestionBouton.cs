using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GestionBouton: MonoBehaviour
{
    public void ChargeGameScene()
    {
        Debug.Log("lancement");
        SceneManager.LoadScene("GameScene");
    }

    public void QuitterJeu()
    {
        Application.Quit();
    }

}
