using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guessTheNumber : MonoBehaviour
{
    private int randNum;
    private int answer;
    private int counter;
    // Start is called before the first frame update
    void Start()
    {
        randNum = Random.Range(1,11);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            answer = int.Parse(GetComponent<InputField>().text);
            if (answer == randNum)
            {
                Debug.Log(message: $"Has acertado");
                Debug.Log(message: $"Has necesitado {counter} intentos");
                Destroy(gameObject);
            }
            else if (answer < randNum)
            {
                Debug.Log(message: $"{answer} és más pequeño");
            }
            else
            {
                Debug.Log(message: $"{answer} és mayor");
            }
            counter++;
        }
    }
}
