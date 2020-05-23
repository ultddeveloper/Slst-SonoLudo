using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class TapControl : MonoBehaviour
{
    public GlobalData gd;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -gd.speed / 600.0f);
        if (transform.position.z < gd.enable && !GetComponent<BoxCollider>().enabled)
        {
            GetComponent<BoxCollider>().enabled = true;   
        }
    }

    public void tapped()
    {
        float onpos = transform.position.z;
        if (onpos < gd.miss)
        {

        } 
        else if (onpos < gd.late)
        {

        }
        else if (onpos < gd.pure)
        {

        }
        else if (onpos < gd.near)
        {

        }
        else if (onpos < gd.far)
        {

        }
    }
}

