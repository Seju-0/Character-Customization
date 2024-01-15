using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShirtManagerBoy : MonoBehaviour
{
    public SpriteRenderer shirtRenderer;
    public SpriteRenderer shortRenderer;
    public SpriteRenderer hatRenderer;

    public Sprite[] shirtSprites;
    public Sprite[] shortSprites;
    public Sprite[] hatSprites;

    private int currentShirtIndex = 0;
    private int currentShortIndex = 0;
    private int currentHatIndex = 0;

    void Start()
    {
        UpdateShirtSprite();
        UpdateShortSprite();
        UpdateHatSprite();
    }

    public void ChangeShirt()
    {
        currentShirtIndex = (currentShirtIndex + 1) % shirtSprites.Length;

        UpdateShirtSprite();
    }

    public void ChangeShort()
    {
        
        currentShortIndex = (currentShortIndex + 1) % shirtSprites.Length;

        UpdateShortSprite();
    }
    public void ChangeHat()
    {

        currentHatIndex = (currentHatIndex + 1) % hatSprites.Length;

        UpdateHatSprite();
    }

    private void UpdateShirtSprite()
    {
        if (shirtSprites.Length > 0)
        {
            shirtRenderer.sprite = shirtSprites[currentShirtIndex];
        }
    }
    private void UpdateShortSprite()
    {
        if (shortSprites.Length > 0)
        {
            shortRenderer.sprite = shortSprites[currentShortIndex];
        }
    }
    private void UpdateHatSprite()
    {
        if (hatSprites.Length > 0)
        {
            hatRenderer.sprite = hatSprites[currentHatIndex];
        }
    }
}
