using System;
using System.Collections;
using System.Collections.Generic;
using Kimicu.YandexGames;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private PlayerScore playerScore;
    [SerializeField] private PlayerScore playerScore2;

    [SerializeField] private GameObject startGamePanal;
    [SerializeField] private GameObject gameUI;
    [SerializeField] private GameObject game;
    [SerializeField] private GameObject joystick1;
    [SerializeField] private GameObject joystick2;

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject player2;
    [SerializeField] private Transform playerStartPosition;
    [SerializeField] private Transform player2StartPosition;

    [SerializeField] private GameObject player1WinPanel;
    [SerializeField] private GameObject player2WinPanel;
    [SerializeField] private GameObject drawPanel;
    [SerializeField] private Button backToMenuButton;
    
    [HideInInspector] public bool onePlayer = true;
    private byte _numberOfGame = 0;

    public static readonly UnityEvent WhoWon = new UnityEvent();

    private void Awake()
    {
        WhoWon.AddListener(WhoWonGame);
        
        backToMenuButton.onClick.AddListener(BackToMenu);
    }

    public void StartGame(bool OnePlayer)
    {
        onePlayer = OnePlayer;
        TurnOnTheJoysticks(true);

        startGamePanal.SetActive(false);
        gameUI.SetActive(true);
        game.SetActive(true);
        player.transform.position = playerStartPosition.position;
        player2.transform.position = player2StartPosition.position;
    }

    public void BackToMenu()
    {
        if (Advertisement.AdvertisementIsAvailable)
            Advertisement.ShowInterstitialAd(onCloseCallback: EndLevel);
        else 
            EndLevel();
    }

    private void EndLevel()
    {
        TurnOnTheJoysticks(false);
        startGamePanal.SetActive(true);
        gameUI.SetActive(false);
        game.SetActive(false);
        player1WinPanel.SetActive(false);
        player2WinPanel.SetActive(false);
        drawPanel.SetActive(false);
        playerScore.score = 0;
        playerScore2.score = 0;
        backToMenuButton.gameObject.SetActive(false);
    }

    private void WhoWonGame()
    {
        _numberOfGame++;
        if (playerScore.score > playerScore2.score)
            player1WinPanel.SetActive(true);
        if (playerScore.score < playerScore2.score)
            player2WinPanel.SetActive(true);
        if (playerScore.score == playerScore2.score)
            drawPanel.SetActive(true);
        
        backToMenuButton.gameObject.SetActive(true);
        // StartCoroutine(WinCor());
    }

    private IEnumerator WinCor()
    {
        yield return new WaitForSeconds(3);
        BackToMenu();
    }

    private void TurnOnTheJoysticks(bool @on)
    {
        if (Device.IsMobile)
        {
            joystick1.SetActive(@on);
            if (onePlayer) return;
            joystick2.SetActive(@on);
        }
    }
}