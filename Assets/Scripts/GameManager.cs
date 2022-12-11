using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    float time = 0;
    public float startingTime = 20 * 60f;

    public TMP_Text timeCounter;

    void Start()
    {
        time = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timeCounter.text = time.ToString("0");
    }
}
