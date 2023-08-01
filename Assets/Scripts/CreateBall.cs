using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    public GameObject BallPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.frameCount % 60 == 0)
        {
            Vector3 pos = new Vector3(Random.Range(-20f, 20f), 10f, 0f);

            Instantiate(BallPrefab, pos, Quaternion.identity);
        }
    }

    
}
