using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CC controller;
    public Animator animator;
    public float Speed;
    public float horsontialMove = 0f;
    public bool jump = false;
    public int CoinSR;
    public PlayerHealth PH;

    void Start()
    {
    
     CoinSR = PlayerPrefs.GetInt("COIN", CoinSR);
       

    }

    // Update is called once per frame
    void Update()
    {
        horsontialMove = Input.GetAxisRaw("Horizontal") * Speed;

        animator.SetFloat("Speed", Mathf.Abs(horsontialMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("PLAYERIsJumping", true);
        }
    }
   public void Onlanding()
    {
            animator.SetBool("PLAYERIsJumping", false);
    }
    void FixedUpdate()
    {
        controller.Move(horsontialMove * Time.fixedDeltaTime, false, jump);

        jump = false;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
     
        if (collision.tag == "Coin")
        {

         
            CoinSR++;
            PlayerPrefs.SetInt("COIN", CoinSR);
         Destroy(collision.gameObject);
           
          // Debug.Log("On For Every Coin");
           
           
        }
        
        if (collision.tag == "Flage")
        {
            SceneManager.LoadScene("End");
        }
        if (collision.tag == "VOID")
        {
           PH.Die();
        }



    }
  
}
    
    


