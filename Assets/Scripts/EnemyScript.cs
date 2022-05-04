using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{

    NavMeshAgent pinkGhostAgent;

    public GameObject Chomp;

    void Awake()
    {
        pinkGhostAgent = this.gameObject.GetComponent<NavMeshAgent>();
        pinkGhostAgent.speed = 2.0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(0 < CORE.countDown && CORE.countDown < 10)
        {
            if(collision.gameObject.tag.Equals("Player"))
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            CORE.TimerOn = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        pinkGhostAgent.SetDestination(Chomp.transform.position);
    }
}
