using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
     //The Camera's position needs to be the same as the car's position

    //This lets us put Driver McDriverson in the thing to follow field 
    [SerializeField] GameObject thingToFollow;

   //Use LateUpdate instead of update so it is different from car update, and keeps camera smooth since they don't fight for the same event loop
    void LateUpdate()
    {
        //This gets the camera position and puts it on top of the thingToFollow position. The new Vector is so we can set the camera to be above the car instead of inside the car
        transform.position = thingToFollow.transform.position + new Vector3 (0, 0, -10);
    }
}
