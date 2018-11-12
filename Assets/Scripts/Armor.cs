using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Armor",menuName ="Armor")]
public class Armor : ScriptableObject
{
    [Header("Info")]
    public new string name;
    public int price;


    [Header("Appearance")]
    public Sprite icon;

}
