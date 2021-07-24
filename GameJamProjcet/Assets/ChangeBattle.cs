using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBattle : MonoBehaviour
{
    public Button btnBack;
    


    void Start()
    {
        btnBack.onClick.AddListener(() =>
        {
            GameManager.instance.sceneChange.ChangeToBattleScene();
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
