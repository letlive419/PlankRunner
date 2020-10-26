using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] [Range(-3,3)] float movement;
    float left = -3;
    float right = 3;
    float jump = 0;
    float up = 3;
    Rigidbody rigid;
    Vector3 force;
   
    
    [SerializeField] float speed = 200;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        force = new Vector3(movement, jump * speed, transform.position.z);
        

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = new Vector3(movement, transform.position.y, transform.position.z);
        
        rigid.velocity = (Vector3.forward * Time.deltaTime * speed);

        
        
        if (Input.GetButtonDown("left") == true)
        {
            
            if (movement == left)
                return;
            else
            {
                movement -= 3;
            }

        }
        if (Input.GetButtonDown("right") == true)
        {
            if (movement == right)
                return;
            else
            {
                movement += 3;

            }
        }
        if (Input.GetButtonDown("up") == true)
            if (transform.position.y > 0)
                return;

            else if (transform.position.y < 0)
            {
                jump = up;
                rigid.AddForce(force);
                print("jump");




            }
        
    }
    

    

    }
    

