using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	public float Xincrement;
	public int Health = 3;
	public float playerScore = 0f;
	public Text HealthDisplay;
	public Text ScoreDisplay;
	public Text OverScoreDisplay;
	public GameObject gameOver;
	public GameObject gameOverSound;

    void Update()
    {
    	Time.timeScale = 1;
    	playerScore += Time.deltaTime;
    	ScoreDisplay.text = playerScore.ToString();
    	HealthDisplay.text = Health.ToString();
    	OverScoreDisplay.text = playerScore.ToString();

    	if (Health <= 0)
    	{
    		Instantiate(gameOverSound, transform.position, Quaternion.identity);
   			gameOver.SetActive(true);
			Destroy(gameObject);
			Time.timeScale = 0;
    	}

     	if(Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 5)
     	{
     		transform.position += Vector3.right * Xincrement;
     	}

     	if(Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -5)
     	{
     		transform.position += Vector3.left * Xincrement;
     	}      
    }
}
