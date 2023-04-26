using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawnBehaviour : MonoBehaviour
{
    public GameObject Food;
    public float spawnDelay;
    float timer;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 rndPos = new Vector3(Random.Range(-90f, 90f), 0.5f, Random.Range(-90f, 90f));
            Instantiate(Food, rndPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnDelay)
        {
            Vector3 rndPos = new Vector3(Random.Range(-90f, 90f), 0.5f, Random.Range(-90f, 90f));
            Instantiate(Food, rndPos, Quaternion.identity);
            timer = 0;
        }
    }
}
