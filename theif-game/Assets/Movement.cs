using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float sensetive = 0.5f;

    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;

    void Update()
    {
        Swipe();
    }

    public void Swipe()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //save began touch 2d point
            firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
        if (Input.GetMouseButtonUp(0))
        {
            //save ended touch 2d point
            secondPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            //create vector from the two points
            currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

            //normalize the 2d vector
            currentSwipe.Normalize();

            //swipe upwards
            if (currentSwipe.y > 0 && currentSwipe.x > -sensetive && currentSwipe.x < sensetive)
            {
                Debug.Log("up swipe");
            }
            //swipe down
            if (currentSwipe.y < 0 && currentSwipe.x > -sensetive && currentSwipe.x < sensetive)
            {
                Debug.Log("down swipe");
            }
            //swipe left
            if (currentSwipe.x < 0 && currentSwipe.y > -sensetive && currentSwipe.y < sensetive)
            {
                Debug.Log("left swipe");
            }
            //swipe right
            if (currentSwipe.x > 0 && currentSwipe.y > -sensetive && currentSwipe.y < sensetive)
            {
                Debug.Log("right swipe");
            }
        }
    }
}
