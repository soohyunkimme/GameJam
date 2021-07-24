using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Army : MonoBehaviour
{
    public int level;
    private Text textMaxArmy;

    private DragbleArmy dragbleArmy;
    private Image armyImage;

    public void Init(Text text)
    {
        armyImage = GetComponent<Image>();

        level = 0;
        GameManager.instance.yourMilitary.Add(this.level);
        armyImage.sprite = GameManager.instance.listMilitary[level];
        textMaxArmy = text;

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (level == 2) return;
        dragbleArmy = GetComponent<DragbleArmy>();
        if (dragbleArmy.isDragging)
        {
            Army army = collision.GetComponent<Army>();
            if (army.level == level)
            {
                army.Upgrade();
                GameManager.instance.yourMilitary.Remove(this.level);
                GameManager.instance.uiText.setTextMaxArmy(textMaxArmy);
                Destroy(this.gameObject);
            }
        }
    }

    public void Upgrade()
    {
        GameManager.instance.yourMilitary.Remove(this.level);
        level++;
        GameManager.instance.yourMilitary.Add(this.level);
    }

    void Update()
    {
        armyImage.sprite = GameManager.instance.listMilitary[level];
    }
}
