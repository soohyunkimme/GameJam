using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{
    public void setText(Text text, int gold)
    {
        if (gold == 0)
        {
            text.text = gold.ToString();
        }
        else
        {
            text.text = string.Format("{0:#,###}", gold);
        }

    }

    public void setTextMaxArmy(Text text)
    {
        text.text = $"{GameManager.instance.yourMilitary.Count} / {GameManager.instance.maxArmy}";
    }

    public void setTextCraftArmy(Text text, int count)
    {
        text.text = $"{count} / {GameManager.instance.maxCraftAmry}";
    }
}