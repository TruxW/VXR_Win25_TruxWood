using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class JumpLocomation : MonoBehaviour
{
    [SerializeField] InputActionReference jumpInput;


    

    private void OnEnable()
    {
        jumpInput.action.performed += Jump;
    }

    private void Jump(InputAction.CallbackContext context)
    {
        Debug.Log("Jump is Performed");
    }
}
