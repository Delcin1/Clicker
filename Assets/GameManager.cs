using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private Text scoreText;

    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void Click()
    {
        score += 1;
    }
}