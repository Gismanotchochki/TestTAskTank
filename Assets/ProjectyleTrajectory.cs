using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectyleTrajectory : MonoBehaviour
{
    Rigidbody2D projectileBody;

    void Start()
    {
        projectileBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float angle = Mathf.Atan2(projectileBody.velocity.y, projectileBody.velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
