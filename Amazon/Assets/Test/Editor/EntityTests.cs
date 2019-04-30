using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityTests {

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
        Board board = new Board();
        Assert.AreEqual(64, board.GetGrid().Length);
    }
}
