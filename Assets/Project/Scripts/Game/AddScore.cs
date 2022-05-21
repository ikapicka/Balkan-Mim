using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{

    public Score AddScore1;
    public Renderer DisableLiveMesh;
    public GameObject DeadPrefab;

    // Start is called before the first frame update
    void Start()
    {
        AddScore1 = GameObject.FindObjectOfType<Score>();
    }

    void OnMouseDown()
    {
        AddScore1.ScoreAdd10();
        DisableLiveMesh.enabled = false;
        DeadPrefab.SetActive(true);
    }
}

