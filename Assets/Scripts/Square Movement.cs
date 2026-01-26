using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class SquareMovement : MonoBehaviour
{
  float speed = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 newPos = transform.position;
        newPos.y += speed;
        transform.position = newPos;
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < -5)
            speed *= -1;
    }
}



