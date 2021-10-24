using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullot : MonoBehaviour
{


    public float speed = -20f;
	public int damage = 10;
	
	public Rigidbody2D rb;
	
	

	// Use this for initialization
	void Start () {
		rb.velocity = transform.right * speed;

		
	}
	 void OnBecameInvisible()
    {
        enabled = false;
        Destroy(gameObject);
    }


	void OnTriggerEnter2D (Collider2D hitInfo)
	{
	
		if (hitInfo.tag == "Player")
		{
           Destroy(hitInfo.gameObject);
		}

		if (hitInfo.tag == "Enemy")
		{
		
		}
		
		if (hitInfo.tag == "OBS")
		{
		
		}
	
	}
    
}


