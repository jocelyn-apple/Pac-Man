using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CORE : MonoBehaviour
{
    public static int score = 0;
    public static float countDown = 10;
    public static bool TimerOn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TimerOn == true)
        {
            countDown -= Time.deltaTime;
            if(countDown >= 0)
            {
                countDown -= Time.deltaTime;
            }
            else
            {
                countDown = 10;
                TimerOn = false;
            }
        }
        else
        {
            countDown = 10;
            TimerOn = false;
        }
    }
}
