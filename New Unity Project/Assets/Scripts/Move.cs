using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField] Animator Anim;
    [SerializeField] Rigidbody2D rb;

    float speed;

    float desplX;

    [SerializeField] float jumpForce;

    float maxSpeed;

    bool alive = true;

    float runMultiplier;


    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        maxSpeed = 5f;
        jumpForce = 10f;
    }

    void Update()
    {
        desplX = Input.GetAxis("Horizontal");
        //print(desplX);
        Anim.SetFloat("Velocidad", Mathf.Abs(desplX) );


        if (Input.GetKeyDown("space"))
            Salto();
      
            Correr();

            Agachar();

            

        


            

        rb.velocity = new Vector2(desplX * maxSpeed, rb.velocity.y);
    }
    void Correr()
    {
        if (Input.GetKeyDown("left shift"))
        {
            Anim.SetBool("Correr", true);

        }
        if (Input.GetKeyUp("left shift"))
        {
            Anim.SetBool("Correr", false);
        }
    }

    void Agachar()
    {
        if (Input.GetKeyDown("left ctrl"))
        {
            Anim.SetBool("Agachar", true);

        }
        if (Input.GetKeyUp("left ctrl"))
        {
            Anim.SetBool("Agachar", false);
        }
    }
    void Salto()
    {
        Anim.SetTrigger("Salto");
        //print("saltando");
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
                                                        