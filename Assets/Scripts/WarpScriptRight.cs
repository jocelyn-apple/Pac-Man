using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WarpScriptRight : MonoBehaviour
{
    public GameObject ChompMan;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            ChompMan.transform.position = new Vector3(-9.5f,0f,0.4f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
