using Queen.Models;
using System.Collections.Generic;
using System;
using System.Data;

namespace Queen.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void RowCheck_CheckIfOppIsInSameRow_Bool()
    {

        EnemyCalc enemyLocation = new EnemyCalc(3, 4);
        QueenCalc queenLocation = new QueenCalc(8, 4, enemyLocation);
   
        bool sameRow = queenLocation.CheckRow();
        Assert.AreEqual(false, sameRow);
    }
    [TestMethod]
    public void ColCheck_CheckIfOppIsInSameCol_Bool()
    {
        EnemyCalc enemyLocation = new EnemyCalc(3, 4);
        QueenCalc queenLocation = new QueenCalc(8, 4, enemyLocation);
        
        bool sameCol = queenLocation.CheckCol();
        Assert.AreEqual(true, sameCol);
    }
    [TestMethod]

    public void DiagonalCheck_CheckIsOppIsDiagonal_Bool()
    {
        EnemyCalc enemyLocation = new EnemyCalc(3, 3);
        QueenCalc queenLocation = new QueenCalc(1, 1, enemyLocation);

        bool sameDiag = queenLocation.CheckDiagonal();
        Assert.AreEqual(true, sameDiag);
    }
}