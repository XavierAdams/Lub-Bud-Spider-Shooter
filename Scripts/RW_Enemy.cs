using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RW_Enemy : MonoBehaviour
{
    int Movenum;
    public float MoveRate;
    float nextMove;
    public Rigidbody2D rb;
    public float speed;
    public float HitSpeed;
    public float atackSpeed;
    public int health = 110;

    public int damage = 100;

	public PlayerHealth PlayerH;

	Rigidbody2D rb2;

	PlayerMovement target;
	Vector2 moveDirection;
    public DamagePopUp dmpop;
	public PlayerHealth PH;
    	public AudioSource APPLE;


    void Start()
    {
        nextMove = Time.time;
    }

    void Update()
    {
        
        CheckIfTimeToFire();
    }
    
	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		PlayerHealth PlayerH = hitInfo.GetComponent<PlayerHealth>();
		
		if (hitInfo.tag == "Player")
		{
            dmpop.HitPP(20);
           Movenum = 8;
           PlayerH.TakeDamage(damage);
		}
    }

    void CheckIfTimeToFire()
    {
        
        if(Time.time > nextMove)
        {
            Movenum = Random.Range(1, 7);
            Debug.Log(Movenum);
            nextMove = Time.time + MoveRate;
        }
      
        if (Movenum == 1)
        {
            rb.velocity = transform.right * speed;
        }
        if (Movenum == 2)
        {
            rb.velocity = transform.right * -speed;
        }
        if (Movenum == 3)
        {
             rb.velocity = transform.up * speed;
        }
            
        if (Movenum == 4)
        {
            
             rb.velocity = transform.up * -speed;
           
        }
        if(Movenum == 5)
        {
            	rb2 = GetComponent<Rigidbody2D> ();
		target = GameObject.FindObjectOfType<PlayerMovement>();
		moveDirection = (target.transform.position - transform.position).normalized * atackSpeed;
		rb2.velocity = new Vector2 (moveDirection.x, moveDirection.y);
		
        }
         if(Movenum == 6)
        {
            	rb2 = GetComponent<Rigidbody2D> ();
		target = GameObject.FindObjectOfType<PlayerMovement>();
		moveDirection = (target.transform.position - transform.position).normalized * atackSpeed;
		rb2.velocity = new Vector2 (moveDirection.x, moveDirection.y);
		
        }
         if (Movenum == 8)
        {
            
             rb.velocity = transform.up * HitSpeed;
           
        }
    }
    public void TakeDamage (int damage)
	{
        APPLE.Play();
         dmpop.DamagePP(99);

		health -= damage;

		if (health <= 0)
		{
			Die();
		}
		
	}
    void Die ()
	{
			Destroy(gameObject);
    }
}

