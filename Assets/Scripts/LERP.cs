using UnityEngine;

public class LERP : MonoBehaviour
{
    //Initializes a public transform that acts as the start point for the interpelation and can be set to the position of a game object in the inspector
    public Transform startpoint;
    //Initializes a public transform that acts as the start point for the interpelation and can be set to the position of a game object in the inspector
    public Transform endpoint;
    //Initializes a variable that  acts as a timer to represent how long it has been since the last interpelation
    public float t = 0;
    //Initializes a public variable that represets how long an object should wait since its last interpelation that gets changed in the inspector
    public float l;
    //Initializes an animation curve that can be changed within the inpspector to detrmine the speed at which an object does an interpelation
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
        //Checks whether the time since the last interpelation has exceeded the the time the interpelation should've taken
        if (t > l)
        {
           //Sets the time between interpelations back to zero which sets it back at its starting position
            t = 0;
        }
        //Creates a linear interpelation from the one game object to the other which are both set in the inspector that uses the varibele of t to determine when it should happen
        transform.position = Vector2.Lerp(startpoint.position, endpoint.position, c.Evaluate(t));
    }
}
    

