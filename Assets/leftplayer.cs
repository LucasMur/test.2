using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftplayer : MonoBehaviour
{
    public string AxisName;
    public float thrust;
    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
           _rb.AddForce(Vector3.up * thrust * Input.GetAxis("AxisName"));
        
    }
}
