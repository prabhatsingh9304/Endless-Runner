
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    CharacterController controller;
    Vector3 direction;
    public float forwardSpeed;
    public float moveSpeed = 3f;
    public float leftRightSpeed = 4f;
    public float jumpForce = 10f;
    public float gravity =-20f;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.z = forwardSpeed;
        controller.Move(direction * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            if(this.gameObject.transform.position.x >= LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
            
        }

        //Gyroscopic Control
        /*
        float dirc=Input.acceleration.x;
        transform.Translate(new Vector3(Mathf.Clamp(Input.acceleration.x,LevelBoundary.leftSide,LevelBoundary.rightSide),0f,0f) * Time.deltaTime * leftRightSpeed);
        */


        if(Input.GetKey(KeyCode.RightArrow))
        {
            if(this.gameObject.transform.position.x <= LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * -leftRightSpeed);
            }
        }
        if(controller.isGrounded)
        {
            if(Input.GetKey(KeyCode.UpArrow))
            {
                jump();
            }
        }
        else
        {
            direction.y += gravity * Time.deltaTime;
        }
    }
    private void jump()
    {
        direction.y = jumpForce;
    }
}
