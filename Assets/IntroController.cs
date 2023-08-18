using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroController : MonoBehaviour
{
    [SerializeField] GameObject intro;

    public void WaitingIntro()
    {
        Time.timeScale = 0f;
    }
    public void Continue()
    {
        Time.timeScale = 1.0f;
        intro.SetActive(false);
    }
}
