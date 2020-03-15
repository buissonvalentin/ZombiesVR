using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float timeAlive;
    public float damageMultiplier;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeAlive);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
