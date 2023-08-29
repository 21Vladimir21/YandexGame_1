using System.Collections;
using System.Collections.Generic;
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
        if (Init.Instance.language == "ru")
        {
            gameName.text = "Гримас шейк против Скибиди Туалета";
            toilenWinText.text = "Скибиди Туалет победил!";
            grimaseWinText.text = "Гримас шейк победил!";
            drawText.text = "Ничья!";
        }

        if (Init.Instance.language == "en")
        {
            gameName.text = "Grimace Shake vs Toilet Skibidi";
            toilenWinText.text = "The Skibidi Toilet won!";
            grimaseWinText.text = "Grimace shake won!";
            drawText.text = "A draw!";
        }

        if (Init.Instance.language == "tr")
        {
            gameName.text = "Yüz buruşturması Shake'e karşı Skibidi Tuvaleti";
            toilenWinText.text = "Skibidi Tuvaleti kazandı!";
            grimaseWinText.text = "Yüz buruşturması shake kazandı!";
            drawText.text = "Berabere kaldık!";
        }
    }
}