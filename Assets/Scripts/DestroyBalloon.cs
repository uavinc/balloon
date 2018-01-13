using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DestroyBalloon : MonoBehaviour, IPointerDownHandler
{
    private Score score;
    public int ballonType;

    private void Start()
    {
        score = GameObject.Find("HUD").GetComponent<Score>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        score.addScore(ballonType);
        Destroy(gameObject);
    }

    private void Update()
    {
        if(transform.position.y - (Camera.main.orthographicSize * 2.0f) / 2 >= 1)
        {
            score.changeLives();
            Destroy(gameObject);
        }
    }
}
