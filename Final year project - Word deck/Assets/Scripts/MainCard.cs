using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCard : MonoBehaviour
{
    //GameObject gameControl;
    SpriteRenderer spriteRenderer;
    public Sprite[] faces;
    public Sprite back;
    public int faceIndex;
    public bool matched = false;

    public void OnMouseDown()
    {
        if (matched == false)
        {
            if (spriteRenderer.sprite == back) //flipping the card
            {
                /*if (gameControl.GetComponent<GameControl>().TwoCardsUp() == false)
                {
                    spriteRenderer.sprite = faces[faceIndex];
                    gameControl.GetComponent<GameControl>().AddVisibleFace(faceIndex);
                    matched = gameControl.GetComponent<GameControl>().CheckMatch();
                }*/
            }
            else
            {
                spriteRenderer.sprite = back;
                //gameControl.GetComponent<GameControl>().RemoveVisibleFace(faceIndex);
            }
        }
    }

    private void Awake() //initializing at start
    {
        //gameControl = GameObject.Find("GameControl");
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
