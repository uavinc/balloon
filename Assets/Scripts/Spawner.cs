using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] balloons;
    public Score score;
    public float startTime;
    private float timer;
    private Vector2 spawnPos;
    private float startY;
    private float startX;
    public int iteration = 1;


    private void Awake ()
    {
        startY = (Camera.main.orthographicSize * 2.0f)/ 2;
        startX = (Camera.main.orthographicSize * 2.0f * Camera.main.aspect)/ 2 - 0.5f;
    }

    private void Update ()
    {
        if(score.getScore() >= 25 && score.getScore() <= 50)
        {
            iteration = 2;
        }
        else if((score.getScore() > 50 && score.getScore() <= 100))
        {
            iteration = 3;
        }

		if(timer <= 0)
        {
            spawnPos = new Vector2(Random.Range(-startX, startX),-startY);
            Instantiate(balloons[Random.Range(0, iteration)], spawnPos, Quaternion.identity);
            timer = startTime - 0.05f;
        }
        timer -= Time.deltaTime;
	}
}
