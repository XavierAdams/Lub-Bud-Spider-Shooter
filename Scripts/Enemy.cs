using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 110;

	public GameObject deathEffect;

	public GameObject Coin;
	public DamagePopUp DamPP;

	int COINnum;

	public AudioSource APPLE;
	
	public GameObject threew;
	public GameObject tow;
	public GameObject onw;
	

	public void Update()
	{
	
	} 

	public void TakeDamage (int damage)
	{
		APPLE.Play();
		DamPP.DamagePP(damage);

	
		health -= damage;

		if (health <= 0)
		{
			Die();
		}
		
	}

	void Die ()
	{
			Destroy(gameObject);
		COINnum = Random.Range(1, 4);
		Debug.Log(COINnum);
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		
		EnemyDrops();
	}

	public void EnemyDrops()
	{
		//Instantiate(Coin, transform.position, Quaternion.identity);
		
		if (COINnum == 1)
		{
			Instantiate(Coin, onw.transform.position, Quaternion.identity);
		
		
		}

		if (COINnum == 2)
		{
			Instantiate(Coin, onw.transform.position, Quaternion.identity);
			Instantiate(Coin, tow.transform.position, Quaternion.identity);
		
		}

		if (COINnum == 3)
		{
			
			Instantiate(Coin, onw.transform.position, Quaternion.identity);
			Instantiate(Coin, tow.transform.position, Quaternion.identity);
			Instantiate(Coin, threew.transform.position, Quaternion.identity);
		
		
		}

		
		

		
	}

}
