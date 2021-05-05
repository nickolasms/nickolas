using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{
    public int HP = 100;

    public void TakeDamage(int damage)
    {
            HP -= damage;
            Debug.Log(HP+ " vida");
    }

    void Update()
    {
        
        if(HP <= 0)
        {
            HP = 0;
        }
        
        if(HP == 0)
        {
            Destroy(gameObject);
        }
    
    }   
}
