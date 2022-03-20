using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamientoAnimal : MonoBehaviour
{
    public string animalSound = "Unknown";
    public string perro = "Guau Guau";
    public string gato = "Miau Miau";
    public string conejo = "Murf Murf";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            animalSound = perro;
            AnimalSounds();
        }
        else if(Input.GetKeyUp(KeyCode.G))
        {
            animalSound = gato;
            AnimalSounds();
        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            animalSound = conejo;
            AnimalSounds();
        }

        else if (Input.GetKeyUp(KeyCode.A))
        {

            AllAnimalSounds();
        }
    }

    void AnimalSounds()
    {
        Debug.Log("El sonido del animal es = " + animalSound);
    }

    void AllAnimalSounds()
    {
        Debug.Log(perro);
        Debug.Log(gato);
        Debug.Log(conejo);


    }
}
