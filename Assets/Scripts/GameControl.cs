using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    public static GameControl gameControl;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollSpeed = 1.5f;
    private Player airPlane;

    public Text scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Awake()
    {

        if (gameControl == null)
        {
            gameControl = this;
        }
        else if (gameControl != this)
        {
            Destroy(gameObject);
        }

        airPlane = GetComponent<Player>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKey(KeyCode.Escape))
        {

            Application.Quit();
        }

    }

    public void AirScore()
    {
        if (gameOver)
        {
            return;
        }

        score++;
        scoreText.text = "Pontos:" + score.ToString();
    }

    public void AirDie()
    {
        gameOverText.SetActive(true);
        gameOver = true;
            GetComponent<AudioSource>().Play();
       
    }

 

}
