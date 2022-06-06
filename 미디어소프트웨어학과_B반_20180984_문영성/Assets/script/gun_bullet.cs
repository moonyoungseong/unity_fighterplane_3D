using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun_bullet : MonoBehaviour
{
    public int power =1500;
    public float destroy = 3.0f;
    public GameObject g_exp;
    public GameObject bullet;
    
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * power);
    }

    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other) {
        GameObject copyG_exp = Instantiate(g_exp) as GameObject;
        copyG_exp.transform.position = transform.position;
        Destroy(bullet);
        Destroy(copyG_exp,destroy);
    }
}
