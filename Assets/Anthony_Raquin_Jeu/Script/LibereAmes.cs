using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibereAmes : MonoBehaviour
{
    private GameObject manager;
    private GameManagerScript managerScript;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("GameManager");
        managerScript = manager.GetComponent<GameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("un âme à réussi à s'échapper");
        Destroy(other.gameObject);
        managerScript.enleverUneVie();

    }
}
