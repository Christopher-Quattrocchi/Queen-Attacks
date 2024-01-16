using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Queen.Models
{
  public class QueenCalc
  {
    private int _xcoord;
    public int Xcoord
    {
      get { return _xcoord; }
      set { _xcoord = value; }
    }
    private int _ycoord;
    public int Ycoord
    {
      get { return _ycoord; }
      set { _ycoord = value; }
    }

    private EnemyCalc _enemyCalc;

    public int GetXCoordQ()
    {
      return _xcoord;
    }

    public int GetYCoordQ()
    {
      return _ycoord;
    }

    public QueenCalc(int xcoord, int ycoord, EnemyCalc enemyCalc)
    {
      _xcoord = xcoord;
      _ycoord = ycoord;
      _enemyCalc = enemyCalc;
    }

    public bool CheckRow()
    {
      if (_enemyCalc != null && _xcoord == _enemyCalc.GetXCoordE())
      {
        return true;
      }
        return false;
    }
    public bool CheckCol()
    {
      if (_enemyCalc != null && _ycoord == _enemyCalc.GetYCoordE())
      {
        return true;
      }
      return false;
    }

    public bool CheckDiagonal() 
    {
      if (_enemyCalc != null && Math.Abs(_xcoord - _enemyCalc.GetXCoordE()) == Math.Abs(_ycoord - _enemyCalc.GetYCoordE())) 
      {
        return true;
      }
      return false;
    }
  }

}




