using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isGameOver = false;
    public float time = 0;
    public float startingTime = 20 * 60f;

    public TMP_Text timeCounter;

    void Start()
    {
        time = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver) return;
        time -= Time.deltaTime;
        timeCounter.text = Helpers.ToMinuteSecond((int) time);
        if (time <= 0)
        {
            isGameOver = true;
        }
    }

    void FGame(GameOver over)
    {
        over.FinishGame();
    }
}
