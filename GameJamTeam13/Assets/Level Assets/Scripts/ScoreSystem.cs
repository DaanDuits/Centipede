using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public Slider levelBar;
    public TMP_Text xpProgress;

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
}
