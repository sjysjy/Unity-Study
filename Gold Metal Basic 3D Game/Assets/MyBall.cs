using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
    }

    void FixedUpdate()
    {
       /*  if (Input.GetButtonDown("Jump"))
         {
             rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
             Debug.Log(rigid.velocity);      //AddForce는 많이 누를수록 속도 velocity가 계속 증가
         }
       */
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }
}
