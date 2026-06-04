using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
  private int _playerScore;
  private int _computerScore;

  public ball Ball;
  public TextMeshProUGUI playerScore;
  public TextMeshProUGUI computerScore;
  public paddles playerpaddle;
  public paddles computerpaddle;

  public GameObject gameOverPanel;
  public TextMeshProUGUI winner;


  public void TotalPlayerScore()
    {
        _playerScore++;
        this.playerScore.text = _playerScore.ToString();
        Debug.Log(_playerScore);
        if(_playerScore >= 10)
    {
      DeclareWinner("PLAYER WIN");
    }
    else
    {
       ResetEverything(); 
    }
      
    }

    public void TotalComputerScore()
    {
        _computerScore++;
        this.computerScore.text = _computerScore.ToString();
        Debug.Log(_computerScore);
        if(_computerScore >= 10)
    {
      DeclareWinner("BOT WIN");

    }
     else {
        ResetEverything();
        }
    }

   private void DeclareWinner(string winnerMsg)
  {
    gameOverPanel.SetActive(true);
    winner.text = winnerMsg;
    Time.timeScale = 0f;
  }

  public void GoToMainMenu()
  {
    Time.timeScale = 1f;
    SceneManager.LoadScene("MainMenuScene");
  }

  public void CloseGame()
  {
    Debug.Log("Exit Game");
    Application.Quit();

  }
    private void ResetEverything()
    {
        this.playerpaddle.ResetPosition();
        this.computerpaddle.ResetPosition();
        this.Ball.ResetPosition();
        this.Ball.startforce();

    }
}
