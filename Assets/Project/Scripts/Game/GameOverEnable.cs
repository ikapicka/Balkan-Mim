using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverEnable : MonoBehaviour
{
    public GameObject Activate;
    public void GameOver()
    {
        Activate.SetActive(true);
    }

}
