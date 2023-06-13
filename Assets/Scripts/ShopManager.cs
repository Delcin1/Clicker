using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public GameManager gm;
    public int coins;
    public TMP_Text coinsText;
    public ShopItemSO[] shopItemsSO;
    public ShopTemplate[] shopPanels;

    void Start()
    {
        LoadPanels();
    }

    void Update()
    {
        coins = PlayerPrefs.GetInt("score");
        coinsText.text = "Монетки: " + coins.ToString();
    }

    public void LoadPanels()
    {
        for (int i = 0; i < shopItemsSO.Length; i++)
        {
            shopPanels[i].title.text = shopItemsSO[i].title;
            shopPanels[i].description.text = shopItemsSO[i].description;
            shopPanels[i].costText.text = "Монетки: " + shopItemsSO[i].baseCost.ToString();
            shopPanels[i].cost = shopItemsSO[i].baseCost;
            shopPanels[i].coinPerSec = shopItemsSO[i].coinPerSec;
            shopPanels[i].coinPerClick = shopItemsSO[i].coinPerClick;
            shopPanels[i].videoPlayer.targetTexture = shopItemsSO[i].tex;
            shopPanels[i].videoPlayer.clip = shopItemsSO[i].videoClip;
            shopPanels[i].rawImage.texture = shopItemsSO[i].tex;
            shopPanels[i].gm = gm;
        }
    }
}
