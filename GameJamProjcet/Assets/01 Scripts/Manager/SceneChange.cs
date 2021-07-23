using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ChangeToBattleScene()
    {
        SceneManager.LoadScene("BattleScene");
        DontDestroyOnLoad(this.gameObject);
    }

    public void ChangeToGameScene()
    {
        SceneManager.LoadScene("GameScene");
        DontDestroyOnLoad(this.gameObject);
    }
}
