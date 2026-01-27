using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class SquareMovement : MonoBehaviour
{
  //Initializes a speed variable thats value is set in the inspector and added to a Vector2 to change the game objects position 
  public float speed = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Initilizes and assigns a new Vector2 to the game objects position so that it can be changed later
        Vector2 newPos = transform.position;
        //Adds the value of speed to the Y value of newPos so it can add that value to the objects position, allowing it to move
        newPos.y += speed * Time.deltaTime;
        //Assigns the objects position back to the value of the newPos so it can update the objects position
        transform.position = newPos;
        //Initializes a Vector2 that checks the value of transform.position within the cameras view so that the object can stay on screen
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        //Checks whether the object is on the top or bottom of the screen, allowing the postion to be changed when those conditions are met
        if (screenPosition.y > Screen.height - 100 || screenPosition.y < -1)
        {

            //Turns the value of speed negative which reverses the position of the game object and preventing it from going off screen
            speed *= -1;
        }
    }
}



