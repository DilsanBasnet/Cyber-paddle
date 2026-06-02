using UnityEngine;

public class Gamemanager : MonoBehaviour
{
  private int _playerScore;
  private int _computerScore;
  public ball Ball;

  public void TotalPlayerScore()
    {
        _playerScore++;
        this.Ball.ResetPosition();
    }
    public void TotalComputerScore()
    {
        _computerScore++;
        this.Ball.ResetPosition();
    }
}
