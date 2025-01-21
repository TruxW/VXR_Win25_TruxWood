/*using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class Blade : MonoBehaviour
{
    public XRGrabInteractable m_grabInteractable;
    public ConrollerDataReader m_controllerDataReader;
    XRBaseInteractor m_Interactor;



    private void Awake()
    {
        m_grabInteractable = GetComponent<XRGrabInteractable>();
    }



    private void OnEnable()
    {
        if (m_grabInteractable == null)
            return;

        m_grabInteractable.selectEntered.AddListener(OnSelectEnter);
        m_grabInteractable.selectEntered.AddListener(ResetControllerDataReader);
    }

    private void ResetControllerDataReader(SelectEnterEventArgs arg0)
    {
        throw new NotImplementedException();
    }

    private void OnSelectEnter(SelectEnterEventArgs arg0)
    {
       //Set interactor that is grabbing the axe
        m_Interactor = arg0.interactorObject as XRBaseInteractor;

        //Set the ControllerDataReader
        m_controllerDataReader = m_Interactor.transform.GetComponentInParent<ControllerDataReader>();


    }

    //For (ResetControllerDataReader)
    private void ResetControllerDataReader(SelectExitEvent arg0)
    {

    }

    private void OnDisable()
    {
        if (m_grabInteractable == null)
            return;

        m_grabInteractable.selectEntered.AddListener(OnSelectEnter);
        m_grabInteractable.selectEntered.AddListener(ResetControllerDataReader);
    }

    
    
}
*/