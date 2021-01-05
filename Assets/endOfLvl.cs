using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class endOfLvl : MonoBehaviour
{
    public void goToLvlOne()
    {
        //Debug.Log("HIT");
        SceneManager.LoadScene("First Person Shooter");
    }

    public void endApp()
    {
        //Debug.Log("HIT");
        Application.Quit();
    }
}
