using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SurveyDataMonthly {

    public int sangatPuasMonthly;
    public int puasMonthly;
    public int tidakPuasMonthly;

    public SurveyDataMonthly(ButtonHandler score)
    {
        sangatPuasMonthly = score.sp_scoreMonthly;
        puasMonthly = score.p_scoreMonthly;
        tidakPuasMonthly = score.tp_scoreMonthly;
    }
}
