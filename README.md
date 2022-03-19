# Toy-Robot

## Prerequisites 

.NET 6.0 

## How to Build

### Method A

Open the project in Visual Studio or Rider and hit build. Additionally you can run the unit tests and the application from within the IDE.


### Method B

Navigate to the solution directory in a CLI and type 'dotnet build'. Addtionally you can type 'dotnet test' for the unit tests.
In both cases I have also created a prebuilt version within the Release directory.

## Commands

- PLACE (X, Y, DIRECTION) - Places the robot at the X,Y position facing the direction (NORTH,EAST,SOUTH,WEST).
- PLACE (X, Y) - Allows you to place the robot again. This cannot be used until the first PLACE command has been used.
- MOVE - Moves the robot 1 step towards its direction.
- REPORT - This prints the current location and direction to the console.
- LEFT - Rotates the robot to the left changing its direction.
- RIGHT - Rotates the robot to the right changing its direction.
- EXIT - Exits the simulation.
