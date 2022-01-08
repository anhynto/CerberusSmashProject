using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListePositionBas : MonoBehaviour
{

    private float vitesse = 0f;
    private int traj;

    private List<Vector3[]> listPositions = new List<Vector3[]>();
    private int indicePosition = 0;

    private Vector3[] traj1 = new [] { new Vector3(-7, -4, 0), new Vector3(-4, 1.5f, 0), new Vector3(4, -1.5f, 0), new Vector3(7, 0, 0) };
    private Vector3[] traj2 = new [] { new Vector3(-7, -4, 0), new Vector3(2.5f, -3, 0), new Vector3(4, 0, 0), new Vector3(0, 3.5f, 0), new Vector3(-3.5f, 0, 0), new Vector3(4, -2, 0), new Vector3(7, 0, 0) };
    private Vector3[] traj3 = new [] { new Vector3(-7, -4, 0), new Vector3(7,0,0) };
    private Vector3[] traj4 = new [] { new Vector3(-7, -4, 0), new Vector3(-3 , 3, 0), new Vector3(3, -3, 0), new Vector3(7, 0, 0) };

    private void Start()
    {
        listPositions.Add(traj1);
        listPositions.Add(traj2);
        listPositions.Add(traj3);
        listPositions.Add(traj4);

        //vitesse = Random.Range(1f, 5f);
        vitesse = 0.5f;

        traj = Random.Range(0, listPositions.Count);

        this.transform.position = listPositions[traj][0];

    }

    // Update is called once per frame
    void Update()
    {
        if (indicePosition >= listPositions[traj].Length)
            return;

        Vector3 direction = listPositions[traj][indicePosition] - this.transform.position;
        direction = direction.normalized;
        direction = direction * vitesse;
        direction = direction * Time.deltaTime;

        Vector3 newPosition = this.transform.position + direction;

        if (Vector3.Distance(this.transform.position, listPositions[traj][indicePosition]) > Vector3.Distance(newPosition, listPositions[traj][indicePosition]))
        {
            this.transform.position += direction;
        }
        else
        {
            this.transform.position = listPositions[traj][indicePosition];
            if (indicePosition < listPositions[traj].Length)
            {
                indicePosition++;
            }
        }
    }
}
