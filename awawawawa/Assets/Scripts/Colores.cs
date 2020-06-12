using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


//Prefijo: COL_

public class Colores : MonoBehaviour {

    const int COLOR_IMAGE_WIDTH = 256;
    const int COLOR_IMAGE_HEIGHT = 256;

    enum SelectColor { COL_NO_COLOR, COL_AMARILLO, COL_VERDE, COL_ROJO, COL_CIAN, COL_AZUL, COL_MAGENTA, COL_MAX_COLORS }

    public string[] nombreBoton = {"base.png",
                                   "Amarillo.png",
                                   "Verde.png",
                                   "Rojo.png"};
    Sprite[] circuloCromatico;
    Sprite   cromaticoActual;

    // Use this for initialization
    void Start () {
        string path = Application.persistentDataPath + "/circulocromatico/";

        Debug.Log(path);

        //Reservar espacio para el círculo cromático
        circuloCromatico = new Sprite[(int)SelectColor.COL_MAX_COLORS];

        for (int i = (int)SelectColor.COL_NO_COLOR; i < (int)SelectColor.COL_MAX_COLORS; i++)
        {
            byte[] rawImage = File.ReadAllBytes(path + nombreBoton[i]);

            Texture2D texture = new Texture2D(COLOR_IMAGE_WIDTH, COLOR_IMAGE_HEIGHT);
            texture.filterMode = FilterMode.Trilinear;
            texture.LoadImage(rawImage);

            circuloCromatico[i] = Sprite.Create(texture, new Rect(0, 0, COLOR_IMAGE_WIDTH, COLOR_IMAGE_HEIGHT), new Vector2(0.5f, 0.0f), 1.0f);
        }
        cromaticoActual = GetComponent<UnityEngine.UI.Image>().sprite;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("7"))
            cromaticoActual = circuloCromatico[(int)SelectColor.COL_ROJO];
        else if (Input.GetKey("8"))
            cromaticoActual = circuloCromatico[(int)SelectColor.COL_AMARILLO];
        else if (Input.GetKey("9"))
            cromaticoActual = circuloCromatico[(int)SelectColor.COL_VERDE];

        //.... resto de opciones

        else cromaticoActual = circuloCromatico[(int)SelectColor.COL_NO_COLOR];


    }

}
