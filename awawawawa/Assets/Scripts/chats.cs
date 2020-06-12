using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chats : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        //Button button = gameObject.getComponent<Button>;
        //boton = GameObject
        //boton.onClick.AddListener(jugarClicked);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene("Buddy Bear");
        }
    }

    public void celioClicked()
    {

        SceneManager.LoadScene("scroll");
    }
}
