using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void ChangeToBattleScene()
    {
        SceneManager.LoadScene("BattleScene");
    }

    public void ChangeToGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
