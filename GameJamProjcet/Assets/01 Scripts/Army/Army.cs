using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Army : MonoBehaviour
{
    public int level;

    private DragbleArmy dragbleArmy;
    private Image armyImage;

    public void Init()
    {
        armyImage = GetComponent<Image>();

        level = 0;
        GameManager.instance.yourMilitary.Add(this.level);
        armyImage.sprite = GameManager.instance.listMilitary[level];
        //this.transform.position = new Vector2(Random.Range(transform.position.x);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (level == 3) return;
        dragbleArmy = GetComponent<DragbleArmy>();
        if (dragbleArmy.isDragging)
        {
            Army army = collision.GetComponent<Army>();
            if (army.level == level)
            {
                army.Upgrade();
                GameManager.instance.yourMilitary.Remove(this.level);
                GameManager.instance.uiText.setTextMaxArmy();
                Destroy(this.gameObject);
            }
        }
    }

    public void Upgrade()
    {
        GameManager.instance.yourMilitary.Remove(this.level);
        level++;
        GameManager.instance.yourMilitary.Add(this.level);

        armyImage.sprite = GameManager.instance.listMilitary[level];
    }
}
