using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public Slider levelBar;
    public TMP_Text levelText;
    public TMP_Text xpProgress;

    int level;
    int totalXP;

    public void AddXP(int xp)
    {
        totalXP = (int)levelBar.value + xp;
        levelBar.value += xp;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xpProgress.text = $"{levelBar.value}/{levelBar.maxValue}";
        if (levelBar.value >= levelBar.maxValue)
        {
            level++;
            levelBar.value = totalXP - levelBar.maxValue;
            totalXP = 0;
            levelBar.maxValue = (25 * level) + 50;
            levelText.text = $"Level {level}";
        }
    }
}
