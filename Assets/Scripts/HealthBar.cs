using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	public bool canBePressed;


	public Image bar;
	public float fill;
    // Start is called before the first frame update
    void Start()
    {
        fill = 1f;
    }

    // Update is called once per frame
    void Update()
    {

        
    }

        private void OnTriggerExit2D(Collider2D other)
    {
    	if(other.tag == "Activator")
    	{
            canBePressed = false;

            if(transform.position.y <= -0.33)
            {

            	fill -= 0.1f;
           		bar.fillAmount = fill;
            }
    	}
    }
}
