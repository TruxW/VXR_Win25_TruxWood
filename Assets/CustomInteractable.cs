using UnityEngine;
using UnityEngine. XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class CustomInteractable : XRBaseInteractable
{
    bool ifPulled = false;

    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        base.ProcessInteractable(updatePhase);
    }
}
