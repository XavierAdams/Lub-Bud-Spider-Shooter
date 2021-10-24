using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxhealth = 100;

    public int curerentHealth;

    public HealthBar HB;

	public GameObject GMOVASCRN;
  

public void Start()
{
    curerentHealth = maxhealth;
    HB.SetMaxHealth(maxhealth);
	
}
    public void TakeDamage (int damage)
	{
       
	
		curerentHealth -= damage;

        HB.SetHealth(curerentHealth);    

		if (curerentHealth <= 0)
		{
			Die();
		}
		
	}

	public void Die ()
	{
		  GMOVASCRN.SetActive(true);
			Destroy(gameObject);
		Time.timeScale = 0.1f;
	}

}
