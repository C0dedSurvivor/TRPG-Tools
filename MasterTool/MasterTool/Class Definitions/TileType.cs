﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterTool.Tools
{
    class TileType
    {
        public string Name
        {
            get
            {
                return name;
            }
        }

        public string name;
        public string flavorText;
        public SkillPartBase startOfTurn;
        public SkillPartBase passOver;
        public SkillPartBase stopOnTile;
        public SkillPartBase endOfTurn;

        public TileType(string name, string flavorText)
        {
            this.name = name;
            this.flavorText = flavorText;
        }
    }
}