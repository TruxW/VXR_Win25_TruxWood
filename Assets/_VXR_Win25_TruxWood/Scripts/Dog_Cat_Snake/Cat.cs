using UnityEngine;

public class Cat : Animal
{
    private void Start()
    {
        Name = "Cat";
    }

    public override void MakeSound()
    {
        Debug.Log("Cat perr" + Name);
        
    }
}
