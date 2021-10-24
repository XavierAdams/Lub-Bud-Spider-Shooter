using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_EnemyBullot : MonoBehaviour
{
    	float moveSpeed = 5f;

		public int damage = 20;

	Rigidbody2D rb;
	public DamagePopUp dmpop;
	PlayerMovement target;
	Vector2 moveDirection;

	public PlayerHealth PH;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		target = GameObject.FindObjectOfType<PlayerMovement>();
		moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
		rb.velocity = new Vector2 (moveDirection.x, moveDirection.y);
		Destroy (gameObject, 3f);
	}

	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		PlayerHealth PH = hitInfo.GetComponent<PlayerHealth>();
		
		if (hitInfo.tag == "Player")
		{
			dmpop.HitPP(20);
           PH.TakeDamage(damage);
		}

		if (hitInfo.tag == "Enemy")
		{
		
		}
		
		if (hitInfo.tag == "OBS")
		{
		
		}
	
	}
	
	


}
