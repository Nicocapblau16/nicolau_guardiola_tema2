using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myfirstscript : MonoBehaviour
{
    /*
    
    private float playerSpeed = 5.25f;
    public string playerName = "Lyu";
    [SerializeField]
    private bool gameOver;
  
    public int playerAge = 15;
    
    public string playerName = "Lyu";
    public string enemyName = "Lyu";
    [SerializeField] private int playerHp = 10;
    
    [SerializeField] private bool isRaining;
    [SerializeField] private bool isCold;
    
    [SerializeField] private int x = 5;
    [SerializeField] private int y = 3;
    [SerializeField] private int z = 3;
    */

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(x: 5, y: 2, z: 0);
        //transform.position = Vector3.zero;
        /*
        Debug.Log(message: x + y);
        
        if (playerName == enemyName)
        {
            Debug.Log(message: "player y enemigo se llaman igual");
        }
        if (playerName != enemyName)
        {
            Debug.Log(message: "player y enemigo tienen distintos nombres");
        }
        
        if (playerHp > 0)
        {
            Debug.Log(message: "sigues vivo");
        }
        else
        {
            Debug.Log(message: "estas muerto");
        }
        
        if (playerAge < 13)
        {
            Debug.Log(message: "Eres un niño");
        }
        else if (playerAge < 18)
        {
            Debug.Log(message: "Eres adolescente");
        }
        else
        {
            Debug.Log(message: "Eres adulto");
        }
        */
        
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position -= Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position += Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position -= Vector3.up;
        }
       if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.forward;
        }
       if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.back;
        }
        */
        /*
        if (isRaining == true)
        {
            if (isCold)
            {
                Debug.Log(message: "Llevate un paraguas y una sudadera");
            }
            else
            {
                Debug.Log(message: "Llevate un paraguas");
            }
            
        }
        else
        {
            Debug.Log(message: "No llueve");
        }
        
      
        MoveGameObject(Vector3.right, keyCode.D);
        MoveGameObject(Vector3.left, keyCode.A);
        MoveGameObject(Vector3.forward, keyCode.W);
        MoveGameObject(Vector3.back, keyCode.S);
        MoveGameObject(Vector3.up, keyCode.E);
        MoveGameObject(Vector3.down, keyCode.Q);
        */
    }
    public void HelloWorld()
    {
        Debug.Log(message: "Hola Mundo");
    }
    public void HelloName(string name)
    {
        Debug.Log(message: $"Hola {name}");
    }
    public string GetHello()
    {
        return "hola";
    }
    public int Sum(int num1, int num2)
    {
        return num1 + num2;
    }
    public void MoveGameObject(Vector3 direction, KeyCode keyCode)
    {
        if (Input.GetKeyDown(keyCode))
        {
            transform.position += direction;
        }
    }
}