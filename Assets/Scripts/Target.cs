using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{
    public NavMeshAgent agent;
    public Animator m_animator;
    // Start is called before the first frame update
    void Start()
    {
        agent.SetDestination(this.gameObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        m_animator.SetFloat("MoveSpeed", 2.0f);
    }
}
