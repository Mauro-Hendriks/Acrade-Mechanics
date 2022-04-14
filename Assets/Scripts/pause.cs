using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public bool ispaused;
    public GameObject player;
    public GameObject overlay;
    
    void Start()
    {
        cam1.SetActive(false);
        cam2.SetActive(true);
        ispaused = true;
        player.SetActive(false);
        overlay.SetActive(false);
        
    }
 
    void Update()
    {
        if (Input.GetKey(KeyCode.S) && ispaused == true )
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
            player.SetActive(true);
            overlay.SetActive(true);
            ispaused = false;
            
            


        }

        if (Input.GetKeyDown(KeyCode.P) && ispaused == false )
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            player.SetActive(false);
            overlay.SetActive(false);
            ispaused = true;
            
            


        }
    }

    public void Toggle()
    {
        ispaused = !ispaused;
    }
    
}
