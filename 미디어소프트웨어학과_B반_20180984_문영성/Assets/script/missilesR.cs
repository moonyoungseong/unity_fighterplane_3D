using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missilesR : MonoBehaviour
{
    public GameObject missile;
    public GameObject missileprefab;
    private Transform right_missile;
    public int power = 600;
    public float Destroy = 2.0f;

    void Start()
    {
        right_missile= GameObject.Find("right_missile").transform;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            GameObject missile1 = Instantiate(missileprefab, right_missile.position, right_missile.rotation) as GameObject;
            Rigidbody gun_force = missile1.GetComponent<Rigidbody>();
            gun_force.AddForce(missile.transform.forward * power);
            Destroy(missile1,Destroy);
        }
    }
}

