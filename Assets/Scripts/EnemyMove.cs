using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    float speed = 2.7f;
    void Update()
    {
        transform.Translate(Vector3.forward *speed  * Time.deltaTime);
    }
}
