using System;
using UnityEngine;
using UnityEngine.Rendering.Universal;

[RequireComponent(typeof(Collider
    ))]
public class Log : MonoBehaviour
{
    [SerializeField] GameObject logOne;
    [SerializeField] GameObject logTwo;

    Collider m_collider = null;
    void Awake()
    {
        m_collider = GetComponent<Collider>();
        m_collider.isTrigger = true;
            
    }

    private void OnTriggerEnter(Collider other)
    {
        if (m_collider != null)
            Debug.Log("CollisionHappening");
    }

    private void OnTriggerEnter(Collider other)
    {
        BladeOne blade = null;
        if (other.CompareTag("Blade")) ;
        {
            blade = other.GetComponentInParent<BladeOne>();
        }

        if (blade == null) return; //Quit this funtion earlier if not blade script is found

        if (blade.m_controllerDataReader == null) 
            return;

        Split();
    }

    private void Split()
    {
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
}
