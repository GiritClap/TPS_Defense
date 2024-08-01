using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastWeapon : MonoBehaviour
{
    public bool isFiring = false;
    public ParticleSystem muzzleFlash;
    public ParticleSystem hitEffect;
    public Transform raycastOrigin;
    public Transform raycastDestination;
    Ray ray;
    RaycastHit hitInfo;

    public TrailRenderer tracerEffect;
    public void StartFire()
    {
        isFiring = true;
        muzzleFlash.Emit(1);

        ray.origin = raycastOrigin.position;
        ray.direction = raycastDestination.position - raycastOrigin.position;

        var tracer = Instantiate(tracerEffect, ray.origin, Quaternion.identity);
        tracer.AddPosition(ray.origin);

        if(Physics.Raycast(ray, out hitInfo))
        {
            //Debug.DrawLine(ray.origin, hitInfo.point, Color.red, 1f);
            hitEffect.transform.position = hitInfo.point;
            hitEffect.transform.forward = hitInfo.normal;
            hitEffect.Emit(1);

            tracer.transform.position = hitInfo.point;
        }
    }

    public void StopFire()
    {
        isFiring = false;
    }
}
