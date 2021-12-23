using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public GameObject parentPuzzle;
    public GameObject textPanel;
    public Rigidbody2D puzzleRb;
    public bool isPuzzleSolved = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PiecesScript.remaining <= 0 && !isPuzzleSolved)
        {
            parentPuzzle.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            textPanel.gameObject.SetActive(true);
        }
        if(parentPuzzle.transform.position.y < -50)
        {
            parentPuzzle.gameObject.SetActive(false);
        }
    }
}
