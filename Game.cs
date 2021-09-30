using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    public new static void UpdatePosition (string keyPressed, out int xCoord, out int yCoord) {
      yCoord = 0;
      xCoord= 0;
    switch (keyPressed) {
      case "DownArrow":
      yCoord++;
      xCoord += 0;
      break;
      case "UpArrow":
      yCoord--;
      xCoord += 0;
      break;
      case "LeftArrow":
      xCoord--;
      yCoord += 0;
      break;
      case "RightArrow":
      xCoord++;
      yCoord += 0;
      break;
      }
  }
  public new static char UpdateCursor (string keyPressed) {
    switch (keyPressed) {
      case "LeftArrow":
      return '<';
      case "RightArrow":
      return '>';
      case "UpArrow":
      return '^';
      case "DownArrow":
      return 'v';
      default:
      return 'v';
    }
  }

  public new static int KeepInBounds(int coord, int maxValue) {
    int newCoord;
      if (coord < 0) {
        newCoord = 0;
        return newCoord;
      } else if (coord >= maxValue) {
        newCoord = maxValue--;
        return newCoord;
      } else {
        newCoord = coord;
        return newCoord;
  }
  }

  public new static bool DidScore (int xPlayer, int yPlayer, int xFruit, int yFruit) {
    if ((xPlayer == xFruit) && (yPlayer == yFruit)) {
      return true;
    } else {
      return false;
    }
  }
}
}