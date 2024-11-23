using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAmeOver : MonoBehaviour
{

    [SerializeField] GameObject over;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            //over.SetActive(true);
            //Time.timeScale = 0f;
        }
    }
}
