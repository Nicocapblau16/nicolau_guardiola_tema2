using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patata_caliente : MonoBehaviour
{
    private int counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = Random.Range(5, 11);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        counter -= 1;
        if (counter <= 0)
        {
            Debug.Log(message: "cubito just fucking died");
            Destroy(gameObject);
        }
        transform.localScale += 1 * Vector3.one;
    }
}
