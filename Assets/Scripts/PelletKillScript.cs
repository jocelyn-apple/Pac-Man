using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletKillScript : MonoBehaviour
{
    //public float countDown = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            CORE.score++;
            CORE.TimerOn = true;
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
