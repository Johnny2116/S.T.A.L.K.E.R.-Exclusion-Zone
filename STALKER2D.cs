using System;

class MainClass {
  public static void Main (string[] args) {
    // TITLE SCREEN
      Console.WriteLine("S.T.A.L.K.E.R.: Exclusion Zone");
      // Start button initializes Game. Game ends when player wins, runs out of health, or hits ESC

    // GAME MAP
      // Rectangular plane in which the player can move around; Player cannot move past perimeter of rectangle
        // Randomly generated items,weapons, and armor on map
      // After certain period of time elapses, an "extraction zone" opens somewhere on map

    // HEAL ITEM 
      // When activated, restores player health in intervals of 5 points per second

    // WEAPONS
      // Deal an assigned damage value to entity over which the pointer is hovering
      // Have a certain amount of uses, after which they must be reloaded

    // ARMOR
      // May be equipped by player to absorb damage
      // Adds armor points on top of health points
      // When depleted, the armor will disappear

    // ENEMIES
      // Randomly spawn on game map
      // Health values range from 25 to 150. Enemy dies when health value hits zero
      // When within certain radius, they move towards player, dealing damage through contact, or attack from range
      // May drop items upon death

    // PLAYER 
      // Health value of 100 points
      // Spawns with a starting weapon and one healing item
      // Movement speed of x blocks per second
        // W,A,S,D to move around the MAP
      // Aim follows mouse pointer's position on the screen 
      // May pick up and use weapons items, and armor

    // VICTORY CONDITIONS
      // Player must remain in designated "extraction zone" for a minute, after which the game will end and return to start screen
    
  }
}