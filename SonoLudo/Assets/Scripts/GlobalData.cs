using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalData : MonoBehaviour
{
    public int speed;

    public int score, combo, totalNotes;
    public GameObject scoreShow, comboShow;

    int indivscore;

    public Vector4 location; //= new Vector4(-100, -300, -350, -500);

    void Start()
    {
        score = 0;
        combo = 0;

        indivscore = (int) 1000000 / totalNotes;
    }

    public void NoteDone(int status)
    {
        if (status == 0)
        {
            Debug.Log("Combo!");
            score += indivscore;
            combo += 1;
            Debug.Log(combo);
        }
        else if (status == 1)
        {
            score += (int)(indivscore * 0.6f);
            combo += 1;
        }
        else if (status == 2)
        {
            score += (int)(indivscore * 0.4f);
            Debug.Log("Stat 2");
            combo = 0;
        }
        else if (status == 3)
        {
            Debug.Log("Miss");
            combo = 0;
        }
    }

    private void Update()
    {
        string showScore = "";
        for (int i = 0; i < 7 - score.ToString().Length; i++)
        {
            showScore += "0";
        }
        showScore += score.ToString();
        scoreShow.GetComponent<Text>().text = showScore;
        if (combo > 2)
        {
            comboShow.GetComponent<Text>().text = combo.ToString();
        }
        else
        {
            comboShow.GetComponent<Text>().text = "";
        }

    }
}
