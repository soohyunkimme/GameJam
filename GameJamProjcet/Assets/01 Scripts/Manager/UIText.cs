using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{
    public Text textGold;
    public Text textMaxArmy;
    public Text textCraftArmy;


    public void setText(Text text, int gold)
    {
        text.text = string.Format("{0:#,###}", gold);
    }

    public void setTextMaxArmy()
    {
        textMaxArmy.text = $"{GameManager.instance.yourMilitary.Count} / {GameManager.instance.maxArmy}";
    }

    public void setTextCraftArmy(int craftArmy)
    {
        textCraftArmy.text = $"{craftArmy} / {GameManager.instance.maxCraftAmry}";
    }
}