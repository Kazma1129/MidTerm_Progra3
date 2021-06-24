using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pokemon : Attack
{
    public Text tx;


    public override void attack()
    {

        base.attack();

    }

    public void damage()
    {

        hpC -= atkS + defC;
        tx.text = hpC.ToString();
        if (hpC <= 0/*!aliveS*/)
        {
            Destroy(this.gameObject);
        }
    }
}
