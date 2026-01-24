using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class UFOMovement : MonoBehaviour
{
    public float speed = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

        Vector2 newPos = transform.position;
        newPos.x += speed;
        transform.position = newPos;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x > Screen.width || screenPos.x < 0)
        {
            speed = speed * -1;
            speed += speed * Time.deltaTime;



        }
    }
}
