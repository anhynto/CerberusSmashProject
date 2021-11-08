using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickRaycast : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            //Debug.Log("j'ai cliqué");

            Vector3 postion = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y),0f);
            Vector3 direction = postion - Camera.main.transform.position;
            direction = direction.normalized;
            direction *= 2f;

            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(Camera.main.transform.position, direction, out hit))
            {
                if (hit.collider.gameObject.name.Contains("Ennemy"))
                {
                    managerScript.ajoutPointScore();
                    Destroy(hit.collider.gameObject);
                }             
            }

            Debug.DrawLine(Camera.main.transform.position, Camera.main.transform.position + direction, Color.green, 5f);
        }
    }
}
