using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UIElements;

public class FollowMouse : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Intializes a Vector2 that can get the mouses position and assigns it to the game objects positon
        Vector2 newPos = transform.position;
        //Converts the mouses position to a Vector2 variable that can be used to change the game objects position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //Sets the X value of the newPos vector to the X value of the mouse to move the game object
        //newPos.x = mousePos.x;
        Vector2 screenPos = Camera.main.ScreenToWorldPoint(mousePos);
        //Sets the X value of the newPos vector to the X value of the mouse to move the game object
        //Uses a clamp to restrict the minimum and maximum value of the mouses X position so that the game object can stay on screen
        newPos.x = Mathf.Clamp(mousePos.x, screenPos.x, screenPos.x * -1);
        //Reassigns the objects position to the value of newPos, allowing the objects position to change based on the mouses X value 
        transform.position = newPos;
    }
}