using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Playershoot : MonoBehaviour
{
    [SerializeField] GameObject[] ballPrefab;
    [SerializeField] Transform ballSpawnPoint;
    float ballSpeed = 15;
    float fireRate = 0.3f;
    float fireRateDelta;
    public int newPoint;

    private void Update()
    {
        TextMeshProUGUI txt = gameObject.GetComponentInChildren<TextMeshProUGUI>();
        newPoint = Int32.Parse(txt.text);
        fireRateDelta -= Time.deltaTime;
        if (fireRateDelta <= 0)
        {
            Shoot();
            fireRateDelta = fireRate;
        }
    }

    void Shoot()
    {
        var ball = Instantiate(ballPrefab[newPoint-1], ballSpawnPoint.position, ballSpawnPoint.rotation);
        ball.GetComponent<Rigidbody>().velocity = ballSpawnPoint.forward * ballSpeed;
    }
}
