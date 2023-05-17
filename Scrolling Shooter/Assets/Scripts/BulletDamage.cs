using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter2D(Collider2D hit)
    {
        
       Health health = hit.GetComponent<Health>();
        if(health != null)
        {
            health.TakeDamage(damage);
        }
        
        
    }

}
