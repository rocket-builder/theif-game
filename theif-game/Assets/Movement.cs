using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Vector2 fp; // first finger position
    private Vector2 lp; // last finger position

    void FixedUpdate()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                fp = touch.position;
                lp = touch.position;
            }
            if (touch.phase == TouchPhase.Moved)
            {
                lp = touch.position;
            }
            if (touch.phase == TouchPhase.Ended)
            {
                if ((fp.x - lp.x) > 80) // left swipe
                {
                    Debug.Log("left swipe here...");
                }
                else if ((fp.x - lp.x) < -80) // right swipe
                {
                    Debug.Log("right swipe here...");
                }
                else if ((fp.y - lp.y) < -80) // up swipe
                {
                    Debug.Log("up swipe here...");
                }
                else if ((fp.y - lp.y) > 80) // down swipe
                {
                    Debug.Log("down swipe here...");
                }
            }
        }
    }
}
