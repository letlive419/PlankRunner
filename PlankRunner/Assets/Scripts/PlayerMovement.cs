using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] [Range(-3,3)] float movement;
    float left = -3;
    float right = 3;
   
    Rigidbody rigid;
    [SerializeField] [Range(0,100)] float force;
  
    [SerializeField] [Range (0,10)] float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
        

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(movement, transform.position.y, transform.position.z);

        rigid.velocity = (Vector3.forward * Time.time * speed);
        Movement();

      

    }
    private void FixedUpdate()
    {
        Jump();

        
    }

    private void Jump()
    {
        if (Input.GetButtonDown("up") == true)
            if (transform.position.y > .56f)
                return;

            else if (transform.position.y < .56f)
            {
                
                rigid.AddForce(0f, force * 300, 0f);





            }
    }
    void Movement()
    {
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
    }




}
    

