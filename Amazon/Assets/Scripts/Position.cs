
public class Position {

    private int posX, posY;

    public int GetX() => posX;
    public int GetY() => posY;

    public Position(int x, int y) {
        if (WrongCoordinte(x, y)) throw new System.Exception();
        this.posX = x;
        this.posY = y;
    }

    private bool WrongCoordinte(int x, int y) {
        return x < 0 || x > 7 || y < 0 || y > 7;
    }
}
