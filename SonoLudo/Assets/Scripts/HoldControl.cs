using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldControl : MonoBehaviour
{
    public GlobalData gd;
    int length;

    bool inexit;

    void Init(int len)
    {
        length = len;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -gd.speed, 0);
        if (this.transform.position.y < gd.location.w && !inexit)
        { //Miss

            gd.NoteDone(3);
            exit();
        }
    }


    public void tapped()
    {
        float y = this.transform.position.y;
        if (y < gd.location.z)
        { //Perfect
            Debug.Log("Perfect");
            gd.NoteDone(0);
            exit();
        }
        else if (y < gd.location.y)
        { //Good
            gd.NoteDone(1);
            exit();
        }
        else if (y < gd.location.x)
        { //Bad
            gd.NoteDone(2);
            exit();
        }


    }

    public void exit()
    {
        inexit = true;
        this.GetComponent<BoxCollider>().enabled = false;
        Destroy(gameObject);
    }
}
