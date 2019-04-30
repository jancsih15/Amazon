using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardBehaviour : MonoBehaviour {

    private Board board;
    private Cell[] cells;

    private void Awake() {
        board = new Board();
        cells = GetComponentsInChildren<Cell>();
    }

    private void Update() {
        SyncBoardAndCells();
    }

    private void SyncBoardAndCells() {
        Entity[] entities = new Entity[cells.Length];
        int k = 0;
        for (int i = 0; i < board.GetGrid().GetLength(0); i++) {
            for (int j = 0; j < board.GetGrid().GetLength(1); j++) {
                entities[k++] = board.GetGrid()[i, j];
            }
        }
        for (int i = 0; i < cells.Length; i++) {
            cells[i].Entity = entities[i];
        }
    }
}

public class Board {

    private Entity[,] grid;

    public Entity[,] GetGrid() {
        return grid;
    }

    public Board() {
        grid = new Entity[8, 8];
        Entity entity = new Entity(EntityType.Blue);
        PlaceEntity(entity, new Position(0, 0));
    }

    public void PlaceEntity(Entity entity, Position targetPosition) {
        int x = targetPosition.GetX();
        int y = targetPosition.GetY();
        if (grid[x, y] == null) {
            entity.Position = targetPosition;
            grid[x, y] = entity;
        } else {
            throw new System.Exception();
        }
    }

    public void MoveEntity(Entity entity, Position targetPosition) {
        int x = targetPosition.GetX();
        int y = targetPosition.GetY();
        if (grid[x, y] != null) throw new System.Exception();
        grid[x, y] = entity;
        x = entity.Position.GetX();
        y = entity.Position.GetY();
        grid[x, y] = null;
    }
}
