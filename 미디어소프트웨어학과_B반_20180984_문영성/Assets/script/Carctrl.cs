using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Carctrl : MonoBehaviour
{
    public int moveSpeed;
    public float move;
    
    void Start()
    {
        moveSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        move = moveSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * move);
    }
    // 도시에 부딪치면 패배 씬 불러오기
    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Town"){
            SceneManager.LoadScene("LoseScene");
        }
    }
}
