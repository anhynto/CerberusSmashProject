using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListePositionHaut : MonoBehaviour
{

    private float vitesse = 0f; 

    private List<Vector3> listPositions = new List<Vector3>();
    private int indicePosition = 0;

    private void Start()
    {
        listPositions.Add(new Vector3(-7, 2f, 0));
        listPositions.Add(new Vector3(-4, -1.25f, 0));
        listPositions.Add(new Vector3(4, 1.25f, 0));
        listPositions.Add(new Vector3(7, 0, 0));

        //vitesse = Random.Range(1f, 5f);
        vitesse = 0.5f;

        this.transform.position = listPositions[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (indicePosition >= listPositions.Count)
            return;

        Vector3 direction = listPositions[indicePosition] - this.transform.position;
        direction = direction.normalized;
        direction = direction * vitesse;
        direction = direction * Time.deltaTime;

        Vector3 newPosition = this.transform.position + direction;

        if (Vector3.Distance(this.transform.position, listPositions[indicePosition]) > Vector3.Distance(newPosition, listPositions[indicePosition]))
        {
            this.transform.position += direction;
        }
        else
        {
            this.transform.position = listPositions[indicePosition];
            if (indicePosition < listPositions.Count)
            {
                indicePosition++;
            }
        }
    }
}
