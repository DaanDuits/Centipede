using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public Slider levelBar;
    public TMP_Text xpProgress;

    public GameObject victoryScreen;

    public void AddScore(int score)
    {
        levelBar.value += score;
        xpProgress.text = $"{levelBar.value}/{levelBar.maxValue}";
    }

    // Start is called before the first frame update
    void Start()
    {
        xpProgress.text = $"{levelBar.value}/{levelBar.maxValue}";
    }

    // Update is called once per frame
    void Update()
    {
        if (levelBar.value == levelBar.maxValue)
            LevelComplete();
    }

    public void LevelComplete()
    {
        victoryScreen.SetActive(true);
    }
}
