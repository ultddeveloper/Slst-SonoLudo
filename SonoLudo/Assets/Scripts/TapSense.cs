using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapSense : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit = new RaycastHit();
    private Vector3 mousepos;
    private Vector3 cameramousepos;
    public Camera g_camera;
    

    void Update()
    {
        mousepos = Input.mousePosition;
        cameramousepos = g_camera.ScreenToWorldPoint(new Vector3(mousepos.x, mousepos.y, -100));
        if (Input.GetButtonUp("Fire1"))
        {
            ray = new Ray(cameramousepos, Vector3.forward);
            if (Physics.Raycast(ray.origin, ray.direction, out hit, 4000))
            {
                if (hit.collider.gameObject.tag == "Tap")
                {
                    hit.collider.gameObject.GetComponent<TapControl>().tapped();
                }
            }
        }
    }

}
