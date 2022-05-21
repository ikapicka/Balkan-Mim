using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseGame : MonoBehaviour
{

    public Renderer DisableLiveMesh;
    public GameOverEnable GameOverEnabler;
    
    // Start is called before the first frame update
    void Start()
    {
        GameOverEnabler = GameObject.FindObjectOfType<GameOverEnable>();
    }

    void OnMouseDown()
    {
        DisableLiveMesh.enabled = false;
        GameOverEnabler.GameOver();
    }
}

