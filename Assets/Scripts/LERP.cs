using UnityEngine;

public class LERP : MonoBehaviour
{
    public Transform startpoint;
    public Transform endpoint;
    public float t = 0;
    public AnimationCurve c;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }
        transform.position = Vector2.Lerp(startpoint.position, endpoint.position, c.Evaluate(t));
    }
}
    

