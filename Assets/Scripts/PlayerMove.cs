using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int spawncount;
    private void OnMouseDrag()
    {
        Vector3 pos = transform.position;
        pos.x = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0f, 25f)).x;
        if(pos.x > -5.7f && pos.x < 5.7f)
        {
            transform.position = pos;
        }
    }
}
