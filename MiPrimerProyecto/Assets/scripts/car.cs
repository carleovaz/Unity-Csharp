using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Los dos puntos significa herencia, por lo que nuestra clase posee atributos de MonoBehaviour
public class car : MonoBehaviour
{
    public string marca = "Opel";
    public string modelo = "corsa";
    public Color color = Color.gray;
    public int cv = 150;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Arrancar();
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            Parar();
        }
    }

    void Arrancar()
    {
        Debug.Log("brum");
    }

    void Parar()
    {
        Debug.Log("stop");
    }
}
