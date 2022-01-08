using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickRaycast : MonoBehaviour
{

    private GameObject manager;
    private GameManagerScript managerScript;
    //private bool useRayCast;
    public Camera cam;
    private Vector3 hitPoint;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("GameManager");
        managerScript = manager.GetComponent<GameManagerScript>();
    }

    void Update()
    {
        //if (useRayCast)
        //{
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, 1000f))
            {
                hitPoint = hit.point;
                if (Input.GetMouseButtonDown(0))
                {
                print("touché");
                    Destroy(hit.transform.gameObject);
                    managerScript.ajoutPointScore();
                }
            }

        //}
    }

    // Update is called once per frame
    /*   void Update()
       {
           if (Input.GetKeyDown(KeyCode.Mouse0))
           {

               //Debug.Log("j'ai cliqué");

               Vector3 postion = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y),0f);
               Vector3 direction = postion - Camera.main.transform.position;
               direction = direction.normalized;
               direction *= 2f;

               Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
               RaycastHit hit;
               if (Physics.Raycast(ray, out hit, 100))
               {
                   if (hit.collider.gameObject.name.Contains("Ennemy"))
                   {
                       Destroy(hit.collider.gameObject);
                       managerScript.ajoutPointScore();
                   }             
               }

               Debug.DrawLine(Camera.main.transform.position, Camera.main.transform.position + direction, Color.green, 5f);
           }
       }*/

}
