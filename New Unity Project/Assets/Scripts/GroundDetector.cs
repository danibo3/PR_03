using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetector : MonoBehaviour
{

    bool isGrounded = true;

   [SerializeField] GameObject Robot;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = Robot.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //print(isGrounded);

        anim.SetBool("TocandoSuelo", isGrounded);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Suelo")
        {
            isGrounded = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            isGrounded = false;
        }
    }
}
