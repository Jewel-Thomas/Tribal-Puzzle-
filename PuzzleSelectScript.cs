using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleSelectScript : MonoBehaviour
{
    public GameObject startPanel;
    public void setPuzzlesPhoto(Image photo)
    {
        for(int i = 0; i<36;i++)
        {
            GameObject.Find("Piece ("+i+")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite = photo.sprite;
        }
        startPanel.SetActive(false);
    }
}
