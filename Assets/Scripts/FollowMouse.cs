using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.SocialPlatforms.GameCenter;
using UnityEngine.UIElements;

public class FollowMouse : MonoBehaviour

{
    public float speed;
    Vector2 center;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        speed += speed * Time.deltaTime;
        Vector2 newPos = transform.position;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        newPos.x = mousePos.x;
        transform.position = newPos;





    }
}
