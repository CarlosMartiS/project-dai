using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Prephix MPPal_
//To use this example, attach this script to an empty GameObject. In this case "Menu Manager" object in the hierarchy
//Click the Button in Play Mode to output the message to the console.

enum BotonesMenuPpal { MPPal_Jugar, MPPal_Opciones, MPPal_Salir, MPPal_TotalBotones }

public class MenuPpal : MonoBehaviour {

    string[] nombreBoton = {"Jugar",
                            "Opciones",
                            "Salir"};

    //Make sure to attach these Buttons in the Inspector
    public Button[] boton;

    void Start()
    {
        //Create the new space for the buttons
        boton = new Button[(int)BotonesMenuPpal.MPPal_TotalBotones];
        //Select the empty GameObject (Menu Manager) in the Hierarchy 
        //Drag and drop each one of the UI Buttons from the Hierarchy to the every Button array fields in the Inspector when the Menu Manager empty gameObject is selected

        for (int i = (int)BotonesMenuPpal.MPPal_Jugar; i< (int)BotonesMenuPpal.MPPal_TotalBotones;i++)
            boton[i] = GameObject.Find(nombreBoton[i]).GetComponent<Button>();

        //Calls the jugarClicked method when you click the Button Jugar
        boton[(int)BotonesMenuPpal.MPPal_Jugar].onClick.AddListener(jugarClicked);
        //boton[(int)BotonesMenuPpal.MPPal_Puntuaciones].onClick.AddListener(delegate { genericClicked("Pressed button Puntuaciones"); });
        //boton[(int)BotonesMenuPpal.MPPal_Puntuaciones].onClick.AddListener(puntuacionesEnter);
        boton[(int)BotonesMenuPpal.MPPal_Opciones].onClick.AddListener(opcionesClicked);
        boton[(int)BotonesMenuPpal.MPPal_Salir].onClick.AddListener(salirClicked);
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
