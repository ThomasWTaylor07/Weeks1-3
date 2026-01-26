using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class UFOMovement : MonoBehaviour
{   //Initializes a public variable that is used to change the position of the UFO
    public float speed = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Assigns a new Vector2 to game objects position so it can be moved later in the code
        Vector2 newPos = transform.position;
        //Adds the value of the speed variable multiplied by delta time to create consistent movement for the UFO while keeping it consistent for all framerates
        newPos.x += speed  * Time.deltaTime;
        //Assigns the UFOs positions back to the value of newPos so that it can take its updated position and move on the screen
        transform.position = newPos;
        //Initializes a Vector2 that checks the UFO's position on the screen which we will use to ensure the UFO stays on screen
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        //This conditional statement checks whether the UFO is off screen and change its position so that if it ever is, it can get back on screen
        if (screenPos.x > Screen.width || screenPos.x < 0)
        {
            //
            speed = speed * -1;
           



        }
    }
}
