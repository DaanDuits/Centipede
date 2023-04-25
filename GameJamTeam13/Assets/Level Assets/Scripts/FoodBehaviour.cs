using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehaviour : MonoBehaviour
{
    public ScoreSystem scoreSystem;
    public int score;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision");
        if (other.gameObject.name == "Head")
        {
            scoreSystem.AddScore(score);
            Destroy(gameObject);
        }
    }
}
