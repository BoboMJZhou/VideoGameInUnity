using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_manager : MonoBehaviour {

    bool isGameOver = false;
    public float restartDelay = 1.0f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        Debug.Log("Complete");
        completeLevelUI.SetActive(true);
    }

	public void EndGame()
    {
        if(!isGameOver)
        {
            Debug.Log("Game Over");
            isGameOver = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
