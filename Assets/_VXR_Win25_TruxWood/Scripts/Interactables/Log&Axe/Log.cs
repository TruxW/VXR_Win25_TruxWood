using System;
<<<<<<< Updated upstream
using UnityEngine;
using UnityEngine.Rendering.Universal;

[RequireComponent(typeof(Collider))]
=======
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering.Universal;

/// <summary>
/// The log script is checking if there is collision
/// </summary>
[RequireComponent(typeof(Collider
    ))]
>>>>>>> Stashed changes
public class Log : MonoBehaviour
{
    [SerializeField] GameObject logOne;
    [SerializeField] GameObject logTwo;

    Collider m_collider = null;
    [SerializeField] float m_splitThreshold = 6f;
<<<<<<< Updated upstream
    [SerializeField] float m_stickThreshold = 4f;


=======
    
    private void m_stickThreshold = 4f;
   
>>>>>>> Stashed changes
    void Awake()
    {
        m_collider = GetComponent<Collider>();
        m_collider.isTrigger = true;

    }



    private void OnTriggerEnter(Collider other)
    {
<<<<<<< Updated upstream
=======
        if (m_collider != null)
            Debug.Log("CollisionHappening");
    }

    private void OnTriggerEnter(Collider other)
    {
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======

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
       
>>>>>>> Stashed changes
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
