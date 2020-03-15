using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEnter : MonoBehaviour
{
    public int damageReceived;
    private Zombie zombie;
    // Start is called before the first frame update
    void Start()
    {
        zombie = gameObject.GetComponentInParent(typeof(Zombie)) as Zombie;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            Debug.LogError("hit");
            Bullet bullet = other.GetComponent<Bullet>();
            zombie.TakeDamage(damageReceived * bullet.damageMultiplier);
        }
    }
}
