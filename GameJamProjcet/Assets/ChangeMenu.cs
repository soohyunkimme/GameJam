using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMenu : MonoBehaviour
{
    public Button btnBack;

    // Start is called before the first frame update
    void Start()
    {
        btnBack.onClick.AddListener(() => {
            GameManager.instance.sceneChange.ChangeToGameScene();
            });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
