using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAiming : MonoBehaviour
{
    public float turnSpeed = 15.0f;
    Camera mainCamera;
    public CinemachineCameraOffset camOffset;
    Vector3 originalCamOffset;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        originalCamOffset = camOffset.m_Offset;
    }

    private void Update()
    {
        if(Input.GetMouseButton(1))
        {
            camOffset.m_Offset = new Vector3(2.03f, 0, 15.0f);
        } 
        else
        {
            camOffset.m_Offset = originalCamOffset;
        }


    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float yawCamera = mainCamera.transform.eulerAngles.y;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yawCamera, 0), turnSpeed * Time.fixedDeltaTime );
    }
}
