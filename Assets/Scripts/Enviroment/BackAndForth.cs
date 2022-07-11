using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForth : MonoBehaviour
{
    public float speed = 3.0f;
    public float maxZ = 16.0f;
    public float minZ = -16.0f;

    private int _direction = 1;

    void Update()
    {
        transform.Translate(0, 0, _direction * speed * Time.deltaTime);

        bool bounced = false;
        if (transform.position.z < minZ || transform.position.z > maxZ)
        {
            _direction = -_direction;
            bounced = true;
        }

        if (bounced)
        {
            transform.Translate(0, 0, _direction * speed * Time.deltaTime);
        }
    }
}
