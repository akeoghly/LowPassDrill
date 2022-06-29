using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

    public void PassDrillButton()
    {
        SceneManager.LoadScene("LowPass");
    }

    public void ExitGameButton()
    {
        Application.Quit();
    }
}
