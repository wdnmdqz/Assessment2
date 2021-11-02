using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    static private ScoreKeeper instance;
    private int scoreForPlayer1;
    private int scoreForPlayer2;
    public int pointsPerPick;

    public static ScoreKeeper Instance
    {
        get
        {
            return instance;
        }
    }
    public int ScoreForPlayer1
    {
        get
        {
            return scoreForPlayer1;
        }
    }
    
    public int ScoreForPlayer2
    {
        get
        {
            return scoreForPlayer2;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddPointsPerPickP1()
    {
        scoreForPlayer1+=pointsPerPick;
    }
    public void AddPointsPerPickP2()
    {
        scoreForPlayer2+=pointsPerPick;
    }
}