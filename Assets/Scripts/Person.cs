using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public float maxLife;
    float currentLife;
    // Start is called before the first frame update
    void Start()
    {
        currentLife = maxLife;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        currentLife -= damage;
        if(currentLife <= 0)
        {
            Die();
        }
        
    }

    void Die()
    {

    }
}
