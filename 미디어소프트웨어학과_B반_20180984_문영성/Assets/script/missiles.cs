using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class missiles : MonoBehaviour
{
    public GameObject leftbomb;
    public GameObject missileprefab;
    private Transform left_missile;
    public int power =600;
    public float Destroy = 3.0f;
    // 총알에 사용 되는 음원
    public AudioClip fireSfx;

    // AudioSource 콤포넌트를 저장 할 변수
    private new AudioSource audio;
    
    void Start()
    {
        left_missile= GameObject.Find("left_missile").transform;
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(1)){
            GameObject missile1 = Instantiate(missileprefab, left_missile.position, left_missile.rotation) as GameObject;
            Rigidbody gun_force = missile1.GetComponent<Rigidbody>();
            gun_force.AddForce(leftbomb.transform.forward * power);
            Destroy(missile1,Destroy);
            audio.PlayOneShot(fireSfx, 1.0f);
        }
    }
}

