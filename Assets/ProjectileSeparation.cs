using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSeparation : MonoBehaviour
{
    float timer = 0f;
    int projectileAmount = 3;
    public float separationForce;
    float startAngle = 60.0f;
    float endAngle = 150.0f;
    Vector2 bulletDirection;
    public GameObject projectileSep;
    void Start()
    {
        
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.5)
        {
            Fire();
            Destroy(gameObject);
        }
    }
    void Fire()
    {
        float angleStep = (endAngle - startAngle) / projectileAmount;
        float angle = startAngle;
        for(int i = 0; i < projectileAmount; i++) 
        { 
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);
            Debug.Log(bulDirX);
            Debug.Log(bulDirY);
            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;
            GameObject projectileRB = Instantiate(projectileSep, transform.position, Quaternion.identity);
            projectileRB.transform.rotation = transform.rotation;
            projectileRB.GetComponent<Rigidbody2D>().velocity = bulDir * separationForce * 4;
            angle += angleStep;
        }
    }
}
