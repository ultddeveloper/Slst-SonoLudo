using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalData : MonoBehaviour
{
    public int speed;
    public float enable, far, near, pure, late, miss;

    public int totalNotes;
    int notescore, fpbonus;
    int combo, score;
    int farCnt, nearCnt, pureCnt, lateCnt, missCnt;
    // Start is called before the first frame update
    void Start()
    {
        notescore = (int) (1000000 / totalNotes);
        fpbonus = 1000000 - notescore * totalNotes;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void noteDone(int type)
    {
        switch (type)
        {
            case 0: //miss
                combo = 0;
                missCnt++;
                break;
            case 1: //late
                lateCnt++;
                score += (int)(notescore * 0.6f);
                break;
            case 2: //pure
                pureCnt++;
                score += notescore;
                break;
            case 3: //near
                break;
            case 4: //far
                break;
        }

    }
}
