using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardModel : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite[] faces;
    public Sprite cardBack;

    public int cardIndex; // index of card face

    public void ToggleFace(bool showFace) {
        if (showFace)
        {
            spriteRenderer.sprite = faces[cardIndex]; // show card face
        }
        else {
            spriteRenderer.sprite = cardBack;  // show card back
        }
    }

    void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
