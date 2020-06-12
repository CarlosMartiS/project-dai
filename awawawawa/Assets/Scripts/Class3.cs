using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Prephix MPPal_
//To use this example, attach this script to an empty GameObject. In this case "Menu Manager" object in the hierarchy
//Click the Button in Play Mode to output the message to the console.


public class Class3 : MonoBehaviour
{

    

    //Make sure to attach these Buttons in the Inspector

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Regla del escape
        if (Input.GetKey("escape"))
            salirClicked();

        //Regla del enter
        if (Input.GetKey(KeyCode.Return))
            jugarClicked();
    }

    void jugarClicked()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button Jugar!");
        SceneManager.LoadScene("Buddy Bear");
    }

    void salirClicked()
    {
        //Se cierra la aplicación
        Application.Quit();
        //Se cierra la ejecución si se está en el entorno de desarrollo Unity 3D
        UnityEditor.EditorApplication.isPlaying = false;
    }

    void opcionesClicked()
    {
        SceneManager.LoadScene("MenuOpciones");
    }

    void genericClicked(string message)
    {
        //Output this to console when the Button is clicked
        Debug.Log(message);
    }
}