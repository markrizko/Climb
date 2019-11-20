using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugChangeCard : MonoBehaviour
{
    CardFlipper flipper;
    CardModel cardModel;
    int cardIndex = 0;

    public GameObject card;

    void Awake()
    {
        cardModel = card.GetComponent<CardModel>();
        flipper = card.GetComponent<CardFlipper>();
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 28), "Hit me!"))
        {
            

            if (cardIndex > 51)
            {
                cardIndex = 0;
                flipper.flipCard(cardModel.faces[51], cardModel.cardBack, -1);
            }
            else {
                if (cardIndex > 0)
                {
                    flipper.flipCard(cardModel.faces[cardIndex - 1], cardModel.faces[cardIndex], cardIndex);
                }
                else {
                    flipper.flipCard(cardModel.cardBack, cardModel.faces[cardIndex], cardIndex);
                }

                cardIndex++;
            }
            
            

            
        }
    }
}
