using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public Text countText;
    int count;

    // Start is called before the first frame update
    void Start()
    {
        count = BasketMove.GetCount();
        countText.text = count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
