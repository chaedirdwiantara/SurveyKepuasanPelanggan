using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanel : MonoBehaviour {

    public GameObject SP_Panel;
    public GameObject P_Panel;
    public GameObject TP_Panel;

    IEnumerator SP_Panel_Counter()
    {
        yield return new WaitForSeconds(3);
        SP_Panel.SetActive(false);
    }

    IEnumerator P_Panel_Counter()
    {
        yield return new WaitForSeconds(3);
        P_Panel.SetActive(false);
    }

    IEnumerator TP_Panel_Counter()
    {
        yield return new WaitForSeconds(3);
        TP_Panel.SetActive(false);
    }

    public void ActivateSP_Panel()
    {
        if (SP_Panel != null)
        {
            //bool isActive = SP_Panel.activeSelf;
            //SP_Panel.SetActive(!isActive);
            SP_Panel.SetActive(true);
            StartCoroutine(SP_Panel_Counter());
        }
    }

    public void ActivateP_Panel()
    {
        if (P_Panel != null)
        {
            //bool isActive = SP_Panel.activeSelf;
            //SP_Panel.SetActive(!isActive);
            P_Panel.SetActive(true);
            StartCoroutine(P_Panel_Counter());
        }
    }

    public void ActivateTP_Panel()
    {
        if (TP_Panel != null)
        {
            //bool isActive = SP_Panel.activeSelf;
            //SP_Panel.SetActive(!isActive);
            TP_Panel.SetActive(true);
            StartCoroutine(TP_Panel_Counter());
        }
    }
}
