using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private TMP_Text scoreText;

    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void Click()
    {
        score += 1;
    }
}