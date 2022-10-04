using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public int score = 0;
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public UnityEvent onScoreUpdate;
    public void AddScore(int amount)
    {
        score += amount;
        onScoreUpdate.Invoke();
    }

    public UnityEvent onVictory;
    public void Win()
    {
        Time.timeScale = 0;
        onVictory.Invoke();
    }
}
