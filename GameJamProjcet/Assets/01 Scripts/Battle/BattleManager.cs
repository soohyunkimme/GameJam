using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    public GameObject armyLevel_0;
    public GameObject armyLevel_1;
    public GameObject armyLevel_2;

    public Transform spawnPoint;

    private GameObject spawnArmy;


    public Text goldText;
    public int dps = 0;


    void Start()
    {
        GameManager.instance.uiText.setText(goldText, GameManager.instance.Gold);
        foreach (var item in GameManager.instance.yourMilitary)
        {
            dps += item;
        }

        for (int i = 0; i < GameManager.instance.yourMilitary.Count; i++)
        {
            SpawnArmy(GameManager.instance.yourMilitary[i]);
            StartCoroutine(autoAttack(GameManager.instance.yourMilitary[i]));
            GameObject army = Instantiate(spawnArmy, spawnPoint);

            army.transform.position += Vector3.left * i;

        }
    }

    IEnumerator autoAttack(int level)
    {
        while (true)
        {
            GameManager.instance.Gold += level;
            GameManager.instance.uiText.setText(goldText, GameManager.instance.Gold);
            yield return new WaitForSeconds(2f);
        }
    }

    private void SpawnArmy(int level)
    {
        switch (level)
        {
            case 0:
                spawnArmy = armyLevel_0;
                break;
            case 1:
                spawnArmy = armyLevel_1;
                break;
            case 2:
                spawnArmy = armyLevel_2;
                break;
        }
    }

    public void Click()
    {
        GameManager.instance.Gold += dps;
        GameManager.instance.uiText.setText(goldText, GameManager.instance.Gold);
    }
}
