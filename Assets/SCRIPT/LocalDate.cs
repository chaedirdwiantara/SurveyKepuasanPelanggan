using System;
using UnityEngine;
using UnityEngine.UI;

public class LocalDate : MonoBehaviour {

    public Text localTimeText;
    public string day;
    public string month;
    public string year;
    // Use this for initialization
    void Start()
    {
        localTimeText = GetComponent<Text>();        
    }

    // Update is called once per frame
    void Update()
    {
        // Get current time
        DateTime time = DateTime.Now;

        // Extract hour / minutes / seconds
        day = LeadingZero(time.Day);
        month = LeadingZero(time.Month);
        year = LeadingZeroYear(time.Year);
        // Build string containing the time, and assign this to 'text' property of the Text component of our parent GameObject
        localTimeText.text = day + "/" + month + "/" + year;
    }

    /*given an integer, return a 2-character string adding a leading zero if required*/
    string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }

    string LeadingZeroYear(int n)
    {
        return n.ToString().PadLeft(4, '0');
    }
}
