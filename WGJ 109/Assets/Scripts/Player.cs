using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float spd = 10f;
    public float jumpH = 5f;
    public Collider2D groundCheck;

    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A)) 
		{ 
			rb.AddForce(new Vector3(-1f, 0f) * spd);
			//Play animation
		}		
        else if (Input.GetKey(KeyCode.D)) 
		{ 
			rb.AddForce(new Vector3(1f, 0f) * spd); 
			//Play animation
		}

        Debug.Log("Grounded: " + groundCheck.IsTouchingLayers());

        if (Input.GetKeyDown(KeyCode.Space) && groundCheck.IsTouchingLayers())
            { 
				rb.AddForce(new Vector3(0f, 2f) * jumpH); 
				//Anim
			}
    }
}
