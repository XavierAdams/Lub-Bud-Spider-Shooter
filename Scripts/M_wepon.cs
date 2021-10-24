using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_wepon : MonoBehaviour
{
 	public Transform firePoint3;
    public Transform firePoint2;
    public Transform firePoint1;
	public GameObject bulletPrefab;
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetButtonDown("Fire1")) //GetButton for Auto
		{
			Shoot();
		}
		
	}

	void Shoot ()
	{
		Instantiate(bulletPrefab, firePoint1.transform.position, firePoint1.transform.rotation);
        Instantiate(bulletPrefab, firePoint2.transform.position, firePoint2.transform.rotation);
        Instantiate(bulletPrefab, firePoint3.transform.position, firePoint3.transform.rotation);
		
	}
}

