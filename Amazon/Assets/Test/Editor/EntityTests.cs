using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityTests {

    public bool ThrowsExceptionOnConstruction(int x, int y) {
        try {
            new Entity(x, y);
            return false;
        } catch (System.Exception) {
            return true;
        }
    }

    [Test]
    public void EntityConstructTest() {
        Assert.False(ThrowsExceptionOnConstruction(0, 0));
        Assert.False(ThrowsExceptionOnConstruction(7, 7));
        Assert.True(ThrowsExceptionOnConstruction(12, 0));
        Assert.True(ThrowsExceptionOnConstruction(3, 53));
        Assert.True(ThrowsExceptionOnConstruction(12, 53));
        Assert.True(ThrowsExceptionOnConstruction(4, -20));
    }
}
