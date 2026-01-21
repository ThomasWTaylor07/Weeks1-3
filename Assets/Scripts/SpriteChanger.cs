using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public List<Sprite> barrels;
    public int randomNumber = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColor();
        PickARandomSprite();



    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            Debug.Log("Try to change the sprite");
            //PickARandomColor();
            if (barrels.Count > 0)
            {
                PickARandomSprite();
            }
        }


        // Not this one spriteRenderer.sprite.bounds.Contains(mousePos); sprite is at 0,0
        // Use this: priteRenderer.bounds.Contains(mousePos) == true
        //Get the mouse position 
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //Is it over the sprite?
        if (spriteRenderer.bounds.Contains(mousePos) == true)
        {
            //Y: Use the col variable
            spriteRenderer.color = col;
        }
        else
        {
            //N: set the colour to white
            spriteRenderer.color = Color.white;

        }
        if(Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count > 0) 
        {
            barrels.RemoveAt(0);

        }
            

    }
    void PickARandomColor()
    {
        spriteRenderer.color = Random.ColorHSV();

    }
    void PickARandomSprite()
    {
        ////get a random number between 0 and 2
        randomNumber = Random.Range(0, barrels.Count);
        ////use that to set the script 
        spriteRenderer.sprite = barrels[randomNumber];

    }


}