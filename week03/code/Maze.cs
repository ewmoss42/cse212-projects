/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then display "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze {
    private readonly Dictionary<(int, int), bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<(int, int), bool[]> mazeMap) {
        _mazeMap = mazeMap;
    }

    public void MoveLeft() {
        if (_mazeMap.ContainsKey((_currX, _currY)) && _mazeMap[(_currX, _currY)][0] && _mazeMap.ContainsKey((_currX - 1, _currY)) && _mazeMap[(_currX - 1, _currY)][1]) {
            _currX--;
        } else {
            Console.WriteLine("Can't go that way!");
        }
    }

    public void MoveRight() {
        if (_mazeMap.ContainsKey((_currX, _currY)) && _mazeMap[(_currX, _currY)][1] && _mazeMap.ContainsKey((_currX + 1, _currY)) && _mazeMap[(_currX + 1, _currY)][0]) {
            _currX++;
        } else {
            Console.WriteLine("Can't go that way!");
        }
    }

    public void MoveUp() {
        if (_mazeMap.ContainsKey((_currX, _currY)) && _mazeMap[(_currX, _currY)][2] && _mazeMap.ContainsKey((_currX, _currY - 1)) && _mazeMap[(_currX, _currY - 1)][3]) {
            _currY--;
        } else {
            Console.WriteLine("Can't go that way!");
        }
    }

    public void MoveDown() {
        if (_mazeMap.ContainsKey((_currX, _currY)) && _mazeMap[(_currX, _currY)][3] && _mazeMap.ContainsKey((_currX, _currY + 1)) && _mazeMap[(_currX, _currY + 1)][2]) {
            _currY++;
        } else {
            Console.WriteLine("Can't go that way!");
        }
    }

    public void ShowStatus() {
        Console.WriteLine($"Current location (x={_currX}, y={_currY})");
    }
}