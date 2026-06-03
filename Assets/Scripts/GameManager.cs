using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gamemanager : MonoBehaviour
{
  private int _playerScore;
  private int _computerScore;
  public ball Ball;
  public TextMeshProUGUI playerScore;
  public TextMeshProUGUI computerScore;
  public paddles playerpaddle;
  public paddles computerpaddle;


  public void TotalPlayerScore()
    {
        _playerScore++;
        this.playerScore.text = _playerScore.ToString();
        Debug.Log(_playerScore);
      ResetEverything(); 
        
    }
    public void TotalComputerScore()
    {
        _computerScore++;
        this.computerScore.text = _computerScore.ToString();
        Debug.Log(_computerScore);
        ResetEverything();
    }
    private void ResetEverything()
    {
        this.playerpaddle.ResetPosition();
        this.computerpaddle.ResetPosition();
        this.Ball.ResetPosition();
        this.Ball.startforce();

    }
}
