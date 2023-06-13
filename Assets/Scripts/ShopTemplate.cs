using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;

public class ShopTemplate : MonoBehaviour
{
    public TMP_Text title;
    public TMP_Text description;
    public TMP_Text costText;
    public int cost;
    public VideoPlayer videoPlayer;
    public RawImage rawImage;
    public int coinPerSec;
    public int coinPerClick;
    private int curScore;
    public GameManager gm;


    public void BuyItem()
    {
        curScore = PlayerPrefs.GetInt("score");
        if (curScore < cost)
        {
            return;
        }
        PlayerPrefs.SetInt("score", curScore - cost);
        PlayerPrefs.SetInt("coinPerSec", PlayerPrefs.GetInt("coinPerSec") + coinPerSec);
        PlayerPrefs.SetInt("coinPerClick", PlayerPrefs.GetInt("coinPerClick") + coinPerClick);
        PlayerPrefs.Save();
        gm.UpdateGoods();
    }
}
