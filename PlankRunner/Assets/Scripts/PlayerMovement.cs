using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] [Range(-3, 3)] float movement;
    float left = -3;
    float right = 3;

    Rigidbody rigid;
    [SerializeField] [Range(0, 10)] float force;


    [SerializeField] public float speed = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();

       

    }

    // Update is called once per frame
    void Update()
    {
   

        transform.position = new Vector3(movement, transform.position.y, transform.position.z + speed );
        updateSpeed();
       
        


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
                
                rigid.AddForce(0f, force * 100, 0f, ForceMode.Impulse);
                
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

    void updateSpeed()
    {
        if (transform.position.z > 1000 && transform.position.z < 1001)
        {
            speed += 1;
        }
    }
    






}
    

