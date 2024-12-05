using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectileOutput : MonoBehaviour
{
    public Button button;
    public GameObject projectile;
    float launchForce = 10.0f;
    void Start()
    {
        button.onClick.AddListener(Shoot);
    }

    void Update()
    {

    }

    void Shoot()
    {
        GameObject projectileRB = Instantiate(projectile, transform.position, Quaternion.identity);
        projectileRB.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;
    }
}
