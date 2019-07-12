﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MovementType
{
    public string name;
    /// <summary>
    /// For each passable tile, say if it is limited movement.
    /// Limited movement means you cannot move into and over a tile of that type in the same move.
    /// </summary>
    public Dictionary<string, bool> passableTiles;
    public int moveSpeed;

    public MovementType(string name, Dictionary<string, bool> passableTiles, int moveSpeed)
    {
        this.name = name;
        this.passableTiles = passableTiles;
        this.moveSpeed = moveSpeed;
    }
}