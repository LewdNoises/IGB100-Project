using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   
    public float movespeed = 100;
    public SpriteRenderer sr;
    public float EntityColour;
    

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color=Color.grey;
    }

    // Update is called once per frame
    void Update()
    {

        //Movement Code

        if(Input.GetKey(KeyCode.D)){
            transform.position += Vector3.right * movespeed * Time.deltaTime;
        }

        else if(Input.GetKey(KeyCode.A)){
            transform.position += Vector3.left * movespeed * Time.deltaTime;
        }
        
        else if(Input.GetKey(KeyCode.W)){
            transform.position += Vector3.up * movespeed * Time.deltaTime;
        }

        else if(Input.GetKey(KeyCode.S)){
            transform.position += Vector3.down * movespeed * Time.deltaTime;
        }

        

        // Colour Change Code
        
        
        }
        
 
        
    
}
