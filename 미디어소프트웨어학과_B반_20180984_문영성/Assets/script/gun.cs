using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject gunbody;
    public GameObject gunprefab;
    private Transform gun_point;
    private Transform gun_point2;
    public int power =1500;
    public float Destroy = 2.0f;
    
    void Start()
    {
        gun_point= GameObject.Find("gun_point").transform;
        gun_point2= GameObject.Find("gun_point2").transform;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject gunIns = Instantiate(gunprefab, gun_point.position, gun_point.rotation) as GameObject;
            Rigidbody gun_add = gunIns.GetComponent<Rigidbody>();
            gun_add.AddForce(gunbody.transform.forward * power);
            Destroy(gunIns,Destroy);
        }
    if(Input.GetMouseButtonDown(0))
        {
            GameObject gunIns2 = Instantiate(gunprefab, gun_point2.position, gun_point2.rotation) as GameObject;
            Rigidbody gun_add = gunIns2.GetComponent<Rigidbody>();
            gun_add.AddForce(gunbody.transform.forward * power);
            Destroy(gunIns2,Destroy);
        }
    }
}

