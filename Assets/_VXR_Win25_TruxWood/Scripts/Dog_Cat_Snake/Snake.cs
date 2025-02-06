using UnityEngine;

public class Snake : Animal
{
    Color Color = Color.white;


    private void Start()
    {
        Name = "SnakeS";
    }

    public override void MakeSound()
    {
        Debug.Log("Snake hiss" + Name);

    }


}
