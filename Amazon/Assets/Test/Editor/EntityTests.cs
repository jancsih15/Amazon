using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityTests {

    private Board board;

    [SetUp]
    public void SetupBoard() {
        board = new Board();
    }

    [Test]
    [TestCase(0, 0)]
    [TestCase(7, 7)]
    public void NewPositionCorrectTest(int x, int y) {
        bool correct;
        try {
            new Position(x, y);
            correct = true;
        } catch (System.Exception) {
            correct = false;
        }
        Assert.True(correct);
    }

    [Test]
    [TestCase(5, 12)]
    [TestCase(12, 5)]
    [TestCase(-2, 5)]
    [TestCase(-2, -2)]
    public void NewPositionThrowsTest(int x, int y) {
        bool correct;
        try {
            new Position(x, y);
            correct = true;
        } catch (System.Exception) {
            correct = false;
        }
        Assert.False(correct);
    }

    [Test]
    public void BoardLengthTest() {
        Assert.AreEqual(64, board.GetGrid().Length);
    }

    [Test]
    public void PlaceEntityToOccupiedSpotTest() {
        bool correct;
        try {
            Entity entity = new Entity(EntityType.Blue);
            entity.Position = new Position(0, 0);
            board.PlaceEntity(entity, entity.Position);
            board.PlaceEntity(entity, entity.Position);
            correct = true;
        } catch (System.Exception) {
            correct = false;
        }
        Assert.False(correct);
    }

    [Test]
    public void MoveEntityToOccupiedSpot() {
        bool correct;
        try {
            Entity entity1 = new Entity(EntityType.Blue);
            entity1.Position = new Position(0, 0);
            Entity entity2 = new Entity(EntityType.Blue);
            entity2.Position = new Position(5, 0);
            board.PlaceEntity(entity1, entity1.Position);
            board.PlaceEntity(entity2, entity2.Position);
            board.MoveEntity(entity2, entity1.Position);
            correct = true;
        } catch (System.Exception) {
            correct = false;
        }
        Assert.False(correct);
    }
}
