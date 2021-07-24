using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    [Header("Button")]
    public Button btnUpgrade;
    public Button btnTraining;
    public Button btnStore;
    private Button btnIsPressed;

    [Header("Content")]
    public ScrollRect sv;
    public RectTransform Upgrade;
    public RectTransform Training;
    public RectTransform Store;
    public RectTransform Army;
    private RectTransform beforeContent;

    private void Start()
    {
        
    }

    private void InitBeforeButton(Button button)
    {
        if (btnIsPressed != null)
        {
            btnIsPressed.interactable = true;
        }
        btnIsPressed = button;
        button.interactable = false;
    }

    private void InitBeforeContent(RectTransform rectTransform)
    {
        if (beforeContent != null)
        {
            beforeContent.gameObject.SetActive(false);
        }
        else
        {
            Army.gameObject.SetActive(false);
        }
        beforeContent = rectTransform;
        beforeContent.gameObject.SetActive(true);
        sv.content = rectTransform;
    }

    public void OnUpgrade()
    {
        sv.vertical = true;
        InitBeforeButton(btnUpgrade);
        InitBeforeContent(Upgrade);
    }

    public void OnTraining()
    {
        sv.vertical = true;
        InitBeforeButton(btnTraining);
        InitBeforeContent(Training);
    }

    public void OnStore()
    {
        sv.vertical = true;
        InitBeforeButton(btnStore);
        InitBeforeContent(Store);
    }

    public void OnArmy()
    {
        InitBeforeContent(Army);
        sv.vertical = false;
        btnIsPressed.interactable = true;
    }
}