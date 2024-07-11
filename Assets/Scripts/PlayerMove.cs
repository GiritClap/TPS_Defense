using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rigid;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move =
             transform.forward * Input.GetAxis("Vertical") +
             transform.right * Input.GetAxis("Horizontal");

        // 이동량을 좌표에 반영
        transform.position += move * moveSpeed * Time.deltaTime;

    }
}
