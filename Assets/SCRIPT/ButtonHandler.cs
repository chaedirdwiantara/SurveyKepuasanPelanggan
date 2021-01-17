using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{    
    public int sp_score, p_score, tp_score;
    public Text sp_Score, p_Score, tp_Score;    

    public int sp_scoreWeekly, sp_scoreMonthly, sp_scoreYearly, p_scoreWeekly, p_scoreMonthly, p_scoreYearly, tp_scoreWeekly, tp_scoreMonthly, tp_scoreYearly;
        
    int day;
    int month;
    int year;
    public int week = 0;    
    public int weekTrigger = 0;
    public int monthTrigger = 0;
    public int yearTrigger = 0;    

    void Start()
    {        
        LoadScore();        
    }

    public void LoadScore()
    {
        SurveyData data = SaveSystem.LoadScore(this);
        sp_score = data.sangatPuas;
        p_score = data.puas;
        tp_score = data.tidakPuas;

        sp_Score.text = "" + sp_score;
        p_Score.text = "" + p_score;
        tp_Score.text = "" + tp_score;
    }

    public void LoadScoreWeeklyNow()
    {
        SurveyDataWeekly data = SaveSystem.LoadScoreWeeklyNow(this);
        sp_scoreWeekly = data.sangatPuasWeekly;
        p_scoreWeekly = data.puasWeekly;
        tp_scoreWeekly = data.tidakPuasWeekly;
    }

    public void LoadScoreMonthlyNow()
    {
        SurveyDataMonthly data = SaveSystem.LoadScoreMonthlyNow(this);
        sp_scoreMonthly = data.sangatPuasMonthly;
        p_scoreMonthly = data.puasMonthly;
        tp_scoreMonthly = data.tidakPuasMonthly;
    }

    public void LoadScoreYearlyNow()
    {
        SurveyDataYearly data = SaveSystem.LoadScoreYearlyNow(this);
        sp_scoreYearly = data.sangatPuasYearly;
        p_scoreYearly = data.puasYearly;
        tp_scoreYearly = data.tidakPuasYearly;
    }

    public void SangatPuas()
    {             
        sp_score++;
        sp_scoreWeekly++;
        sp_scoreMonthly++;
        sp_scoreYearly++;
        sp_Score.text = "" + sp_score;        
    }    

    public void Puas()
    {        
        p_score++;
        p_scoreWeekly++;
        p_scoreMonthly++;
        p_scoreYearly++;
        p_Score.text = "" + p_score;
    }
    
    public void TidakPuas()
    {
        tp_score++;
        tp_scoreWeekly++;
        tp_scoreMonthly++;
        tp_scoreYearly++;
        tp_Score.text = "" + tp_score;
    }
    
    public void SaveScore()
    {
        SaveSystem.SaveScore(this);
        SaveSystem.SaveScoreWeekly(this);
        SaveSystem.SaveScoreMonthly(this);
        SaveSystem.SaveScoreYearly(this);
    }   

    void Update()
    {
        DateTime time = DateTime.Now;
        //int second = time.Second;
        day = time.Day;
        month = time.Month;
        year = time.Year;

        if (day >= 1 && day <= 7)
        {
            week = 1; 
        }
        else if (day > 7 && day <= 14)
        {
            week = 2;
        }
        else if (day > 14 && day <= 21)
        {
            week = 3;
        }
        else
        {
            week = 4;
        }
        
        if (weekTrigger != week)
        {
            sp_scoreWeekly = 0;
            p_scoreWeekly = 0;
            tp_scoreWeekly = 0;            
            weekTrigger = week;
            LoadScoreWeeklyNow();
        }

        if (monthTrigger != month)
        {
            sp_scoreMonthly = 0;
            p_scoreMonthly = 0;
            tp_scoreMonthly = 0;            
            monthTrigger = month;
            LoadScoreMonthlyNow();
        }

        if (yearTrigger != year)
        {
            sp_scoreYearly = 0;
            p_scoreYearly = 0;
            tp_scoreYearly = 0;            
            yearTrigger = year;
            LoadScoreYearlyNow();
        }
    }    
}