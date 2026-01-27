using UnityEngine;

public class LERP : MonoBehaviour
{
    //Initializes a Transform that's the start point for the interpelation which is set to the position of a game object in the inspector
    public Transform startpoint;
    //Initializes a Transform that acts as the end point for the interpelation which is set to a game objects position in the inspector
    public Transform endpoint;
    //Initializes a variable that  acts as a timer to represent how long it has been since the last interpelation
    public float t = 0;
    //Initializes a varible that's set in the inspector and says how long the object needs to wait before it can interpolate again 
    public float l;
    //Initializes an animation curve that can be changed within the inpspector to detrmine the speed at which an object interpelates
    public AnimationCurve c;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Creates a timer for t that update every frame and count how many seconds it has been since an interpelation 
        t += Time.deltaTime;
        //Checks whether the time since the last interpelation has exceeded how long the object needed to wait to interpolate again 
        if (t > l)
        {
           //Sets the time between interpelations back to 0 which sets it back at its starting position, starting another interpelation
            t = 0;
        }
        //Creates a timed linear interpelation from one game object to the other allowing the linear interpelation to happen consistently
        transform.position = Vector2.Lerp(startpoint.position, endpoint.position, c.Evaluate(t));
    }
}
    

