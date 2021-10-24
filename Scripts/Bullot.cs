using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullot : MonoBehaviour
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
	
		Enemy enemy = hitInfo.GetComponent<Enemy>();
		RW_Enemy enemyRT = hitInfo.GetComponent<RW_Enemy>();
		if (enemy != null)
		{
		
			enemy.TakeDamage(damage);
		}
		if (enemyRT != null)
		{
		
			enemyRT.TakeDamage(damage);
		}
	
		if (hitInfo.tag == "Player")
		{

		}

		
		if (hitInfo.tag == "Enemy")
		{
		Destroy(gameObject);
		}
		
		if (hitInfo.tag == "OBS")
		{
		Destroy(gameObject);
		}
			

			
		
		
		

		

		
	}
	
}

