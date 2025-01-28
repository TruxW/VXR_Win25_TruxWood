using System;
using UnityEngine;
using UnityEngine.Rendering.Universal;

[RequireComponent(typeof(Collider))]


/// <summary>
/// The log script is checking if there is collision
/// </summary>

public class Log : MonoBehaviour
{
    [SerializeField] GameObject logOne;
    [SerializeField] GameObject logTwo;

    Collider m_collider = null;
    [SerializeField] float m_splitThreshold = 4f;

    [SerializeField] float m_stickThreshold = 2f;


   

    void Awake()
    {
        m_collider = GetComponent<Collider>();
        m_collider.isTrigger = true;

    }



    private void OnTriggerEnter(Collider other)
    {

        Blade blade = null;
        if (other.CompareTag("Blade")) ;
        {
            blade = other.GetComponentInParent<Blade>();
        }

        if (blade == null) return; //Quit this funtion earlier if not blade script is found

        if (blade.m_controllerDataReader == null)
            return;

        Split(blade);
    }

    private void Split(Blade blade)
    {


        float bladeHitSpeed = blade.m_controllerDataReader.Velocity.magnitude;
        if (bladeHitSpeed > m_splitThreshold)
        {
            //Disable collision so we can only split once
            m_collider.enabled = false;

            EnablePhysics(logOne);
            EnablePhysics(logTwo);
        }

        else if (bladeHitSpeed < m_stickThreshold)
        {
            blade.Drop();
            blade.disablePhysics();
        }
       

        EnablePhysics(logOne);
        EnablePhysics(logTwo);
    }
        
    void EnablePhysics(GameObject log)
    {
        log.transform.parent = null;

        Rigidbody rg = log.GetComponent<Rigidbody>();
        rg.useGravity = true;
        rg.isKinematic = false;

    }

    void DisablePhysics()
    {
        Rigidbody rigidBody = GetComponent<Rigidbody>();
        rigidBody.constraints = RigidbodyConstraints.FreezeAll;
    }

}
