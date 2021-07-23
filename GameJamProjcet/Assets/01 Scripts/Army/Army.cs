using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Army : MonoBehaviour
{
    public int level;

    private DragbleArmy dragbleArmy;

    public void Init()
    {
        level = 0;
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
                GameManager.instance.yourMilitary.Remove(this.gameObject);
                GameManager.instance.uiText.setTextMaxArmy();
                Destroy(this.gameObject);
            }
        }
    }

    public void Upgrade()
    {

        level++;
    }
}
