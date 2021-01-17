using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SurveyDataWeekly {

    public int sangatPuasWeekly;
    public int puasWeekly;
    public int tidakPuasWeekly;

    public SurveyDataWeekly(ButtonHandler score)
    {
        sangatPuasWeekly = score.sp_scoreWeekly;
        puasWeekly = score.p_scoreWeekly;
        tidakPuasWeekly = score.tp_scoreWeekly;
    }
}
