using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadMonthlyData : MonoBehaviour {

    public Text announcement;    
    
    public int load_sp_scoreMonthly, load_p_scoreMonthly, load_tp_scoreMonthly;
    public Text loadSP_ScoreMonthly, loadP_ScoreMonthly, loadTP_ScoreMonthly;

    List<string> months = new List<string>() { "Pilih Bulan", "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
    List<string> years = new List<string>() { "Pilih Tahun", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035" };

    public Dropdown SelectMonth;
    public Dropdown SelectYear;

    public int selectedMonth;
    public int selectedYear;  
          
    public void Dropdown_MonthChanged(int index)
    {

        if (index == 0)
        {
            //SelectedMonth.color = Color.red;
            selectedMonth = 0;
        }
        else if (index == 1)
        {
            selectedMonth = 1;
        }
        else if (index == 2)
        {
            selectedMonth = 2;
        }
        else if (index == 3)
        {
            selectedMonth = 3;
        }
        else if (index == 4)
        {
            selectedMonth = 4;
        }
        else if (index == 5)
        {
            selectedMonth = 5;
        }
        else if (index == 6)
        {
            selectedMonth = 6;
        }
        else if (index == 7)
        {
            selectedMonth = 7;
        }
        else if (index == 8)
        {
            selectedMonth = 8;
        }
        else if (index == 9)
        {
            selectedMonth = 9;
        }
        else if (index == 10)
        {
            selectedMonth = 10;
        }
        else if (index == 11)
        {
            selectedMonth = 11;
        }
        else if (index == 12)
        {
            selectedMonth = 12;
        }
    }

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
        SelectMonth.AddOptions(months);
        SelectYear.AddOptions(years);
    }

    public void LoadScoreMonthly()
    {
        SurveyDataMonthly data = SaveSystem.LoadScoreMonthly(this);
        load_sp_scoreMonthly = data.sangatPuasMonthly;
        load_p_scoreMonthly = data.puasMonthly;
        load_tp_scoreMonthly = data.tidakPuasMonthly;

        loadSP_ScoreMonthly.text = "" + load_sp_scoreMonthly;
        loadP_ScoreMonthly.text = "" + load_p_scoreMonthly;
        loadTP_ScoreMonthly.text = "" + load_tp_scoreMonthly;
    }
}
