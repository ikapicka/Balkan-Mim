using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    [Header("Target")]
    public GameObject prefab;

    [Header("Gameplay")]
   
    public float interval;
    public float minimumX;
    public float maximumX;
    public float y;

    [Header("Visuals")]
    
    public Sprite[] sprites;


    // Start is called before the first frame update
    void Start () {
        InvokeRepeating ("Spawn", interval, interval); 
    }

    private void Spown()
    {
        GameObject instance = Instantiate (prefab);
        instance.transform.position = new Vector2 (
            Random.Range(minimumX, maximumX),
            y
            );

        Sprite randomSprite = sprites[Random.Range(0, sprites.Length)];
        instance.GetComponent<SpriteRenderer>().sprite = randomSprite;
    }

   
}
