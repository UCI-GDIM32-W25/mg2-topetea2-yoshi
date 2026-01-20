using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager: MonoBehaviour
{
    public static ScoreManager instance;
    public int points = 0;
    public TextMeshProUGUI pointsText;
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    public void AddPoint()
    {
        points++;
        pointsText.text = "Points: " + points.ToString();
    }
}
