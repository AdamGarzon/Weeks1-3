using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class FollowMe : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //mousPos.z = 0;
        transform.position = mousPos;
    }
}
