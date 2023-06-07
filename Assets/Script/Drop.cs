using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    MeshRenderer ren;
    Rigidbody rb;
   [SerializeField] float timeToWait = 5f;
    void Start()
    {
        ren = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        ren.enabled = false;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait )
        {
          ren.enabled = true;
          rb.useGravity = true; 
        }
    }
}
