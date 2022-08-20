using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public bool GameGOing = true;
    public float Scoree= 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(GameGOing == true)
        {
            Scoree +=1f;
        }
        else 
        {

        }

    }

}    

