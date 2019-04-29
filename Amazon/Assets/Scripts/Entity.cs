using UnityEngine;

public class Entity {

    private int posX, posY;

    public Entity(int x, int y) {
        try {
            if (CheckCoords(x, y)) throw new System.Exception();
            this.posX = x;
            this.posY = y;
        } catch (System.Exception) {
            //Debug.LogError("Invalid coordinate on Entity generation!");
        }
    }

    private bool CheckCoords(int x, int y) {
        return x < 0 || x > 7 || y < 0 || y > 0;
    }
}
