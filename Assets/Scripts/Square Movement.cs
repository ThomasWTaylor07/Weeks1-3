using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class SquareMovement : MonoBehaviour
{
  float speed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed += speed * Time.deltaTime;
        Vector2 newPos = transform.position;
        newPos.y += speed;
        transform.position = newPos;
        if (newPos.y < Screen.height || newPos.y > 0)

            speed += speed * -1;
                
                }
    
}



