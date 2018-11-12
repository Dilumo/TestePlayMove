using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaleCollider : MonoBehaviour
{

    public GameController gameController = null;

    private ArmorDisplay ramObj;


    public bool right;

    private void Start()
    {

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject armorSlow = other.gameObject;
        ArmorDisplay arm = armorSlow.GetComponent<ArmorDisplay>();

        if (armorSlow.tag == "Armor")
        {
            gameController.ManageMoney(arm.armor);
        }
        Destroy(arm.gameObject);
    }

}
