using UnityEngine;

public class paddles : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;
   [SerializeField] public float speed = 10f;
    protected virtual void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
}
