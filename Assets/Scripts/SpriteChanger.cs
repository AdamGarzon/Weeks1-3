using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public List<Sprite> barrels;
    public int randomNumber; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //PickARandomColour();
        //spriteRenderer.sprite = mySprite;
        PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
           if (Keyboard.current.anyKey.wasPressedThisFrame == true)
           {

           
            if (barrels.Count > 0)
            {
                PickARandomSprite();
            }
            // PickARandomColour();
            PickARandomSprite();
           }

        //get the mouse position
      Vector2 mousePos =  Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is the mouse over the sprite?
        if (spriteRenderer.bounds.Contains(mousePos) == true)
        {
            //Y; set the colour to our col variable
            spriteRenderer.color = col;
        }
        else 
        {
            spriteRenderer.color = Color.white;
        }

        if (Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count > 0)
        {
            barrels.RemoveAt(0);
        }

        //N; set the colour to white

    }

    void PickARandomColour() 
    {
        //spriteRenderer.color = Random.ColorHSV();
    }


    void PickARandomSprite()
    {
        //pick a random number
        randomNumber = UnityEngine.Random.Range(0, barrels.Count);



        spriteRenderer.sprite = barrels[randomNumber];
      /*  if (randomNumber == 0)
        {
            spriteRenderer.sprite = barrel0;
        }
        else if (RandomNumber == 1)
        {
            spriteRenderer.sprite = barrel1;
        }
        else if (RandomNumber == 2) 
        {
            spriteRenderer.sprite = barrel2;
        }
      */
    }
}
