using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myfirstscript : MonoBehaviour
{
    /*
    public int playerAge = 35;
    private float playerSpeed = 5.25f;
    public string playerName = "Lyu";
    [SerializeField]
    private bool gameOver;
  */

    [SerializeField] private int x = 5;
    [SerializeField] private int y = 3;
    [SerializeField] private int z = 3;
    public string playerName = "Lyu";
    public string enemyName = "Lyu";
    /*
    [SerializeField] private bool isRaining;
    */
    // Start is called before the first frame update
    void Start()
    {
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
        */
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (isRaining)
        {
            Debug.Log(message: "Llevate un paraguas");
        }
        */
    }
}