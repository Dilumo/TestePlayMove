using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public int money;
    public Text txtMoney;

    [Header("SFX")]
    public AudioClip audioSell;

    public Image imgSellItem;

    [Header("Text")]
    public Text txtNameItem;
    public Text txtPriceItem;


    private AudioController audioController;

    void Start()
    {
        audioController = GetComponent<AudioController>();
        if (audioController == null)
            throw new UnityException("Componente Audio Controller não encontrado.");

    }

    public void ManageMoney(Armor arm)
    {
        money += arm.price;

        SetValuesSale(arm);

        txtMoney.text = "+" + money;
    }

    private void SetValuesSale(Armor arm)
    {
        imgSellItem.sprite = arm.icon;
        txtNameItem.text = arm.name;
        txtPriceItem.text = arm.price.ToString();
    }


    public void ReloadLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
    }


}
