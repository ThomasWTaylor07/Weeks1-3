using UnityEngine;

public class Teleport : MonoBehaviour
{ public Vector2 newPos = Vector2.zero;
    public float t = 3;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t -= Time.deltaTime; 
        if ( t < 0)
        {
            transform.position = Random.insideUnitCircle * 3; 
            t = 3;

        }
 
       
    }
}
