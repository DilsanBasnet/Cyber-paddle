using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void Play()
    {
        SceneManager.LoadScene("CyberPaddleScene");
    } 
    public void SetBallskin(int skinIndex)
    {
        PlayerPrefs.SetInt("SelectBallSkin", skinIndex);
        PlayerPrefs.Save();

    }
}
