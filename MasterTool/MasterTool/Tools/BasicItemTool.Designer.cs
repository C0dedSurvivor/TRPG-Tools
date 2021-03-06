﻿namespace MasterTool.Tools
{
    partial class BasicItemTool
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
            this.itemList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maxStackCount = new System.Windows.Forms.NumericUpDown();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sellPriceCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.flavorTextBox = new System.Windows.Forms.RichTextBox();
            this.addItem = new System.Windows.Forms.Button();
            this.removeItem = new System.Windows.Forms.Button();
            this.backPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.maxStackCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellPriceCount)).BeginInit();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            this.itemList.ItemHeight = 16;
            this.itemList.Location = new System.Drawing.Point(0, 0);
            this.itemList.Margin = new System.Windows.Forms.Padding(4);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(116, 276);
            this.itemList.TabIndex = 0;
            this.itemList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // maxStackCount
            // 
            this.maxStackCount.Location = new System.Drawing.Point(79, 58);
            this.maxStackCount.Margin = new System.Windows.Forms.Padding(4);
            this.maxStackCount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maxStackCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxStackCount.Name = "maxStackCount";
            this.maxStackCount.Size = new System.Drawing.Size(160, 22);
            this.maxStackCount.TabIndex = 2;
            this.maxStackCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(56, 14);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(132, 22);
            this.nameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max Stack";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sell Price";
            // 
            // sellPriceCount
            // 
            this.sellPriceCount.Location = new System.Drawing.Point(77, 101);
            this.sellPriceCount.Margin = new System.Windows.Forms.Padding(4);
            this.sellPriceCount.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.sellPriceCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sellPriceCount.Name = "sellPriceCount";
            this.sellPriceCount.Size = new System.Drawing.Size(160, 22);
            this.sellPriceCount.TabIndex = 5;
            this.sellPriceCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Flavor Text";
            // 
            // flavorTextBox
            // 
            this.flavorTextBox.DetectUrls = false;
            this.flavorTextBox.Location = new System.Drawing.Point(5, 160);
            this.flavorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.flavorTextBox.Name = "flavorTextBox";
            this.flavorTextBox.Size = new System.Drawing.Size(232, 117);
            this.flavorTextBox.TabIndex = 8;
            this.flavorTextBox.Text = "";
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(0, 278);
            this.addItem.Margin = new System.Windows.Forms.Padding(4);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(59, 28);
            this.addItem.TabIndex = 9;
            this.addItem.Text = "+";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // removeItem
            // 
            this.removeItem.Location = new System.Drawing.Point(59, 278);
            this.removeItem.Margin = new System.Windows.Forms.Padding(4);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(59, 28);
            this.removeItem.TabIndex = 10;
            this.removeItem.Text = "-";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.nameBox);
            this.backPanel.Controls.Add(this.label1);
            this.backPanel.Controls.Add(this.flavorTextBox);
            this.backPanel.Controls.Add(this.maxStackCount);
            this.backPanel.Controls.Add(this.label4);
            this.backPanel.Controls.Add(this.label2);
            this.backPanel.Controls.Add(this.label3);
            this.backPanel.Controls.Add(this.sellPriceCount);
            this.backPanel.Location = new System.Drawing.Point(125, 1);
            this.backPanel.Margin = new System.Windows.Forms.Padding(4);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(251, 305);
            this.backPanel.TabIndex = 11;
            // 
            // BasicItemTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.removeItem);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.backPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BasicItemTool";
            this.Text = "Item Definitions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BasicItemTool_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.maxStackCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellPriceCount)).EndInit();
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown maxStackCount;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sellPriceCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox flavorTextBox;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button removeItem;
        public System.Windows.Forms.ListBox itemList;
        private System.Windows.Forms.Panel backPanel;
    }
}