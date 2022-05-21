using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public float ScoreAmount;
    public Text Poeni;

    void Update()
    {
        Poeni.text = ScoreAmount.ToString();
    }

    public void ScoreAdd10()
    {
        ScoreAmount += 10;
    }
}
