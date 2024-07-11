using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GumAim : MonoBehaviour
{
    public GameObject aim;
    public float rotSpeed = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 dir = aim.transform.position - transform.position;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), Time.fixedDeltaTime * rotSpeed);
    }
}
