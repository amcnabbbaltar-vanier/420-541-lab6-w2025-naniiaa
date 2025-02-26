using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;

    // Start is called before the first frame update
    public void Start()
    {
        gameOverPanel.SetActive(true);

        if(GameManager.Instance)
        {
            scoreText.text = "Score: " + GameManager.Instance.targetScore.ToString();
        }
    }

    // Update is called once per frame
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
