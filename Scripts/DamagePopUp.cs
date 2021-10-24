using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamagePopUp : MonoBehaviour
{
    public GameObject pfDamageText;
    public TextMeshPro Text;
   
    // Start is called before the first frame update
    public void Start()
    {
       
    }
    public void DamagePP(int damage)
    {
        Text.SetText("+"+damage);
         GameObject Def = Instantiate(pfDamageText, transform.position, Quaternion.identity);
         Destroy(Def, 1f);
    }
     public void HitPP(int damage)
    {
        Text.SetText("-"+damage);
         GameObject Def = Instantiate(pfDamageText, transform.position, Quaternion.identity);
         Destroy(Def, 1f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
