using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    private float limX = 12f;
    private float limYPos = 6f;
    private float limYNeg = -5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObject(Vector3.right, KeyCode.D);
        MoveGameObject(Vector3.left, KeyCode.A);
        MoveGameObject(Vector3.forward, KeyCode.W);
        MoveGameObject(Vector3.back, KeyCode.S);
        MoveGameObject(Vector3.up, KeyCode.E);
        MoveGameObject(Vector3.down, KeyCode.Q);

        //limites de pantalla
        if (transform.position.x >= limX)
        {
            transform.position = new Vector3(limX, transform.position.y, transform.position.z);
        }
        if (transform.position.x <= -limX)
        {
            transform.position = new Vector3(-limX, transform.position.y, transform.position.z);
        }
        if (transform.position.y >= limYPos)
        {
            transform.position = new Vector3(transform.position.x, limYPos, transform.position.z);
        }
        if (transform.position.y <= limYNeg)
        {
            transform.position = new Vector3(transform.position.x, limYNeg, transform.position.z);
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
