using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnimScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed; // ini les vitesse de dépla et rot 
    public float rotSpeed;
    public float ForceLevel = 5.0f; // force


    Animator anim; // tous ceux qui on ce script sereont affecté par ce sript 
    Rigidbody rb;





    void Start()
    {
        anim = GetComponent<Animator>();// choppe les info  dans l'animator 
        rb = GetComponent<Rigidbody>(); // récupère le composant rigibody de l'objets

    }

    // Update is called once per frame
    void Update()
    {
        //FCE impu
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * ForceLevel, ForceMode.Impulse);

        }

        //Déplacement

        var z = Input.GetAxis("Vertical") * speed *Time.deltaTime;
        var x = Input.GetAxis("Horizontal") * rotSpeed* Time.deltaTime;

        

        transform.Translate(0, 0, z);
        transform.Translate(x, 0, 0);

        

        //config les touches 


        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("IsWalking", true);
            anim.SetBool("IsIdle", false);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("IsWalking", true);
            anim.SetBool("IsIdle", false);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("IsWalking", true);
            anim.SetBool("IsIdle", false);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("IsWalking", true);
            anim.SetBool("IsIdle", false);
        }
        else  
        {
            anim.SetBool("IsWalking", false);
            anim.SetBool("IsIdle", true);
        }


    }
}
