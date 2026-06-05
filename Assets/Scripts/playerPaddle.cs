
using UnityEngine;
using UnityEngine.InputSystem;

public class playerPaddle : paddles
{
   private Vector2 _direction;
    private void Update()
     {
        Keyboard currentkeyboard = Keyboard.current;

        if(currentkeyboard == null) return;
    bool upPressed = currentkeyboard.wKey.isPressed || currentkeyboard.upArrowKey.isPressed;
    bool downpressed = currentkeyboard.sKey.isPressed || currentkeyboard.downArrowKey.isPressed;

    if(upPressed)
        {
            _direction = Vector2.up;

        } 
        else if(downpressed)
        {
            _direction = Vector2.down;
        } else
        {
            _direction = Vector2.zero;
        }

    }
    private void FixedUpdate()
    {
        if(_direction.sqrMagnitude != 0)
        {
            _rigidbody.linearVelocity = _direction * this.speed;
        }
        else
        {
            _rigidbody.linearVelocity = Vector2.zero;
        }
    }
}

 
