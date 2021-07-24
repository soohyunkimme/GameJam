using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public GameObject armyPrefab;

    public void ChangeToBattleScene()
    {
        SceneManager.LoadScene("BattleScene");
        
    }

    public void ChangeToGameScene()
    {
        SceneManager.LoadScene("GameScene");
        GameManager.instance.yourMilitary.RemoveRange(0, GameManager.instance.yourMilitary.Count);
    }
}
