using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookForEmpty : MonoBehaviour
{
    public bool isEmpty = true;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Point")
        {
            isEmpty = false;
        }
        else if(other.gameObject.tag != "Point")
        {
            isEmpty = true;
        }
    }
}
