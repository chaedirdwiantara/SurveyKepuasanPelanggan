using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadYearlyData : MonoBehaviour {

    public Text announcement;

    public int load_sp_scoreYearly, load_p_scoreYearly, load_tp_scoreYearly;
    public Text loadSP_ScoreYearly, loadP_ScoreYearly, loadTP_ScoreYearly;
    
    List<string> years = new List<string>() { "Pilih Tahun", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035" };
       
    public Dropdown SelectYear;
    public int selectedYear;    

    public void Dropdown_YearChanged(int index)
    {
        //SelectedYear.text = years[index];
        if (index == 0)
        {
            //SelectedMonth.color = Color.red;
            selectedYear = 0;
        }
        else if (index == 1)
        {
            selectedYear = 2019;
        }
        else if (index == 2)
        {
            selectedYear = 2020;
        }
        else if (index == 3)
        {
            selectedYear = 2021;
        }
        else if (index == 4)
        {
            selectedYear = 2022;
        }
        else if (index == 5)
        {
            selectedYear = 2023;
        }
        else if (index == 6)
        {
            selectedYear = 2024;
        }
        else if (index == 7)
        {
            selectedYear = 2025;
        }
        else if (index == 8)
        {
            selectedYear = 2026;
        }
        else if (index == 9)
        {
            selectedYear = 2027;
        }
        else if (index == 10)
        {
            selectedYear = 2028;
        }
        else if (index == 11)
        {
            selectedYear = 2029;
        }
        else if (index == 12)
        {
            selectedYear = 2030;
        }
        else if (index == 13)
        {
            selectedYear = 2031;
        }
        else if (index == 14)
        {
            selectedYear = 2032;
        }
        else if (index == 15)
        {
            selectedYear = 2033;
        }
        else if (index == 16)
        {
            selectedYear = 2034;
        }
        else if (index == 17)
        {
            selectedYear = 2035;
        }
    }

    void Start()
    {
        Datelists();
    }

    void Datelists()
    {        
        SelectYear.AddOptions(years);
    }

    public void LoadScoreYearly()
    {
        SurveyDataYearly data = SaveSystem.LoadScoreYearly(this);
        load_sp_scoreYearly = data.sangatPuasYearly;
        load_p_scoreYearly = data.puasYearly;
        load_tp_scoreYearly = data.tidakPuasYearly;

        loadSP_ScoreYearly.text = "" + load_sp_scoreYearly;
        loadP_ScoreYearly.text = "" + load_p_scoreYearly;
        loadTP_ScoreYearly.text = "" + load_tp_scoreYearly;
    }
}

