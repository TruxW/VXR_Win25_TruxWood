using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class JumpLocomation : MonoBehaviour
{
    [SerializeField] InputActionReference jumpInput;
   // public class RigidBody3D Rb; 
    public float jumpAmount = 35;
    public float gravityScale = 10;
    public float fallingGravityScale = 40;
    


    

    private void OnEnable()
    {
        jumpInput.action.performed += Jump;
    }

    private void Jump(InputAction.CallbackContext context)
    {
        Debug.Log("Jump is Performed");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           // rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }

      //  if (rb.velocity.y >= 0)
        {
          //  rb.gravityScale = gravityScale;
        }
      //  else if (rb.velocity.y < 0)
        {
          //  rb.gravityScale = fallingGravityScale;
        }
    } 
}
