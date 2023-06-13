using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int score = 0;
    [SerializeField] private int coinPerSec = 0;
    [SerializeField] private int coinPerClick = 1;
    [SerializeField] private TMP_Text scoreText;

    public GameObject shop;
    public TMP_Text shopText;

    void Start()
    {
        if (PlayerPrefs.HasKey("score"))
        {
            score = PlayerPrefs.GetInt("score");
        } else
        {
            PlayerPrefs.SetInt("score", score);
        }
        if (PlayerPrefs.HasKey("coinPerSec"))
        {
            coinPerSec = PlayerPrefs.GetInt("coinPerSec");
        }
        else
        {
            PlayerPrefs.SetInt("coinPerSec", coinPerSec);
        }
        if (PlayerPrefs.HasKey("coinPerClick"))
        {
            coinPerClick = PlayerPrefs.GetInt("coinPerClick");
        }
        else
        {
            PlayerPrefs.SetInt("coinPerClick", coinPerClick);
        }
        PlayerPrefs.Save();
        StartCoroutine(AutoClickCoroutine());
    }

    void Update()
    {
        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.Save();
        scoreText.text = score.ToString();
    }

    public void Click()
    {
        score += coinPerClick;
    }

    public void ShopBtn()
    {
        if (shop.activeSelf)
        {
            shopText.text = "Магазин";
            shop.SetActive(false);
        } else
        {
            shopText.text = "Назад";
            shop.SetActive(true);
        }
    }

    public void CloseBtn()
    {
        Application.Quit();
    }

    IEnumerator AutoClickCoroutine()
    {
        while (true)
        {
            score += coinPerSec;
            yield return new WaitForSeconds(1);
        }
    }

    public void UpdateGoods()
    {
        score = PlayerPrefs.GetInt("score");
        coinPerClick = PlayerPrefs.GetInt("coinPerClick");
        coinPerSec = PlayerPrefs.GetInt("coinPerSec");
    }
}