using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmyManager : MonoBehaviour
{
    public Transform backGround;
    public GameObject ArmyPrefabs;
    private int craftAmry = 5;

    public Image gageBar;
    private float time;

    public void CreatArmy()
    {
        if ((GameManager.instance.yourMilitary.Count < GameManager.instance.maxArmy) && craftAmry > 0)
        {
            Army army = Instantiate(ArmyPrefabs, backGround).GetComponent<Army>();
            army.Init();

            craftAmry--;
            GameManager.instance.uiText.setTextMaxArmy();
            GameManager.instance.uiText.setTextCraftArmy(craftAmry);    
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
                GameManager.instance.uiText.setTextCraftArmy(craftAmry);
                time = 0;
            }
        }
    }
}