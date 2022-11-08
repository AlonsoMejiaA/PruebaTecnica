using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public int score;
    [SerializeField] int scoreToWin;
    private float Timing;
    private int showi,lastTime;
    [SerializeField] Text timer, mensajefinal;
    [SerializeField] GameObject[] game;
    [SerializeField] Button BUT;

    private void Awake()
    {
        Timing = 10000000;
    }
    private void Update()
    {
        if (Timing > 0)
        {
            Timing = Timing - Time.deltaTime;
            showi = (int)Timing;
        } 
        if (score == scoreToWin || Timing < 0)
        {
            clearGame();
            lastTime = showi;
            ShowMensaje();
            Timing = 0;
        }
        timer.text = "Puntaje restante: " + showi;
    }
    private void ShowMensaje()
    {
        mensajefinal.gameObject.SetActive(true);
        mensajefinal.text = "Puntaje Final: " + lastTime;
        BUT.gameObject.SetActive(true);
    }
    private void clearGame()
    {
        foreach (var item in game)
        {
            item.SetActive(false);
        }
    }
    public void StartTime()
    {
        Timing = 1200F;
    }
}
