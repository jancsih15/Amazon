using UnityEngine;

public enum EntityType { Blue, Red, Fire }

public class Entity {

    private Position position;
    private EntityType entityType;

    public Position Position { get; set; }
    public EntityType GetEntityType() => entityType;

    public Entity(Position position, EntityType entityType) {
        this.position = position;
        this.entityType = entityType;
    }
}
