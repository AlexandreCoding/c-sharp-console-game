using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {

// Update position of player cursor by coordinates
// 
// Parameters: last key pressed by player, out X coordinate and out Y coordinate of player position.
// Doesn't return anything, void.

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

// Update cursor character by the orientation of last key input
// 
// Parameters: last key pressed by player.
// Returns a new char value if player has changed the direction of movement.

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

// Console limits applied so player cursor cannot go to negative coords or higher coords than a maxValue
// 
// Parameters: Coord to compare and the highest value player will be able to reach.
// Returns a new int value if player is trying to get to unreachable coordinaaes.

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

// Checks if player reached the fruit/goal position.
//
// Parameters: X coords and Y coords for player cursor position and fruit/goal position.
// Returns true if player coords and fruit coords are equal otherwise returns false.

  public new static bool DidScore (int xPlayer, int yPlayer, int xFruit, int yFruit) {
    if ((xPlayer == xFruit) && (yPlayer == yFruit)) {
      return true;
    } else {
      return false;
    }
  }
}
}