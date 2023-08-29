using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    [SerializeField] private Sprite playerObject;
    [SerializeField] private PlayerScore playerScore;
    [SerializeField] private bool firstPlayer;
    public int score = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.GetComponent<TileColorManager>().imFree)
        {
            if (other.gameObject.GetComponent<TileColorManager>().imСolored != firstPlayer)
            {
                CangeColor(other);
                playerScore.score--;
            }
        }
        else
            CangeColor(other);
    }

    private void CangeColor(Collider2D other)
    {
        other.gameObject.GetComponent<SpriteRenderer>().sprite = playerObject;
        other.gameObject.GetComponent<TileColorManager>().SwithcColorType(firstPlayer);
        score++;
    }
}