using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnnemys : MonoBehaviour
{

    public GameObject prefabEnnemy;
    //private int cptEnnemy = 0;

    private float tempsDernierSpawn = 0.0f; // stock le temps passé depuis la derniere execution;
    private float delai = 1f;	// tu defini l'interval voulu, en seconde.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            tempsDernierSpawn += Time.fixedDeltaTime;  // ajoute a chaque update le temps écoulé depuis le dernier Update		
            if (tempsDernierSpawn > delai)
            {
                Instantiate(prefabEnnemy);
                //cptEnnemy++;
                tempsDernierSpawn = 0;
            }

    }
}
