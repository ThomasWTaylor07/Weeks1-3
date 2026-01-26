using UnityEngine;

public class LERP : MonoBehaviour
{
    //Initializes a public transform that is meant to be the end point for the interpelation and is made public so it can be set to the position of the game object in the inspector
    public Transform startpoint;
    //Initializes a public transform that is meant to be the end point for the interpelation and is made public so it can be set to the position of the game object in the inspector
    public Transform endpoint;
    //Initializes a variable that counts how long it has been since the last interpelation that gets checked by the code
    public float t = 0;
    //Initializes a public variable that represets how long an object should wait since its last interpelation that can be changed in the inspector
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
        //Creates a timer for t that update every frame and count how many seconds it has been since an interpelation, using delta time to ensure the time doesn't change based on framerate
        t += Time.deltaTime;
        //Checks whether the time since the last interpelation has exceeded the the time the interpelation should've taken
        if (t > l)
        {
           //Sets the time between interpelations back to zero which starts the linear interpelation again
            t = 0;
        }
        //Creates a linear interpelation from the starting position of one object to the position of another object both set in the inspector that uses the varibele of t to determine when it should start and when it should end
        transform.position = Vector2.Lerp(startpoint.position, endpoint.position, c.Evaluate(t));
    }
}
    

