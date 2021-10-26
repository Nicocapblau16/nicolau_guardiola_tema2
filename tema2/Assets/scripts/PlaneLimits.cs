using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneLimits : MonoBehaviour
{
    private float limX = 50;
    private float limZ = 25;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(x: 0, y: 0.5f, z: 0);
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObject(Vector3.right, KeyCode.D);
        MoveGameObject(Vector3.left, KeyCode.A);
        MoveGameObject(Vector3.forward, KeyCode.W);
        MoveGameObject(Vector3.back, KeyCode.S);

        if (transform.position.x >= limX)
        {
            transform.position = new Vector3(limX, transform.position.y, transform.position.z);
        }
        if (transform.position.x <= -limX)
        {
            transform.position = new Vector3(-limX, transform.position.y, transform.position.z);
        }

        if (transform.position.z >= limZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, limZ);
        }
        if (transform.position.z <= -limZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -limZ);
        }
    }

    public void MoveGameObject(Vector3 direction, KeyCode kCode)
    {
        if (Input.GetKeyDown(kCode))
        {
            transform.position += direction;
        }
    }
}
