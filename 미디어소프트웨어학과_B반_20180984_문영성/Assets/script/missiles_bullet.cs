using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class missiles_bullet : MonoBehaviour
{
    public int power =1500;
    public float destroy = 3.0f;
    public GameObject M_exp;
    public GameObject missiles;
    public int attack = 10;
    
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * power);
    }

    void OnCollisionEnter(Collision other) {
        GameObject copyM_exp = Instantiate(M_exp) as GameObject;
        copyM_exp.transform.position = transform.position;
        if(other.gameObject.tag == "Boss"){
            Score.HP-= attack;
            if(Score.HP == 0){
                SceneManager.LoadScene("WinScene");
            }
        }
        Destroy(missiles);
        Destroy(copyM_exp, destroy);
    }
}
