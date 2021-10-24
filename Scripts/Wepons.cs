using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wepons : MonoBehaviour
{
    	public Transform firePoint;
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
		Instantiate(bulletPrefab, firePoint.transform.position, firePoint.transform.rotation);
		
	}
	
}

    
