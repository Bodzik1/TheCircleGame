using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkinShopItem : MonoBehaviour
{

    [SerializeField] private SkinManager skinManager;
    [SerializeField] private int skinIdex;
    [SerializeField] private Button buyButton;
    [SerializeField] private TextMeshProUGUI costText;

    private Skin skin;

    void Start()
    {
        skin = skinManager.skins[skinIdex];

        GetComponent<Image>().sprite = skin.sprite;

        if (skinManager.IsUnlocked(skinIdex))
        {
            buyButton.gameObject.SetActive(false);
        }
        else
        {
            buyButton.gameObject.SetActive(true);
            costText.text = skin.cost.ToString();
        }
    }

    public void OnSkinPressed()
    {
        if (skinManager.IsUnlocked(skinIdex))
        {
            skinManager.SelectSkin(skinIdex);
        }
    }

    public void OnBuyButtonPressed()
    {
        int coins = PlayerPrefs.GetInt("Coins", 0);

        if (coins >= skin.cost && !skinManager.IsUnlocked(skinIdex))
        {
            PlayerPrefs.SetInt("coins", coins = skin.cost);
            skinManager.Unlock(skinIdex);
            buyButton.gameObject.SetActive(false);
            skinManager.SelectSkin(skinIdex);
        }
        else
        {
            Debug.Log("Not enough coins");
        }
    }
}
