using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundOrigin : MonoBehaviour
{
    float smooth = 5.0f;
    float tiltAngleZ = 0f;
    float incrementVariable = 0.3f;
    int angleLimit = 100;
    int angleLimitNegative = -40;
    void Start()
    {

    }

    void Update()
    {
        if(tiltAngleZ >= angleLimit || tiltAngleZ <= angleLimitNegative)
            incrementVariable *= -1;
        tiltAngleZ += incrementVariable;
        Quaternion target = Quaternion.Euler(0, 0, tiltAngleZ);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}
