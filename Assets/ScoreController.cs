using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;
using UnityEngine.UI;
public class ScoreController : MonoBehaviour
{
    private int score;
    private string scoreText;
    private GameObject ScoreText;


    private void Start()
    {
        this.ScoreText = GameObject.Find("Score");
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStarTag")
        {
            this.score += 10;
        }
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            this.score += 50;
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            this.score += 20;
        }
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            this.score += 30;
        }
    }

    void Update()
    {
        scoreText = score.ToString();
        this.ScoreText.GetComponent<Text>().text = scoreText;
    }
}