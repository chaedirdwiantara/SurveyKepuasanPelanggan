using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SaveSystem : MonoBehaviour
{
    public static void SaveScore(ButtonHandler buttonHandler)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/survey.chaedir";
        //string path = "C:/coba/" + "/survey.chaedir";        
        FileStream stream = new FileStream(path, FileMode.Create);

        SurveyData data = new SurveyData(buttonHandler);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static void SaveScoreWeekly(ButtonHandler weekly)
    {
        DateTime time = DateTime.Now;
        //int second = time.Second;
        int day = time.Day;
        int month = time.Month;
        int year = time.Year;

        int week = 0;
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

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/survey" + week + month + year + ".chaedir";
        //string path = "C:/coba/" + "/survey" + week + month + year + ".chaedir";        
        FileStream stream = new FileStream(path, FileMode.Create);        

        SurveyDataWeekly data = new SurveyDataWeekly(weekly);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static void SaveScoreMonthly(ButtonHandler Monthly)
    {
        DateTime time = DateTime.Now;        
        int month = time.Month;
        int year = time.Year;        
        
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/survey" + month + year + ".chaedir";
        //string path = "C:/coba/" + "/survey" + month + year + ".chaedir";         
        FileStream stream = new FileStream(path, FileMode.Create);   

        SurveyDataMonthly data = new SurveyDataMonthly(Monthly);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static void SaveScoreYearly(ButtonHandler Yearly)
    {
        DateTime time = DateTime.Now;     
        int year = time.Year;

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/survey" + year + ".chaedir";
        //string path = "C:/coba/" + "/survey" + year + ".chaedir";        
        FileStream stream = new FileStream(path, FileMode.Create);

        SurveyDataYearly data = new SurveyDataYearly(Yearly);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static SurveyData LoadScore(ButtonHandler buttonHandler)
    {
        //string path = "C:/coba/" + "/survey.chaedir";
        string path = Application.persistentDataPath + "/survey.chaedir";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SurveyData data = formatter.Deserialize(stream) as SurveyData;
            stream.Close();

            return data;
        }
        else
        {
            //buttonHandler.warning.text = "Data tidak ditemukan";
            return null;
        }
    }    

    public static SurveyDataWeekly LoadScoreWeekly(LoadWeeklyData weeklyData)
    {
        //string path = "C:/coba/" + "/survey" + weeklyData.selectedWeek + weeklyData.selectedMonth + weeklyData.selectedYear + ".chaedir";
        string path = Application.persistentDataPath + "/survey" + weeklyData.selectedWeek + weeklyData.selectedMonth + weeklyData.selectedYear + ".chaedir";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SurveyDataWeekly dataWeekly = formatter.Deserialize(stream) as SurveyDataWeekly;
            stream.Close();

            weeklyData.announcement.text = "";

            return dataWeekly;
        }
        else
        {
            weeklyData.announcement.text = "Data tidak ditemukan";
            weeklyData.loadSP_ScoreWeekly.text = "";
            weeklyData.loadP_ScoreWeekly.text = "";
            weeklyData.loadTP_ScoreWeekly.text = "";
            return null;
        }
    }

    public static SurveyDataWeekly LoadScoreWeeklyNow(ButtonHandler weeklyDataNow)
    {
        DateTime time = DateTime.Now;
        //int second = time.Second;
        int day = time.Day;
        int month = time.Month;
        int year = time.Year;

        int week = 0;
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
        
        string path = Application.persistentDataPath + "/survey" + week + month + year + ".chaedir";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SurveyDataWeekly dataWeekly = formatter.Deserialize(stream) as SurveyDataWeekly;
            stream.Close();           

            return dataWeekly;
        }
        else
        {            
            return null;
        }
    }

    public static SurveyDataMonthly LoadScoreMonthly(LoadMonthlyData monthlyData)
    {
        //string path = "C:/coba/" + "/survey" + monthlyData.selectedMonth + monthlyData.selectedYear + ".chaedir";
        string path = Application.persistentDataPath + "/survey" + monthlyData.selectedMonth + monthlyData.selectedYear + ".chaedir";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SurveyDataMonthly DataMonthly = formatter.Deserialize(stream) as SurveyDataMonthly;
            stream.Close();

            monthlyData.announcement.text = "";

            return DataMonthly;
        }
        else
        {
            monthlyData.announcement.text = "Data tidak ditemukan";
            monthlyData.loadSP_ScoreMonthly.text = "";
            monthlyData.loadP_ScoreMonthly.text = "";
            monthlyData.loadTP_ScoreMonthly.text = "";
            return null;
        }
    }

    public static SurveyDataMonthly LoadScoreMonthlyNow(ButtonHandler monthlyDataNow)
    {
        DateTime time = DateTime.Now;
        //int second = time.Second;        
        int month = time.Month;
        int year = time.Year;        

        string path = Application.persistentDataPath + "/survey" + month + year + ".chaedir";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SurveyDataMonthly dataMonthly = formatter.Deserialize(stream) as SurveyDataMonthly;
            stream.Close();

            return dataMonthly;
        }
        else
        {
            return null;
        }
    }

    public static SurveyDataYearly LoadScoreYearly(LoadYearlyData yearlyData)
    {
        //string path = "C:/coba/" + "/survey" + yearlyData.selectedYear + ".chaedir";
        string path = Application.persistentDataPath + "/survey" + yearlyData.selectedYear + ".chaedir";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SurveyDataYearly DataYearly = formatter.Deserialize(stream) as SurveyDataYearly;
            stream.Close();

            yearlyData.announcement.text = "";

            return DataYearly;
        }
        else
        {
            yearlyData.announcement.text = "Data tidak ditemukan";
            yearlyData.loadSP_ScoreYearly.text = "";
            yearlyData.loadP_ScoreYearly.text = "";
            yearlyData.loadTP_ScoreYearly.text = "";
            return null;
        }
    }

    public static SurveyDataYearly LoadScoreYearlyNow(ButtonHandler yearlyDataNow)
    {
        DateTime time = DateTime.Now;
        //int second = time.Second;        
        int year = time.Year;
        
        string path = Application.persistentDataPath + "/survey" + year + ".chaedir";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SurveyDataYearly dataYearly = formatter.Deserialize(stream) as SurveyDataYearly;
            stream.Close();

            return dataYearly;
        }
        else
        {
            return null;
        }
    }
}
