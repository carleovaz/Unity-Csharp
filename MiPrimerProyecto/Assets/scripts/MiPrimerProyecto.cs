//NUESTRO SCRIPT VA A USAR EL MOTOR DE UNITY
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPrimerProyecto : MonoBehaviour
{
    //CREACION DE VARIABLES
    public string playerName = "Carlos Leon";
    private int playerScore = 0;
    private int maxScore = 120;
    public int playerAge = 28;
    public int playerLeve = 1; 

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log sirve para imprimir por consola
        Debug.Log("Tu resultado es = " + (playerScore + 12));
        //Llamamos al metodo
        BirthDate();
    }

    // Update is called once per frame
    //ejecuta una 60 veces por segundo, si movemos un metodo el, actuaria similar a un bucle infinito
    void Update()
    {
        //Con el metodo GetKeyUp, actua como el Keypress de Java
        //Si pulsamos B, llama al metodo
        if (Input.GetKeyUp(KeyCode.B))  BirthDate();
    }
    //CREACION DE METODOS
    void BirthDate()
    {
        Debug.Log("La edad del usuario" + playerName + " es = " +  (playerAge + 1));
    }
}
