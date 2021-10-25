using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class par_impar : MonoBehaviour
{
    public int num;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            num = int.Parse(GetComponent<InputField>().text);
            serpar(num);
        }
    }
    public void serpar(int num)
    {
        if (num == 0)
        {
            Debug.Log(message: "Introduce otro número");
        }
        else
        {
            if (num % 2 == 0)
            {
                Debug.Log(message: $"El número {num} es par");
            }
            else
            {
                Debug.Log(message: $"El número {num} es impar");
            }
        }
    }
}
