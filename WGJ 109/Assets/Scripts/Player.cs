using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float spd = 10f;
    public float jumpH = 5f;
    public Collider2D groundCheck;

    private Rigidbody2D rb;
    private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-1f, 0f) * spd);
            transform.localScale = new Vector3(-10f, 10f, 0);
            anim.SetBool("run", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(1f, 0f) * spd);
            transform.localScale = new Vector3(10f, 10f, 0);
            anim.SetBool("run", true);
        }
        else { anim.SetBool("run", false); }

        Debug.Log("Grounded: " + groundCheck.IsTouchingLayers());

        if (Input.GetKeyDown(KeyCode.Space) && groundCheck.IsTouchingLayers())
            { 
				rb.AddForce(new Vector3(0f, 2f) * jumpH); 
				//Anim
			}
    }
}
