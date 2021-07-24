using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void Start()
    {
        
    }

    public void ChangeToBattleScene()
    {
        SceneManager.LoadScene("BattleScene");
        PlayerPrefs.SetInt("a", 123);
        PlayerPrefs.GetInt("a");
    }

    public void ChangeToGameScene()
    {
        SceneManager.LoadScene("GameScene");
        
    }
}
