using UnityEngine;

public class BgMusic : MonoBehaviour
{
    private static BgMusic music;
    private void Awake()
    {
        if(music != null)
        {
            Destroy(gameObject);
        }
        else
        {
            music = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
