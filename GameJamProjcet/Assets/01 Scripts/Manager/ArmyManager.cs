using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmyManager : MonoBehaviour
{
    public Transform backGround;
    public GameObject ArmyPrefabs;
    private int craftAmry = 5;
    public Text textCraftArmy;
    public Text textMaxArmy;

    public Image gageBar;
    private float time;

    public void CreatArmy()
    {
        if ((GameManager.instance.yourMilitary.Count < GameManager.instance.maxArmy) && craftAmry > 0)
        {
            Army army = Instantiate(ArmyPrefabs, backGround).GetComponent<Army>();
            army.Init(textMaxArmy);

            craftAmry--;
            GameManager.instance.uiText.setTextMaxArmy(textMaxArmy);
            GameManager.instance.uiText.setTextCraftArmy(textCraftArmy, craftAmry);    
        }
    }

    void Update()
    {
        if(craftAmry < GameManager.instance.maxCraftAmry)
        {
            time += Time.deltaTime;
            gageBar.fillAmount = time / GameManager.instance.currentTimeCraft;
            if(time > GameManager.instance.currentTimeCraft)
            {
                craftAmry++;
                GameManager.instance.uiText.setTextCraftArmy(textCraftArmy, craftAmry);
                time = 0;
            }
        }
    }
}