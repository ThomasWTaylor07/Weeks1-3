using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class SquareMovement : MonoBehaviour
{
  //Initializes the speed variable that is added to a Vector2 to change the game objects position through the inspector
  public float speed = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Creates a vector2 that's being assigned to the game objects position so that it is able to be changed its later
        Vector2 newPos = transform.position;
        //Sets the Y value of the Vector2 that will be added to the objects positon to create continous movement every frame that is consistent as it is using delta time
        newPos.y += speed * Time.deltaTime;
        //Assigns the objects position back to the value of the newPos so it can update the objects position, allowing it to move with speed
        transform.position = newPos;
        //Initializes a Vector2 that checks the value of transform.position within where the camera is showing so the position can stay on screen
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        //Checks whether the object is on the top or bottom of the screen, allowing the postion to be made when those conditions are met
        if (screenPosition.y > Screen.height - 100 || screenPosition.y < -1)
        {

            //Turns the value of speed negative which reverses the position of the game object and preventing it from going off scren
            speed *= -1;
        }
    }
}



