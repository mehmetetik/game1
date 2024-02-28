using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCtrl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "robot")
        {
            Debug.Log("robot içerde");
            ArcherCtrl.current.insideRobot.Add(other.gameObject);
            ArcherCtrl.current.CreateBullet();
            //ArcherCtrl.current.insideRobot.Remove(ArcherCtrl.current.insideRobot[0]);
        }
    }
    
}
