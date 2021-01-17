using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SurveyDataYearly {

    public int sangatPuasYearly;
    public int puasYearly;
    public int tidakPuasYearly;

    public SurveyDataYearly(ButtonHandler score)
    {
        sangatPuasYearly = score.sp_scoreYearly;
        puasYearly = score.p_scoreYearly;
        tidakPuasYearly = score.tp_scoreYearly;
    }
}
