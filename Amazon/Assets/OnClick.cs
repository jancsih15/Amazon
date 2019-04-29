using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public int posX;
    public int posY;
    public GameManager gameManager;

    private void OnMouseDown()
    {
        if (this.GetComponent<Type>().type.clickAble)
        {
            gameManager.MovePlayer(posX, posY);
            Debug.Log("valami");
        }
    }
}


