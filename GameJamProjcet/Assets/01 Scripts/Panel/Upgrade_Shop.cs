using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade_Shop : MonoBehaviour
{
    [Header("Buttons")]
    public Button btnMaxArmy;
    public Button btnMaxCraftArmy;
    public Button btnCraftTime;

    private int costMaxArmy = 1000;
    private int costMaxCraftArmy = 1000;
    private int costCraftTime = 1000;

    public Text textMaxArmy;
    public Text textCraftArmy;
    public Text textGold;

    void Start()
    {

    }

    public void setUpgrade()
    {
        Text levelText = btnMaxArmy.transform.parent.GetChild(2).GetComponent<Text>();
        levelText.text = $"Lv {GameManager.instance.maxArmylevel}";
        Text costText = btnMaxArmy.transform.GetChild(0).GetComponent<Text>();
        GameManager.instance.uiText.setText(costText, costMaxArmy);

        levelText = btnMaxCraftArmy.transform.parent.GetChild(2).GetComponent<Text>();
        levelText.text = $"Lv {GameManager.instance.maxCraftArmylevel}";
        costText = btnMaxCraftArmy.transform.GetChild(0).GetComponent<Text>();
        GameManager.instance.uiText.setText(costText, costMaxCraftArmy);

        levelText = btnCraftTime.transform.parent.GetChild(2).GetComponent<Text>();
        levelText.text = $"Lv {GameManager.instance.craftTimelevel}";

        Text costtext = btnCraftTime.transform.GetChild(0).GetComponent<Text>();
        GameManager.instance.uiText.setText(costtext, costCraftTime);
    }

    public void Upgrade_maxArmy()
    {
        if (GameManager.instance.Gold > costMaxArmy)
        {
            GameManager.instance.Gold -= costMaxArmy;
            GameManager.instance.maxArmy++;
            costMaxArmy = (GameManager.instance.maxArmy * 2000);

            Text levelText = btnMaxArmy.transform.parent.GetChild(2).GetComponent<Text>();
            GameManager.instance.maxArmylevel++;
            levelText.text = $"Lv {GameManager.instance.maxArmylevel}";

            Text costText = btnMaxArmy.transform.GetChild(0).GetComponent<Text>();
            GameManager.instance.uiText.setText(costText, costMaxArmy);
            GameManager.instance.uiText.setText(textGold, GameManager.instance.Gold);
            GameManager.instance.uiText.setTextMaxArmy(textMaxArmy);
            if (GameManager.instance.maxArmylevel > 39)
            {
                btnMaxArmy.interactable = false;
            }
        }
    }

    public void Upgrade_maxCraftArmy()
    {
        if (GameManager.instance.Gold > costMaxCraftArmy)
        {
            GameManager.instance.Gold -= costMaxCraftArmy;
            GameManager.instance.maxCraftAmry++;
            costMaxCraftArmy = (GameManager.instance.maxCraftAmry * 2000);//식 다시세우기

            Text levelText = btnMaxCraftArmy.transform.parent.GetChild(2).GetComponent<Text>();
            GameManager.instance.maxCraftArmylevel++;
            levelText.text = $"Lv {GameManager.instance.maxCraftArmylevel}";

            Text costtext = btnMaxCraftArmy.transform.GetChild(0).GetComponent<Text>();
            GameManager.instance.uiText.setText(costtext, costMaxCraftArmy);
            GameManager.instance.uiText.setText(textGold, GameManager.instance.Gold);
            if (GameManager.instance.maxCraftArmylevel > 39)
            {
                btnMaxCraftArmy.interactable = false;
            }
        }
    }

    public void Upgrade_CraftTime()
    {
        if (GameManager.instance.Gold > costCraftTime)
        {
            GameManager.instance.Gold -= costCraftTime;
            GameManager.instance.currentTimeCraft -= 0.1f;


            Text levelText = btnCraftTime.transform.parent.GetChild(2).GetComponent<Text>();
            GameManager.instance.craftTimelevel++;
            levelText.text = $"Lv {GameManager.instance.craftTimelevel}";
            costCraftTime = (int)(GameManager.instance.craftTimelevel * 2000f);//식 다시세우기

            Text costtext = btnCraftTime.transform.GetChild(0).GetComponent<Text>();
            GameManager.instance.uiText.setText(costtext, costCraftTime);
            GameManager.instance.uiText.setText(textGold, GameManager.instance.Gold);

            if (GameManager.instance.craftTimelevel > 39)
            {
                btnCraftTime.interactable = false;
            }
        }
    }
}