using System;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    private float _timeStart = 30;
    private bool _timerRuning = true;

    private void OnEnable()
    {
        _timerRuning = true;
        timerText.text = _timeStart.ToString();
        Update();
    }

    private void OnDisable()
    {
        _timeStart = 30;
    }


    void Update()
    {
        if (_timerRuning == true)
        {
            _timeStart -= Time.deltaTime;
            timerText.text = Mathf.Round(_timeStart).ToString();

            if (_timeStart <= 0)
            {
                _timeStart = 0;
                _timerRuning = false;
                GameManager.WhoWon.Invoke();
            }
        }
    }
}