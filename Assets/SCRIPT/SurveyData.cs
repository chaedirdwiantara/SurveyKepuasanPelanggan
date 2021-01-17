using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SurveyData {

    public int sangatPuas;
    public int puas;
    public int tidakPuas;

    public SurveyData (ButtonHandler score)
    {
        sangatPuas = score.sp_score;
        puas = score.p_score;
        tidakPuas = score.tp_score;
    }

}
