using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Button btn;
    public Sprite changeImage;
    private Image btnImage;

    public void On_Click()
    {
        btnImage.sprite = changeImage;
    }
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(On_Click);
        btnImage = btn.GetComponentInChildren<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
