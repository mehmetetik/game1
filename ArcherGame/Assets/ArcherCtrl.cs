using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ArcherCtrl : MonoBehaviour
{
    public static ArcherCtrl current;

    public List<GameObject> insideRobot;

    public GameObject bullet;
    public Transform bulletSpawnPos;

    public Transform currentTarget;
    public GameObject watcher;

    void Start()
    {
        current = this;
    }

    void Update()
    {
        transform.LookAt(watcher.transform.position);

        if (insideRobot.Count > 0)
        {
            transform.LookAt(insideRobot[0].transform.position);
        }
    }

    public void CreateBullet()
    {
        if (insideRobot.Count > 0)
        {
            currentTarget = insideRobot[0].transform;
            Instantiate(bullet, bulletSpawnPos.position,Quaternion.identity);
        }
    }
}
