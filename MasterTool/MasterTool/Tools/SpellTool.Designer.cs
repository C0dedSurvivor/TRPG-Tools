﻿namespace MasterTool.Tools
{
    partial class SpellTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.removeEffect = new System.Windows.Forms.Button();
            this.addEffect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.effectList = new System.Windows.Forms.ListBox();
            this.targetType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flavorTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.removeSpell = new System.Windows.Forms.Button();
            this.addSpell = new System.Windows.Forms.Button();
            this.spellList = new System.Windows.Forms.ListBox();
            this.castCost = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.unlockLevel = new System.Windows.Forms.NumericUpDown();
            this.unlockCost = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.targetRange = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.aoeX = new System.Windows.Forms.NumericUpDown();
            this.aoeY = new System.Windows.Forms.NumericUpDown();
            this.dependencyList = new System.Windows.Forms.CheckedListBox();
            this.backPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.castCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unlockLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unlockCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoeY)).BeginInit();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // removeEffect
            // 
            this.removeEffect.Location = new System.Drawing.Point(345, 268);
            this.removeEffect.Margin = new System.Windows.Forms.Padding(1);
            this.removeEffect.Name = "removeEffect";
            this.removeEffect.Size = new System.Drawing.Size(77, 28);
            this.removeEffect.TabIndex = 41;
            this.removeEffect.Text = "-";
            this.removeEffect.UseVisualStyleBackColor = true;
            this.removeEffect.Click += new System.EventHandler(this.removeEffect_Click);
            // 
            // addEffect
            // 
            this.addEffect.Location = new System.Drawing.Point(261, 268);
            this.addEffect.Margin = new System.Windows.Forms.Padding(1);
            this.addEffect.Name = "addEffect";
            this.addEffect.Size = new System.Drawing.Size(76, 28);
            this.addEffect.TabIndex = 40;
            this.addEffect.Text = "+";
            this.addEffect.UseVisualStyleBackColor = true;
            this.addEffect.Click += new System.EventHandler(this.addEffect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Effects";
            // 
            // effectList
            // 
            this.effectList.FormattingEnabled = true;
            this.effectList.ItemHeight = 16;
            this.effectList.Location = new System.Drawing.Point(261, 105);
            this.effectList.Margin = new System.Windows.Forms.Padding(4);
            this.effectList.Name = "effectList";
            this.effectList.Size = new System.Drawing.Size(159, 164);
            this.effectList.TabIndex = 38;
            this.effectList.DoubleClick += new System.EventHandler(this.effectList_DoubleClick);
            // 
            // targetType
            // 
            this.targetType.FormattingEnabled = true;
            this.targetType.Items.AddRange(new object[] {
            "Self",
            "Ally",
            "Enemy",
            "All In Range",
            "All Allies",
            "All Allies Except Self",
            "All Enemies"});
            this.targetType.Location = new System.Drawing.Point(379, 14);
            this.targetType.Margin = new System.Windows.Forms.Padding(4);
            this.targetType.Name = "targetType";
            this.targetType.Size = new System.Drawing.Size(160, 24);
            this.targetType.TabIndex = 37;
            this.targetType.Text = "Self";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Targetting Type";
            // 
            // flavorTextBox
            // 
            this.flavorTextBox.DetectUrls = false;
            this.flavorTextBox.Location = new System.Drawing.Point(4, 161);
            this.flavorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.flavorTextBox.Name = "flavorTextBox";
            this.flavorTextBox.Size = new System.Drawing.Size(232, 117);
            this.flavorTextBox.TabIndex = 35;
            this.flavorTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Flavor Text";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(93, 15);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(132, 22);
            this.nameBox.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Name";
            // 
            // removeSpell
            // 
            this.removeSpell.Location = new System.Drawing.Point(63, 282);
            this.removeSpell.Margin = new System.Windows.Forms.Padding(4);
            this.removeSpell.Name = "removeSpell";
            this.removeSpell.Size = new System.Drawing.Size(59, 28);
            this.removeSpell.TabIndex = 31;
            this.removeSpell.Text = "-";
            this.removeSpell.UseVisualStyleBackColor = true;
            this.removeSpell.Click += new System.EventHandler(this.removeSpell_Click);
            // 
            // addSpell
            // 
            this.addSpell.Location = new System.Drawing.Point(4, 282);
            this.addSpell.Margin = new System.Windows.Forms.Padding(4);
            this.addSpell.Name = "addSpell";
            this.addSpell.Size = new System.Drawing.Size(59, 28);
            this.addSpell.TabIndex = 30;
            this.addSpell.Text = "+";
            this.addSpell.UseVisualStyleBackColor = true;
            this.addSpell.Click += new System.EventHandler(this.addSpell_Click);
            // 
            // spellList
            // 
            this.spellList.FormattingEnabled = true;
            this.spellList.ItemHeight = 16;
            this.spellList.Location = new System.Drawing.Point(4, 4);
            this.spellList.Margin = new System.Windows.Forms.Padding(4);
            this.spellList.Name = "spellList";
            this.spellList.Size = new System.Drawing.Size(116, 276);
            this.spellList.TabIndex = 29;
            this.spellList.SelectedIndexChanged += new System.EventHandler(this.spellList_SelectedIndexChanged);
            // 
            // castCost
            // 
            this.castCost.Location = new System.Drawing.Point(93, 47);
            this.castCost.Margin = new System.Windows.Forms.Padding(4);
            this.castCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.castCost.Name = "castCost";
            this.castCost.Size = new System.Drawing.Size(160, 22);
            this.castCost.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Cost";
            // 
            // unlockLevel
            // 
            this.unlockLevel.Location = new System.Drawing.Point(93, 79);
            this.unlockLevel.Margin = new System.Windows.Forms.Padding(4);
            this.unlockLevel.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.unlockLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.unlockLevel.Name = "unlockLevel";
            this.unlockLevel.Size = new System.Drawing.Size(160, 22);
            this.unlockLevel.TabIndex = 44;
            this.unlockLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // unlockCost
            // 
            this.unlockCost.Location = new System.Drawing.Point(93, 111);
            this.unlockCost.Margin = new System.Windows.Forms.Padding(4);
            this.unlockCost.Name = "unlockCost";
            this.unlockCost.Size = new System.Drawing.Size(160, 22);
            this.unlockCost.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Unlock Level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 113);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Unlock Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Targetting Range";
            // 
            // targetRange
            // 
            this.targetRange.Location = new System.Drawing.Point(379, 44);
            this.targetRange.Margin = new System.Windows.Forms.Padding(4);
            this.targetRange.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.targetRange.Name = "targetRange";
            this.targetRange.Size = new System.Drawing.Size(160, 22);
            this.targetRange.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(560, 2);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Area of Effect";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(560, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "X: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(560, 57);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 17);
            this.label11.TabIndex = 52;
            this.label11.Text = "Y: ";
            // 
            // aoeX
            // 
            this.aoeX.Location = new System.Drawing.Point(595, 23);
            this.aoeX.Margin = new System.Windows.Forms.Padding(4);
            this.aoeX.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.aoeX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aoeX.Name = "aoeX";
            this.aoeX.Size = new System.Drawing.Size(75, 22);
            this.aoeX.TabIndex = 53;
            this.aoeX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // aoeY
            // 
            this.aoeY.Location = new System.Drawing.Point(595, 54);
            this.aoeY.Margin = new System.Windows.Forms.Padding(4);
            this.aoeY.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.aoeY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aoeY.Name = "aoeY";
            this.aoeY.Size = new System.Drawing.Size(75, 22);
            this.aoeY.TabIndex = 54;
            this.aoeY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dependencyList
            // 
            this.dependencyList.FormattingEnabled = true;
            this.dependencyList.Location = new System.Drawing.Point(457, 105);
            this.dependencyList.Margin = new System.Windows.Forms.Padding(4);
            this.dependencyList.Name = "dependencyList";
            this.dependencyList.Size = new System.Drawing.Size(159, 174);
            this.dependencyList.TabIndex = 55;
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.dependencyList);
            this.backPanel.Controls.Add(this.label1);
            this.backPanel.Controls.Add(this.aoeY);
            this.backPanel.Controls.Add(this.nameBox);
            this.backPanel.Controls.Add(this.aoeX);
            this.backPanel.Controls.Add(this.label4);
            this.backPanel.Controls.Add(this.label11);
            this.backPanel.Controls.Add(this.flavorTextBox);
            this.backPanel.Controls.Add(this.label10);
            this.backPanel.Controls.Add(this.label5);
            this.backPanel.Controls.Add(this.label9);
            this.backPanel.Controls.Add(this.targetType);
            this.backPanel.Controls.Add(this.targetRange);
            this.backPanel.Controls.Add(this.effectList);
            this.backPanel.Controls.Add(this.label8);
            this.backPanel.Controls.Add(this.label6);
            this.backPanel.Controls.Add(this.label7);
            this.backPanel.Controls.Add(this.addEffect);
            this.backPanel.Controls.Add(this.label3);
            this.backPanel.Controls.Add(this.removeEffect);
            this.backPanel.Controls.Add(this.unlockCost);
            this.backPanel.Controls.Add(this.castCost);
            this.backPanel.Controls.Add(this.unlockLevel);
            this.backPanel.Controls.Add(this.label2);
            this.backPanel.Location = new System.Drawing.Point(129, 4);
            this.backPanel.Margin = new System.Windows.Forms.Padding(4);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(671, 306);
            this.backPanel.TabIndex = 56;
            // 
            // SpellTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 321);
            this.Controls.Add(this.removeSpell);
            this.Controls.Add(this.addSpell);
            this.Controls.Add(this.spellList);
            this.Controls.Add(this.backPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SpellTool";
            this.Text = "SpellTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpellTool_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.castCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unlockLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unlockCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoeY)).EndInit();
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button removeEffect;
        private System.Windows.Forms.Button addEffect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox effectList;
        private System.Windows.Forms.ComboBox targetType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox flavorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeSpell;
        private System.Windows.Forms.Button addSpell;
        public System.Windows.Forms.ListBox spellList;
        private System.Windows.Forms.NumericUpDown castCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown unlockLevel;
        private System.Windows.Forms.NumericUpDown unlockCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown targetRange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown aoeX;
        private System.Windows.Forms.NumericUpDown aoeY;
        private System.Windows.Forms.CheckedListBox dependencyList;
        private System.Windows.Forms.Panel backPanel;
    }
}