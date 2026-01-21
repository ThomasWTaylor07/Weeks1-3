using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public Sprite[] barrels = new Sprite[3];
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
            //PickARandomColor();
            PickARandomSprite();

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

    }
    void PickARandomColor()
    {
        spriteRenderer.color = Random.ColorHSV();

    }
    void PickARandomSprite()
    {
        //get a random number between 0 and 2
        randomNumber = Random.Range(0, barrels.Length);
        //use that to set the script 
        spriteRenderer.sprite = barrels[randomNumber];

    }
}