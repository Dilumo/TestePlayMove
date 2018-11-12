using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorDisplay : MonoBehaviour
{


    public Armor armor;


    public Text txtName;
    public Text txtPrice;
    public Image imgIcon;

    // Use this for initialization
    void Start()
    {
        txtName.text = armor.name;
        txtPrice.text = armor.price.ToString();

        imgIcon.sprite = armor.icon;
    }
}
