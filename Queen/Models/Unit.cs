using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Queen.Models
{
    public class EnemyCalc
    {
      private int _xcoordopp;
      public int Xcoordopp
      {
        get { return _xcoordopp; }
        set { _xcoordopp = value; }
      }
      private int _ycoordopp;
      public int Ycoordopp
      {
        get { return _ycoordopp; }
        set { _ycoordopp = value; }
      } public int GetXCoordE()
    {
      return _xcoordopp;
    }

    public int GetYCoordE()
    {
      return _ycoordopp;
    }


      public EnemyCalc(int xCoordOpp, int yCoordOpp)
      {
        _xcoordopp = xCoordOpp;
        _ycoordopp = yCoordOpp;
      }
    }
}