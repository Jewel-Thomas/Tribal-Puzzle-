using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.Rendering;

public class PiecesScript : MonoBehaviour
{

    public GameManagerScript gameManagerScript;
    private Vector3 rightPosition;
    public bool inRightPosition;
    public bool taken = false;
    [SerializeField]
    public static int remaining = 36;
    
    // Start is called before the first frame update
    void Start()
    {
        rightPosition = transform.position;
        
        transform.position = new Vector3(Random.Range(5f,11f),Random.Range(5.5f,-2f));
    }
    

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,rightPosition) < 1f)
        {
            if(!inRightPosition)
            {
                transform.position = rightPosition;
                inRightPosition = true;
                this.GetComponent<SortingGroup>().sortingOrder = 0;
                
            }
            
        }
        if(inRightPosition && !taken)
        {
            remaining--;
            taken = true;
        }
        


    }
}
