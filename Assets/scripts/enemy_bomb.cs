using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bomb : MonoBehaviour
{
    public GameObject lossPanel;
    
    void Start()
    {
       
    }



    
    void Update()
    {
        Vector3 directions = new Vector3(-0.3f, 0f, 0f)*Time.deltaTime;
        transform.Translate(directions);
        
    }

   
    private void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.CompareTag ("Player"))
        {
            print("boom");

            Time.timeScale = 0f;
            lossPanel.SetActive(true);


        }
        else
        {
            print("no boom for you");
            transform.Rotate(Vector3.up, 45);
            

        }
        
        
    }


}

