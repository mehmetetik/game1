using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI;

public class RobotAICtrl : MonoBehaviour
{
    public float speed = 2.0f;
    private GameObject center;
    public float distance;
    public Transform playerCenter;
    public bool inside;
    
    void Start()
    {
        center = GameObject.Find("CENTER");
       // _agent = GetComponent<NavMeshAgent>();
    }
    
    void Update()
    {
        distance = Vector3.Distance(transform.position, center.transform.position);
        transform.position = Vector3.MoveTowards(transform.position, center.transform.position, speed * Time.deltaTime);
        transform.LookAt(center.transform);
        //Debug.Log(distance);

        if (distance <= 10 )
        {
            inside = true;

        }
        
        if (inside)
        {
            //ArcherCtrl.current.insideRobot.Add(gameObject);
            //Debug.Log("ROBOT İÇERİ GİRDİ");
        }
    }
}
