using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicle : MonoBehaviour
{
    /*
    //sound guarda el sonido que hace el vehículo
    //name guarda los nombres de los vehiculos
    //numberWheels guarda el numero de ruedas por vehiculo
    
    [SerializeField] private int x = 5;
    [SerializeField] private int y = 3;
    */
    [SerializeField] private string name = "";
    [SerializeField] private int numberWheels = 4;
    [SerializeField] private string sound = "Brum, Brum";
    public bool hasSiren;




    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log(message: string.Format("Suma: {0} + {1} = {2}", x, y, x + y));
        Debug.Log(message: string.Format("Resta: {0} - {1} = {2}", x, y, x-y));
        Debug.Log(message: string.Format("Producto: {0} * {1} = {2}", x, y, x * y));
        Debug.Log(message: string.Format("Division: {0} / {1} = {2}", x , y, x / y));
        
        Debug.Log(sound);
        Debug.Log($"hello {sound}");
        */

        Debug.Log($"{name} tiene {numberWheels} ruedas y hace {sound}");
        //si hasSiren es true se muestra el mensage: nombre tiene sirena
       
        if (hasSiren)
        {
            Debug.Log($"{name} tiene sirena");
        }


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
