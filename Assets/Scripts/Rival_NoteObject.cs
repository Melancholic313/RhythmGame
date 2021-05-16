using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rival_NoteObject : MonoBehaviour
{

	public bool canBePressed;

    public GameObject hitEffect, goodEffect, perfectEffect, missEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     		if(canBePressed)   
     		{
     			gameObject.SetActive(false);
     			Instantiate(goodEffect, transform.position, goodEffect.transform.rotation);
                
        	}
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
    	if(other.tag == "Activator")
    	{
    		canBePressed = true;

            
    	}
    }

    private void OnTriggerExit2D(Collider2D other)
    {
    	if(other.tag == "Activator")
    	{
    		canBePressed = false;

            //GameManager.instance.NoteMissed();
            //Instantiate(missEffect, transform.position, missEffect.transform.rotation);
    	}
    }
}
