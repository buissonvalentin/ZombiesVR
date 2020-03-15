using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    public Transform player;
    public Animator animator;

    NavMeshAgent agent;
    Animator m_animator;
    public float maxLife;
    float currentLife;
    // Start is called before the first frame update
    void Start()
    {
        currentLife = maxLife;
        agent = (gameObject.GetComponentInParent(typeof(NavMeshAgent)) as NavMeshAgent);
        m_animator = (gameObject.GetComponentInParent(typeof(Animator)) as Animator);

        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);
        m_animator.SetFloat("MoveSpeed", 1.0f);
    }

    public void TakeDamage(float damage)
    {
        currentLife -= damage;
        if (currentLife <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        animator.SetTrigger("Dead");
    }
}
