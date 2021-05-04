using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;
    Transform target;
    NavMeshAgent agent;
    Animator a;
    public ThirdPersonCharacter character;
    public GameObject gameObject;

    void Start()
    {
        
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        a = GetComponent<Animator>();

    }

    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);


        if (distance <= lookRadius)
        {
            a.SetBool("isWalking", true);
            agent.SetDestination(target.position);
            gameObject.transform.position = target.position;
        }
        else
        {
            a.SetBool("isWalking", false);
        }

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);

    }
}
