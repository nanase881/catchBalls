using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateItem : MonoBehaviour
{
    public GameObject ItemPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 30 == 0)
        {
            Vector3 pos = new Vector3(Random.Range(-20f, 20f), 10f, 0f);

            Instantiate(ItemPrefab, pos, Quaternion.identity);
        }
    }
}
