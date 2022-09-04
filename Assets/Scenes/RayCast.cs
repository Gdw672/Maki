using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    Anim anim;
    private void Start()
    {
        anim = GetComponent<Anim>();
    }
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                anim.scared();
            }

            if(touch.phase == TouchPhase.Ended)
            {
                anim.sit();
            }
            
        }
          
        
    }
}
