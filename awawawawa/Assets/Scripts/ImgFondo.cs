using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImgFondo : MonoBehaviour {

    const float ImageWidth = 2000.0f,
                TimeOut    =    5.0f;

    public enum SplashStates {Moving,   //The splash image is moving on the screen
                              Finish }  //Time out, a pressed key or the splash image is just moved, go to main menu scene

    public SplashStates State;
    public Vector2      Speed;  //Speed for moving the image on the screen

    float startTime;

    Image image;
    Color32 c;

    // Use this for initialization
    void Start () {
        State = SplashStates.Moving;
        startTime = Time.time;
        image = GetComponent<Image>();
        c = new Color32(85, 85, 85, 100);
        image.color = c;
    }

    // Update is called once per frame
    void Update () {
        switch (State)
        {
            case SplashStates.Moving:   //The splash image is moving on the screen
                transform.Translate (Speed.x * Time.deltaTime, Speed.y * Time.deltaTime, 0.0f);
                if (c.r < 255)
                    c.r+=2;
                else if (c.g < 255)
                    c.g += 2;
                else if (c.b < 255)
                    c.b += 2;
                image.color = c;
                break;
            case SplashStates.Finish:
                SceneManager.LoadScene("´MenuPpal");
                break;
            default:
                break;
        }

        if (Time.time - startTime > TimeOut)    //También se puede acabar la presentación por tiempo
            State = SplashStates.Finish;

        if (Input.GetKey(KeyCode.Escape) || //Si se pulsa la tecla escape
            Input.GetKey(KeyCode.Return) || //Si se pulsa la tecla enter
            Input.GetKey(KeyCode.Space))    //Si se pulsa la tecla espacio

            State = SplashStates.Finish;
    }
}
