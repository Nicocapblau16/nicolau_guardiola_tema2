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
    [SerializeField] private bool isOn = true;
    [SerializeField] private float gasoline;




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
        

        Debug.Log($"{name} tiene {numberWheels} ruedas y hace {sound}");
        //si hasSiren es true se muestra el mensage: nombre tiene sirena
       
        if (hasSiren)
        {
            Debug.Log($"{name} tiene sirena");
        }
        
        else
        {
            Debug.Log(message: $"{name} no tiene sirena");
        }
        
        
        if (isOn == true)
        {
            Debug.Log(message: $"{sound}");
        }
        else if (hasSiren == true)
        {
            Debug.Log(message: $"{name} hara {sound} cuando se ponga en marcha");
        }
        else
        {
            Debug.Log(message: $"{name} no está en marcha");
        }
        
        if (gasoline < 10 && isOn == true)
        {
            Debug.Log(message: $"a {name} le queda poca gasolina");
        }
        */

        /*if (isOn == true)
        {
            if (gasoline < 10)
            {
                Debug.Log(message: $"a {name} le queda poca gasolina");
            }
            if (hasSiren == true)
            {
                Debug.Log(sound);
            }
            else
            {
                Debug.Log(message: $"{name} no tiene sirena");
            }
        }
        else
        {
            Debug.Log(message: $"{name} no esta en marcha");
        }
        */
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn == true)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.position += Vector3.right;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.position -= Vector3.right;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.position += Vector3.up;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.position -= Vector3.up;
            }
        }
    }
}
