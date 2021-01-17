using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviousScene : MonoBehaviour {
    public string previous;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel(previous);
        }
    }
}
