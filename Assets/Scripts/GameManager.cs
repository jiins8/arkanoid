using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip level1Sound, level2Sound, level3Sound;

    void Start()
    {
        int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentLevelIndex == 1)
        {
            audioSource.clip = level1Sound;
        }
        else if (currentLevelIndex == 2)
        {
            audioSource.clip = level2Sound;
        }
        else if (currentLevelIndex == 3)
        {
            audioSource.clip = level3Sound;
        }

        audioSource.Play();
    }

    public int lives = 3;

    public void LoseHealth()
    {
        lives--;

        if (lives <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            ResetLevel();
        }
    }

    public void ResetLevel()
    {
        FindObjectOfType<Ball>().ResetBall();
        FindObjectOfType<Player>().ResetPlayer();
    }

    public void checkLevelCompleted()
    {
        if (transform.childCount <= 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
