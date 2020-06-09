using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;

    private bool startNow = false;
    private float timer;
    private bool canCount = true;
    private bool doOnce = false;
    [Space]
    [Header("Transition Items")]
    public GameObject blackOut;
    public GameObject timerText;
    public GameObject trackerText;
    public GameObject rules;
    public GameObject ghostOn;
    public GameObject startText;
    public GameObject tracker;

    void Start()
    {
        timer = mainTimer;
    }

    void Update()
    {
        if (startNow == true)
        {
            TimerStart();
        }        
    }

    void TimerStart()
    {
        if (timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            uiText.text = timer.ToString("F");
        }

        else if (timer < -0.0f && doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0.00";
            timer = 0.0f;
        }

        if (timer <= 0.0f)
        {
            blackOut.SetActive(false);
            timerText.SetActive(false);
            rules.SetActive(true);
        }
    }

    void StartNowTrue()
    {
        startNow = true;
    }

    void TurnOffTransition()
    {
        startNow = false;
        blackOut.SetActive(true);
        ghostOn.SetActive(true);
        trackerText.SetActive(true);
        startText.SetActive(false);
        tracker.SetActive(true);
    }
}
