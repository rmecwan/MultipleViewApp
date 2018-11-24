using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    public static GameControl Instance; // Created a Singleton 

    public float scrollSpeed = -1.5f; // How fast the game world will scroll by 
    public bool isGameOver = false; 
    private int score = 0;

    public Text scoreText;
    public GameObject gameOverText;

	void Awake () { // Happens before Start 
        if(Instance == null) {
            Instance = this;
        } else if(Instance != this) {
            Destroy(gameObject); // built in variable to a reference to this
        }
	}
	

	void Update () { 
        if(isGameOver && Input.GetMouseButtonDown(0)) { // allows player to start over after game is over
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // reload entire scene
        }
	}

    public void Score() {
        if(isGameOver) {
            return;
        }
        score++;
        scoreText.text = "Score: " + score;
    }

    public void Die() {
        isGameOver = true;
        gameOverText.SetActive(true); // to display gameOverText onto the UI
    }
}
