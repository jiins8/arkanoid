using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverScenes : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip gameOverSound, startSound, victorySound;

    void Start()
    {
        int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentLevelIndex == 0)
        {
            audioSource.clip = startSound;

        }
        else if (currentLevelIndex == 4)
        {
            audioSource.clip = victorySound;
        }
        else if (currentLevelIndex == 5)
        {
            audioSource.clip = gameOverSound;
        }

        audioSource.Play();
    }
    public void ResetGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Exit()
    {
        Application.Quit();
    }
}