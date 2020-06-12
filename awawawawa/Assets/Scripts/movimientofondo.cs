using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientofondo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5;
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector2 DeformPersp = new Vector2(10,7);
            Vector2 origen = new Vector2(540, 1060);

            Vector2 mousePos = Input.mousePosition;
            Vector2 Vunitario = (origen - mousePos).normalized;

            Vector2 Vperspectiva = Vunitario*DeformPersp.normalized;

            //float theta = Mathf.Atan2((mousePos.y- 1060),(mousePos.x-540));
            transform.Translate(Vperspectiva*speed);
        }
    }
}
