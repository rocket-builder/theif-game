using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool SwipeLeft { get; set; }
    public bool SwipeRight { get; set; }
    public bool SwipeUp { get; set; }
    public bool SwipeDown { get; set; }
    public bool Tap { get; set; }
    public Vector2 SwipeDelta { get; set; }
    public Vector2 StartTouch { get; set; }

    void Update()
    {
        Tap = SwipeLeft = SwipeRight = SwipeDown = SwipeUp = false;

        #region Mobile Inputs
            
        if(Input.touches.Length > 0)
        {
            if(Input.touches[0].phase == TouchPhase.Began)
            {
                Tap = true;
                StartTouch = Input.touches[0].position;
            } 
            else if(Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                Reset();
            }
        }
        #endregion
    }

    private void Reset()
    {
        StartTouch = SwipeDelta = Vector2.zero;
    }   
}
