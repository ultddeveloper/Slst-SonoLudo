using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NoteGenerate : MonoBehaviour
{

    int temp = 0;
    public GameObject Tap, Hold;
    void Start()
    {
        generateTap();
    }

    // Update is called once per frame
    void Update()
    {
        temp += 1;
        if (temp > 60)
        {
            generateTap();
            temp = 0;
        }
    }

    void generateTap()
    {
        var tmp = Instantiate(Tap);
        tmp.transform.parent = this.transform;
        tmp.transform.position = new Vector3(this.transform.position.x, 625, -1);
        tmp.SetActive(true);
    }

    void generateHold(int length)
    {
        var tmp = Instantiate(Hold);
        tmp.transform.parent = this.transform;
        tmp.transform.position = new Vector3(this.transform.position.x, 625, -1);
        tmp.SetActive(true);
    }
}
