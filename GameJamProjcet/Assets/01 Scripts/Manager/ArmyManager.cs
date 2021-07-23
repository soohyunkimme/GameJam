using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmyManager : MonoBehaviour
{
    public Transform backGround;
    public GameObject ArmyPrefabs;
    private int craftAmry = 5;
    private UIText uiText;

    public Image gageBar;
    private float time;

    void Awake()
    {
        uiText = GetComponent<UIText>();
    }

    public void CreatArmy()
    {
        if ((GameManager.instance.yourMilitary.Count < GameManager.instance.maxArmy) && craftAmry > 0)
        {
            Army army = Instantiate(ArmyPrefabs, backGround).GetComponent<Army>();
            army.Init();
            GameManager.instance.yourMilitary.Add(army.gameObject);

            craftAmry--;
            uiText.setTextMaxArmy();
            uiText.setTextCraftArmy(craftAmry);    
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
                uiText.setTextCraftArmy(craftAmry);
                time = 0;
            }
        }
    }


}