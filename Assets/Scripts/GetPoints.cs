using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPoints : MonoBehaviour
{
    public float getPoints;
    [SerializeField] GameObject point;
    [SerializeField] GameObject[] combineFields;
    int i = 0;
    void Update()
    {
        LookForEmpty scr = combineFields[i].GetComponent<LookForEmpty>();
        if (scr.isEmpty == false)
        {
            i++;
            if (true == combineFields[0].GetComponent<LookForEmpty>().isEmpty)
            {
                i = 0;
            }
            if (i > 10)
            {
                i = 0;
            }

        }
        if (getPoints >= 20)
        {
            if(true == combineFields[i].GetComponent<LookForEmpty>().isEmpty)
            {
                Instantiate(point, combineFields[i].transform.position, Quaternion.identity);
                getPoints = 0;
            }
        }
    }
}
