using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float pointsPerSecond = 1;
    public float scoreValue = 0;

    public TextMeshProUGUI score;

    //void Start()
    //{
    //    score = GetComponent<TextMeshProUGUI>();

    //}
    void Update()
    {
        scoreValue += pointsPerSecond * Time.deltaTime;
        score.text = "Score: " + scoreValue.ToString("0");
    }
}
