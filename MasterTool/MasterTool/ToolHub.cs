﻿using MasterTool.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterTool
{
    public partial class ToolHub : Form
    {
        public ToolHub()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ItemDefinitions_Click(object sender, EventArgs e)
        {
            ItemDefinitionsTool itemScreen = new ItemDefinitionsTool();

            itemScreen.ShowDialog(this);
        }

        private void MovementTypes_Click(object sender, EventArgs e)
        {
            MovementTypesTool movementScreen = new MovementTypesTool();

            movementScreen.ShowDialog(this);
        }

        private void PlayerTemplates_Click(object sender, EventArgs e)
        {
            PlayerTemplatesTool playerScreen = new PlayerTemplatesTool();

            playerScreen.ShowDialog(this);
        }

        private void EnemyDefinitions_Click(object sender, EventArgs e)
        {
            EnemyDefinitionsTool enemyScreen = new EnemyDefinitionsTool();

            enemyScreen.ShowDialog(this);
        }

        private void WeaponTypes_Click(object sender, EventArgs e)
        {
            WeaponTypesTool weaponScreen = new WeaponTypesTool();

            weaponScreen.ShowDialog(this);
        }

        private void TileTypes_Click(object sender, EventArgs e)
        {
            TileTypesTool tileScreen = new TileTypesTool();

            tileScreen.ShowDialog(this);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DataStorage.Save();
        }
    }
}