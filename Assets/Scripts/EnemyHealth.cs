using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    float health;
    float enemyCount;
    [SerializeField] ParticleSystem particle;
    [SerializeField] TextMeshProUGUI healthTxt;
    int i = 1;
    private void Start()
    {
        health = Random.Range(2, 9);
        while(health % 2 != 0)
        {
            health = Random.Range(2, 9);
        }
        enemyCount = health;
    }
    private void Update()
    {
        Vector3 parPos = transform.position;
        parPos.y = parPos.y + 2.5f;
        healthTxt.text = health.ToString();
        if (health <= 0)
        {
            var par = Instantiate(particle,parPos, Quaternion.identity);
            Destroy(gameObject);
            Destroy(par, 5);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball1")
        {
            GetPoints scr = GameObject.Find("LevelControl").GetComponent<GetPoints>();
            scr.getPoints += 1;
            health -= 1;
        }
        if (collision.gameObject.tag == "Ball2")
        {
            GetPoints scr = GameObject.Find("LevelControl").GetComponent<GetPoints>();
            scr.getPoints += 2;
            health -= 2;
        }
        if (collision.gameObject.tag == "Ball3")
        {
            GetPoints scr = GameObject.Find("LevelControl").GetComponent<GetPoints>();
            scr.getPoints += 3;
            health -= 3;
        }
        if (collision.gameObject.tag == "Ball4")
        {
            GetPoints scr = GameObject.Find("LevelControl").GetComponent<GetPoints>();
            scr.getPoints += 4;
            health -= 4;
        }
        if (collision.gameObject.tag == "Ball5")
        {
            GetPoints scr = GameObject.Find("LevelControl").GetComponent<GetPoints>();
            scr.getPoints += 5;
            health -= 5;
        }
        if (collision.gameObject.tag == "Ball6")
        {
            GetPoints scr = GameObject.Find("LevelControl").GetComponent<GetPoints>();
            scr.getPoints += 6;
            health -= 6;
        }
        if (collision.gameObject.tag == "Ball7")
        {
            GetPoints scr = GameObject.Find("LevelControl").GetComponent<GetPoints>();
            scr.getPoints += 7;
            health -= 7;
        }
        if (collision.gameObject.tag == "Ball8")
        {
            GetPoints scr = GameObject.Find("LevelControl").GetComponent<GetPoints>();
            scr.getPoints += 8;
            health -= 8;
        }
        if (collision.gameObject.tag == "Ball9")
        {
            GetPoints scr = GameObject.Find("LevelControl").GetComponent<GetPoints>();
            scr.getPoints += 9;
            health -= 9;
        }
        if (collision.gameObject.tag == "Ball10")
        {
            GetPoints scr = GameObject.Find("LevelControl").GetComponent<GetPoints>();
            scr.getPoints += 10;
            health -= 10;
        }
        if (collision.gameObject.tag == "Ball11")
        {
            GetPoints scr = GameObject.Find("LevelControl").GetComponent<GetPoints>();
            scr.getPoints += 11;
            health -= 11;
        }
        if (collision.gameObject.tag == "Ball12")
        {
            GetPoints scr = GameObject.Find("LevelControl").GetComponent<GetPoints>();
            scr.getPoints += 12;
            health -= 12;
        }
        if (collision.gameObject.tag == "Ball13")
        {
            GetPoints scr = GameObject.Find("LevelControl").GetComponent<GetPoints>();
            scr.getPoints += 13;
            health -= 13;
        }
        if (collision.gameObject.tag == "Ball14")
        {
            GetPoints scr = GameObject.Find("LevelControl").GetComponent<GetPoints>();
            scr.getPoints += 14;
            health -= 14;
        }
        if (collision.gameObject.tag == "Ball15")
        {
            GetPoints scr = GameObject.Find("LevelControl").GetComponent<GetPoints>();
            scr.getPoints += 15;
            health -= 15;
        }
        if (collision.gameObject.tag == "Ball16")
        {
            GetPoints scr = GameObject.Find("LevelControl").GetComponent<GetPoints>();
            scr.getPoints += 16;
            health -= 16;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Cannon")
        {
            //Destroy(other.gameObject);
        }
    }
}
