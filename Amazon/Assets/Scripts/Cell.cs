using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour {

    private Entity entity;

    public Entity Entity {
        get {
            return entity;
        }
        set {
            entity = value;
            if (entity != null) {
                switch (entity.GetEntityType()) {
                    case EntityType.Blue:
                        GetComponent<SpriteRenderer>().color = new Color(0, 0, 255);
                        break;
                    case EntityType.Red:
                        GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);
                        break;
                    case EntityType.Fire:
                        GetComponent<SpriteRenderer>().color = new Color(255, 255, 0);
                        break;
                }
            } else {
                GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
            }
        }
    }
}
