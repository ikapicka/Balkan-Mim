using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Marihuana;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(MarihuanaWave());
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(Marihuana) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * 0, Random.Range(-screenBounds.y, screenBounds.y));
    }
    IEnumerator MarihuanaWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}