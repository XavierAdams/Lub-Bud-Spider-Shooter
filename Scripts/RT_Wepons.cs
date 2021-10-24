using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RT_Wepons : MonoBehaviour
{
     public GameObject bulot;

     

    public Transform FirePoint;
   void Update(){ 
    Vector3 mousePos = Input.mousePosition;
    Vector3 GunPos = Camera.main.WorldToScreenPoint(transform.position);
    mousePos.x = mousePos.x - GunPos.x;
    mousePos.y = mousePos.y - GunPos.y;

    float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

    if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x < transform.position.x)
    {
        transform.rotation = Quaternion.Euler(new Vector3(180f, 0f, -angle));
    }
    else
    {
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
    }

    	if (Input.GetButtonDown("Fire1")) //GetButton for Auto
		{
			Shoot();
		}
	}

	void Shoot ()
	{
	  Instantiate(bulot, FirePoint.transform.position, FirePoint.transform.rotation);
	}

}
