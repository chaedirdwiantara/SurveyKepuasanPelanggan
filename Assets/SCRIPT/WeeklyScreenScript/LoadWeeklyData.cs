using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadWeeklyData : MonoBehaviour {

    public Text announcement;    
        
    public int load_sp_scoreWeekly, load_p_scoreWeekly, load_tp_scoreWeekly;
    public Text loadSP_ScoreWeekly, loadP_ScoreWeekly, loadTP_ScoreWeekly;

    List<string> weeks = new List<string>() { "Pilih Pekan", "Pekan ke 1", "Pekan ke 2", "Pekan ke 3", "Pekan ke 4"};
    List<string> months = new List<string>() { "Pilih Bulan", "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
    List<string> years = new List<string>() { "Pilih Tahun", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035"};

    public Dropdown SelectWeek;
    public Dropdown SelectMonth;
    public Dropdown SelectYear;
    
    public int selectedWeek;    
    public int selectedMonth;    
    public int selectedYear;    

    public void Dropdown_WeekChanged(int index)
    {
        
        if (index == 0)
        {
            //SelectedMonth.color = Color.red;
            selectedWeek = 0;
        }
        else if (index == 1)
        {
            selectedWeek = 1;
        }
        else if (index == 2)
        {
            selectedWeek = 2;
        }
        else if (index == 3)
        {
            selectedWeek = 3;
        }
        else if (index == 4)
        {
            selectedWeek = 4;
        }
    }

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
        SelectWeek.AddOptions(weeks);
        SelectMonth.AddOptions(months);
        SelectYear.AddOptions(years);
    }

    public void LoadScoreWeekly()
    {
        SurveyDataWeekly data = SaveSystem.LoadScoreWeekly(this);
        load_sp_scoreWeekly = data.sangatPuasWeekly;
        load_p_scoreWeekly = data.puasWeekly;
        load_tp_scoreWeekly = data.tidakPuasWeekly;

        loadSP_ScoreWeekly.text = "" + load_sp_scoreWeekly;
        loadP_ScoreWeekly.text = "" + load_p_scoreWeekly;
        loadTP_ScoreWeekly.text = "" + load_tp_scoreWeekly;
    }
}
