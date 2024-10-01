using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreChanger : MonoBehaviour
{
    //得点
    int score;
    public GameObject Panel2;

    //表示するテキスト
    [SerializeField]
    TMPro.TextMeshProUGUI scoreText;

    void Start()
    {
        score = 0;

    }

    // Update is called once per frame
    public void AddScore()
    {

        ++score;

        scoreText.SetText("score {0},", score);

        if (score == 5)
        {
            SceneManager.LoadScene("clear");
        }
    }
}
