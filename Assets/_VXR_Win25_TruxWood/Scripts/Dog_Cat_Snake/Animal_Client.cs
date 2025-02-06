using UnityEngine;

public class Animal_Client : MonoBehaviour
{
    [SerializeField] Animal[] animals;
   
   

   private void Start()
    {
        foreach (var animal in animals)
        {
            animal.MakeSound();
        }
    }


}
