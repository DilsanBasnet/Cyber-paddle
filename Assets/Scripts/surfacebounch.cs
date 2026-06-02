using UnityEngine;

public class surfacebounch : MonoBehaviour
{
   public float bounchpower;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ball Ball = collision.gameObject.GetComponent<ball>();
        if(Ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            Ball.AddForce(-normal * this.bounchpower);
        }
    }
}
