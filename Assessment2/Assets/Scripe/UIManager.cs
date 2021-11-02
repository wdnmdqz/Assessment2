using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Text player1Score;
    public Text Player2Score;
    private static UIManager instance;
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        int scorePlayer1 = ScoreKeeper.Instance.ScoreForPlayer1;
        int scorePlayer2 = ScoreKeeper.Instance.ScoreForPlayer2;
        player1Score.text = "ScoreForPlayer1: "+ scorePlayer1;
        Player2Score.text = "ScoreForPlayer2: "+ scorePlayer2;
    }
}
