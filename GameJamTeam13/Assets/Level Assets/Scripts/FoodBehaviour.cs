using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehaviour : MonoBehaviour
{
    ScoreSystem scoreSystem;
    public int score;

    private void Start()
    {
        scoreSystem = GameObject.Find("ScoreManager").GetComponent<ScoreSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Head")
        {
            other.GetComponent<AudioSource>().Play();
            scoreSystem.AddScore(score);
            Destroy(gameObject);
        }
    }
}
