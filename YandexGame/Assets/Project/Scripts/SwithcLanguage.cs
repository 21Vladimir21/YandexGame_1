using System.Collections;
using System.Collections.Generic;
using Agava.YandexGames;
using TMPro;
using UnityEngine;

public class SwithcLanguage : MonoBehaviour
{
    [SerializeField] private TMP_Text gameName;
    [SerializeField] private TMP_Text toilenWinText;
    [SerializeField] private TMP_Text grimaseWinText;
    [SerializeField] private TMP_Text drawText;

    void Start()
    {
#if UNITY_EDITOR
        string lang = "ru";
#endif
#if !UNITY_EDITOR
             string lang = YandexGamesSdk.Environment.i18n.lang;
#endif
        if (lang == "ru")
        {
            gameName.text = "Скулбой против мамы!";
            toilenWinText.text = "Домашки не будет!";
            grimaseWinText.text = "Быстро делать домашку!";
            drawText.text = "Ничья!";
        }

        if (lang == "en")
        {
            gameName.text = "Schoolboy vs Mom!";
            toilenWinText.text = "There will be no homework!";
            grimaseWinText.text = "Do your homework quickly!";
            drawText.text = "A draw!";
        }

        if (lang == "tr")
        {
            gameName.text = "Anneme karşı elmacık kemiği!";
            toilenWinText.text = "Ödev olmayacak!";
            grimaseWinText.text = "Ödevini çabucak yap!";
            drawText.text = "Berabere kaldık!";
        }
    }
}