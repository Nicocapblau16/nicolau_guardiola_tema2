using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bisiesto : MonoBehaviour
{
    public int year = 2020;
    // Start is called before the first frame update
    void Start()
    {
        if(year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year %400 == 0)
                {
                    Debug.Log(message: $"El a?o {year} es bisiesto");
                }
                else
                {
                    Debug.Log(message: $"El a?o {year} no es bisiesto");
                }
            }
            else
            {
                Debug.Log(message: $"el a?o {year} es bisiesto");
            }
        }
        else
        {
            Debug.Log(message: $"El a?o {year} no es bisiesto");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            year = int.Parse(GetComponent<InputField>().text);
            serBisiesto(year);
        }
    }

    public void serBisiesto(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Debug.Log(message: $"El a?o {year} es bisiesto");
                }
                else
                {
                    Debug.Log(message: $"El a?o {year} no es bisiesto");
                }
            }
            else
            {
                Debug.Log(message: $"el a?o {year} es bisiesto");
            }
        }
        else
        {
            Debug.Log(message: $"El a?o {year} no es bisiesto");
        }
    }
}
