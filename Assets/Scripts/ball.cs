using UnityEngine;

public class ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    [SerializeField] public float speed =199f;
    public SpriteRenderer spriteRenderer;
    public Sprite[] ballskins;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        int saveskin = PlayerPrefs.GetInt("SelectBallSkin", 0);
        if(ballskins != null && saveskin < ballskins.Length && ballskins[saveskin] != null)
        {
            spriteRenderer.sprite = ballskins[saveskin];
        }
        ResetPosition();
        startforce();
    }
     public void ResetPosition()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.linearVelocity = Vector3.zero;
    }
    public void startforce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) 
        : Random.Range(0.5f, 1.0f);

    Vector2 direction = new Vector2(x,y);
_rigidbody.AddForce(direction * this.speed);
    }
    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }
    
}
