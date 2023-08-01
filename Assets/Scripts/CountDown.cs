using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public float countDownTime = 60f;
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countDownTime -= Time.deltaTime;

        timeText.text = countDownTime.ToString("f1");

        if (countDownTime <= 0)
        {
            SceneManager.LoadScene("result");
        }
    }
}
