using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    [Header("재화")]
    public int Gold = 0;

    [Header("군대 관리")]
    public int maxArmy = 5;
    public int maxCraftAmry = 5;
    public float currentTimeCraft = 6f;
    public List<Sprite> listMilitary = new List<Sprite>();
    public List<int> yourMilitary = new List<int>();

    [Header("Level")]
    public int maxArmylevel = 0;
    public int maxCraftArmylevel = 0;
    public int craftTimelevel = 0;

    public UIText uiText;
    public SceneChange sceneChange;

    void Awake()
    {
        if (instance != null)
        {
            Debug.Log("GameManager");
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }


    void Start()
    {
        uiText = GetComponent<UIText>();
        sceneChange = GetComponent<SceneChange>();
    }
}