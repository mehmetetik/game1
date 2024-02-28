using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    public float speed = 5;
    public float life = 4;
    void Start()
    {

    }

    void Update()
    {
        life -= Time.deltaTime;
        if (life <= 0)
        {
            Destroy(this.gameObject);
        }
        
        transform.position = 
            Vector3.MoveTowards(transform.position, 
                ArcherCtrl.current.insideRobot[0].transform.position,
                speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "robot")
        {
            Destroy(collision.gameObject); 
            RemoveLast();
            Debug.Log("robot mermi tarafından yok edildi");
            Destroy(this.gameObject);
            Debug.Log("mermi yok edildi");
        }
    }
    
    
    public void RemoveLast()
    {
        if(ArcherCtrl.current.insideRobot.Count > 0)
        {
            Destroy(ArcherCtrl.current.insideRobot[ArcherCtrl.current.insideRobot.Count -1]);
            ArcherCtrl.current.insideRobot.RemoveAt(ArcherCtrl.current.insideRobot.Count -1);
        }
    }
    
}
