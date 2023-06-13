using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public int coins;
    public TMP_Text coinsText;
    public ShopItemSO[] shopItemsSO;
    public ShopTemplate[] shopPanels;

    // Start is called before the first frame update
    void Start()
    {
        coinsText.text = "Coins: " + coins.ToString();
        LoadPanels();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadPanels()
    {
        for (int i = 0; i < shopItemsSO.Length; i++)
        {
            shopPanels[i].title.text = shopItemsSO[i].title;
            shopPanels[i].description.text = shopItemsSO[i].description;
            shopPanels[i].cost.text = "Coins: " + shopItemsSO[i].baseCost.ToString();
            shopPanels[i].videoPlayer.targetTexture = shopItemsSO[i].tex;
            shopPanels[i].videoPlayer.clip = shopItemsSO[i].videoClip;
            shopPanels[i].rawImage.texture = shopItemsSO[i].tex;
        }
    }
}
