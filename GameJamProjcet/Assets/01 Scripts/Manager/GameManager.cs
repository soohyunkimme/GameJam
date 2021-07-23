using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    

    [Header("재화")]
    public int Gold = 0;
    public int Diamond = 0;
    public int document = 0;

    [Header("군대 관리")]
    public int maxArmy = 5;
    public int maxCraftAmry = 5;
    public float currentTimeCraft = 6f;
    public List<Sprite> listMilitary = new List<Sprite>();
    public List<int> yourMilitary = new List<int>();

    [Header("Level")]

    public UIText uiText;
    public SceneChange sceneChange;

    void Awake()
    {
        if (instance != null)
        {
            Debug.Log("GameManager");
        }
        instance = this;
    }

    void Start()
    {
        uiText = GetComponent<UIText>();
        sceneChange = GetComponent<SceneChange>();
    }
}