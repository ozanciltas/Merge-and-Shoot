using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DragNdrop : MonoBehaviour
{
    Vector3 offset;
    int Id;
    bool mouseRelease;
    bool CannonTrigered;
    string destiantionTag = "CombineArea";
    [SerializeField] GameObject pointPreFab;
    [SerializeField] GameObject gunPreFab;
    [SerializeField] GameObject[] spawnPoint;

    private void Start()
    {
        Id = GetInstanceID();

    }
    private void OnMouseDown()
    {
        mouseRelease = false;
        offset = transform.position - MouseworldPosition();
        transform.GetComponent<Collider>().enabled = false;
    }
    private void OnMouseDrag()
    {
        transform.position = MouseworldPosition() + offset;
    }
    private void OnMouseUp()
    {
        mouseRelease = true;
        var rayOrigin = Camera.main.transform.position;
        var rayDirection = MouseworldPosition() - Camera.main.transform.position;
        RaycastHit hit;
        if (Physics.Raycast(rayOrigin,rayDirection,out hit))
        {
            if (hit.transform.tag == destiantionTag)
            {
                transform.position = hit.transform.position;
            }
        }
        transform.GetComponent<Collider>().enabled = true;
    }
    Vector3 MouseworldPosition()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Point" || other.gameObject.tag == "Cannon" || other.gameObject.tag == "GunArea")  
        {
            if (other.gameObject.tag == "Cannon")
            {
                CannonTrigered = true;
                string thisPoint = gameObject.GetComponentInChildren<TextMeshProUGUI>().text;
                string otherPoint = other.gameObject.GetComponentInChildren<TextMeshProUGUI>().text;
                if (thisPoint == otherPoint && mouseRelease)
                {
                    int nextnumber = Int32.Parse(otherPoint) + 1;
                    other.GetComponentInChildren<TextMeshProUGUI>().text = nextnumber.ToString();
                    Destroy(gameObject);
                }
            }
            else if (other.gameObject.tag == "GunArea")
            {
                if (CannonTrigered)
                {
                    return;
                }
                GameObject pl = GameObject.Find("Player");
                PlayerMove pscr = pl.GetComponent<PlayerMove>();
                Vector3 originalPos = pl.transform.position;
                pl.transform.position = new Vector3(0, 0, -1.75f);
                string thisPoint = gameObject.GetComponentInChildren<TextMeshProUGUI>().text;
                var gun = Instantiate(gunPreFab,spawnPoint[pscr.spawncount].transform.position, Quaternion.identity);
                pscr.spawncount++;
                gun.transform.SetParent(pl.transform);
                gun.GetComponentInChildren<TextMeshProUGUI>().text = thisPoint;
                pl.transform.position = originalPos;
                Destroy(gameObject);
            }
            else
            {
                if (Id > other.gameObject.GetComponent<DragNdrop>().Id)
                {
                    return;
                }
                string thisPoint = gameObject.GetComponentInChildren<TextMeshProUGUI>().text;
                string otherPoint = other.gameObject.GetComponentInChildren<TextMeshProUGUI>().text;
                if (thisPoint == otherPoint && mouseRelease)
                {
                    int nextnumber = Int32.Parse(otherPoint) +1 ;
                    var point = Instantiate(pointPreFab, other.gameObject.transform.position, Quaternion.identity);
                    point.GetComponentInChildren<TextMeshProUGUI>().text = nextnumber.ToString();
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                }
            }
        }
    }
}
