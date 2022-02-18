using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public float scoreAmount;
    public float pointIncreasedPerSecond;

    private void Start()
    {
        scoreAmount = 0f;
        pointIncreasedPerSecond = 21f;
    }

    void Update()
    {
        scoreText.text = (int)scoreAmount + " Score";
        scoreAmount += pointIncreasedPerSecond * Time.deltaTime;
    }
}
