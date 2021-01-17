using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour {

    public GameObject Panel;

    /*IEnumerator HitungMundur()
    {
        yield return new WaitForSeconds(5);
        Panel.SetActive(false);
    }*/

    public void ActivateButton()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
            //Panel.SetActive(true);
            //StartCoroutine(HitungMundur());
        }        
    }

    public void doquit()
    {
        Debug.Log("Has Quit The Application");
        Application.Quit();
    }    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {            
            ActivateButton();
        }
    }
}
