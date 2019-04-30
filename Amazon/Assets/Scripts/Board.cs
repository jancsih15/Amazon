

public class Board {

    private Entity[,] cellGrid;

    public Entity[,] GetGrid() {
        return cellGrid;
    }

    public Board() {
        cellGrid = new Entity[8, 8];
    }

    public void PlaceEntity(Entity entity, Position targetPosition) {
        int x = targetPosition.GetX();
        int y = targetPosition.GetY();
        if (cellGrid[x, y] == null) {
            entity.Position = targetPosition;
            cellGrid[x, y] = entity;
        }
    }

    public void MoveEntity(Entity entity, Position targetPosition) {
        if (entity.GetEntityType() != EntityType.Fire) {
            int x = entity.Position.GetX();
            int y = entity.Position.GetY();
            cellGrid[x, y] = null;
            x = targetPosition.GetX();
            y = targetPosition.GetY();            
            cellGrid[x, y] = entity;
        }
    }
}
