using UnityEngine;
using UnityEngine.Windows.Speech;

public class FirstScript : MonoBehaviour
{
    float speed = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = transform.position;
        newPosition.x += speed;
        transform.position = newPosition;

        //check if position.x < 0 or positio.x > width of the screen
        //Y: multiply speed by -1
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPos.x < 0 || screenPos.x > Screen.width) 
        {
            speed = speed * -1;
        }
    }
}
