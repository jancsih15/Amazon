using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public int posX;
    public int posY;
    public GameManager gameManager;
    public bool Moving = true;

    private void OnMouseDown()
    {
        if (this.GetComponent<Type>().type.clickable & Moving)
        {
            gameManager.MovePlayer(posX, posY);
            Debug.Log("valami");
        }
        //else if (this.GetComponent<Type>().type.clickable && !Moving)
        //{
        //    //gameManager.FireArrow(posX, posY);
        //    Debug.Log("arrow");
        //}
    }

    //private void OnValidate()
    //{
            
    //}


}


