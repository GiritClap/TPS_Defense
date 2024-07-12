using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastWeapon : MonoBehaviour
{
    public bool isFiring = false;
    public ParticleSystem muzzleFlash;
    public void StartFire()
    {
        isFiring = true;
        muzzleFlash.Emit(1);
    }

    public void StopFire()
    {
        isFiring = false;
    }
}
