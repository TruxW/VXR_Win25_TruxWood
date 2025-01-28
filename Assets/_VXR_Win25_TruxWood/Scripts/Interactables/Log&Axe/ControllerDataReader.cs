using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerDataReader : MonoBehaviour

{

    [SerializeField] private InputActionProperty velocityProperty;


    public Vector3 Velocity { get; private set; } = Vector3.zero;



    void Update()
    {
        Velocity = velocityProperty.action.ReadValue<Vector3>();
        //Debug.Log(FormativeVelocity(Velocity,1))


    }

    private string FormatVelocity(Vector3 velocity, int decimalPlaces = 1)

    {

        float multiplier = Mathf.Pow(10, decimalPlaces);
        float x = Mathf.Round(velocity.x * multiplier) / multiplier;
        float y = Mathf.Round(velocity.y * multiplier) / multiplier;
        float z = Mathf.Round(velocity.z * multiplier) / multiplier;

        return $"{x} {y} {z}";

    }



}

