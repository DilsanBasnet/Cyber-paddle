
using UnityEngine;
using UnityEngine.EventSystems;

public class DeathZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent TriggerScore;
    private void OnCollisionEnter2D(Collision2D collision)
    {
    ball Ball = collision.gameObject.GetComponent<ball>();

    if(Ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.TriggerScore.Invoke(eventData);
        }    
    }

}
