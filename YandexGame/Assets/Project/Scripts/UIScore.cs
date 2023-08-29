using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    [SerializeField] private PlayerScore playerScore;
    [SerializeField] private PlayerScore playerScore2;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text scoreText2;

    private void Update()
    {
        scoreText.text = playerScore.score.ToString();
        scoreText2.text = playerScore2.score.ToString();
    }
}
