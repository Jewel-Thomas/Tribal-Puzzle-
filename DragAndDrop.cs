using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DragAndDrop : MonoBehaviour
{
    public GameObject correctForm;
    private bool moving;
    private float startPosX;
    private float startPosY;
    int OIL = 1;

    public GameObject selectedPiece;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(moving && !this.GetComponent<PiecesScript>().inRightPosition)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.GetComponent<SortingGroup>().sortingOrder = OIL;
            OIL++;

            this.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY,this.gameObject.transform.localPosition.z);
        }
         RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
         if(Input.GetMouseButtonDown(0))
         {
            
             if(hit.transform.CompareTag("Puzzle"))
             {
                 selectedPiece = hit.transform.gameObject;
             }
             if(Input.GetMouseButtonUp(0))
            {
                selectedPiece = null;
            }
             if(selectedPiece != null)
             {
                 Vector3 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                 selectedPiece.transform.position = new Vector3(mousePoint.x,mousePoint.y,0);
             }
        

         }
    }

    private void OnMouseDown()
    {
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        startPosX = mousePos.x - this.transform.localPosition.x;
        startPosY = mousePos.y - this.transform.localPosition.y;

        moving  = true;
    }

    private void OnMouseUp()
    {
        moving = false;
    }

}
