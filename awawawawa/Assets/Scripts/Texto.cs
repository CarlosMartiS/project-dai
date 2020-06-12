using UnityEngine;
using System.Collections;
using UnityEngine.UI; // This is so that it should find the Text component

public class Texto : MonoBehaviour
{
    Color oc,   //Original Color
          cc;   //Current Color

    Text texto;

    [SerializeField]
    float incIntensidad, angulo, velAng;
   
    void Start()
    {
        texto = GetComponent<Text>();
        oc = texto.color;
        cc = oc;
    }

    void Update()
    {
        float seno = Mathf.Sin(angulo);

        angulo += velAng * Time.deltaTime;
        cc.r = oc.r * Mathf.Abs(seno);
        cc.g = oc.g * Mathf.Abs(seno);
        cc.b = oc.b * Mathf.Abs(seno);

        //cc.r *= incIntensidad;
        //cc.g *= incIntensidad;
        //cc.b *= incIntensidad;

        //if (cc.r >= 1.0f || cc.g >= 1.0f || cc.b >= 1.0f)
        //    incIntensidad = 1.0f;

        texto.color = cc;
    }

}
