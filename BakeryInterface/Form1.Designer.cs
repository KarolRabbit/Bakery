﻿namespace BakeryInterface
{
    partial class Form1
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.shoppingBox = new System.Windows.Forms.GroupBox();
            this.navigationBox = new System.Windows.Forms.GroupBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.iceCreamButton = new System.Windows.Forms.Button();
            this.drinksButton = new System.Windows.Forms.Button();
            this.cakesButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.navigationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mainPanel.Controls.Add(this.shoppingBox);
            this.mainPanel.Controls.Add(this.navigationBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(784, 461);
            this.mainPanel.TabIndex = 0;
            // 
            // shoppingBox
            // 
            this.shoppingBox.ForeColor = System.Drawing.Color.White;
            this.shoppingBox.Location = new System.Drawing.Point(402, 12);
            this.shoppingBox.Name = "shoppingBox";
            this.shoppingBox.Size = new System.Drawing.Size(370, 440);
            this.shoppingBox.TabIndex = 1;
            this.shoppingBox.TabStop = false;
            this.shoppingBox.Text = "Szczegóły zamówienia";
            // 
            // navigationBox
            // 
            this.navigationBox.Controls.Add(this.contentPanel);
            this.navigationBox.Controls.Add(this.iceCreamButton);
            this.navigationBox.Controls.Add(this.drinksButton);
            this.navigationBox.Controls.Add(this.cakesButton);
            this.navigationBox.Controls.Add(this.ordersButton);
            this.navigationBox.ForeColor = System.Drawing.Color.White;
            this.navigationBox.Location = new System.Drawing.Point(12, 12);
            this.navigationBox.Name = "navigationBox";
            this.navigationBox.Size = new System.Drawing.Size(384, 440);
            this.navigationBox.TabIndex = 0;
            this.navigationBox.TabStop = false;
            this.navigationBox.Text = "Nawigacja";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.LightGray;
            this.contentPanel.Location = new System.Drawing.Point(16, 111);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(350, 310);
            this.contentPanel.TabIndex = 4;
            // 
            // iceCreamButton
            // 
            this.iceCreamButton.Image = global::BakeryInterface.Properties.Resources.iceCream;
            this.iceCreamButton.Location = new System.Drawing.Point(291, 19);
            this.iceCreamButton.Name = "iceCreamButton";
            this.iceCreamButton.Size = new System.Drawing.Size(75, 75);
            this.iceCreamButton.TabIndex = 3;
            this.iceCreamButton.UseVisualStyleBackColor = true;
            // 
            // drinksButton
            // 
            this.drinksButton.Image = global::BakeryInterface.Properties.Resources.drink;
            this.drinksButton.Location = new System.Drawing.Point(201, 19);
            this.drinksButton.Name = "drinksButton";
            this.drinksButton.Size = new System.Drawing.Size(75, 75);
            this.drinksButton.TabIndex = 2;
            this.drinksButton.UseVisualStyleBackColor = true;
            this.drinksButton.Click += new System.EventHandler(this.drinksButton_Click);
            // 
            // cakesButton
            // 
            this.cakesButton.Image = global::BakeryInterface.Properties.Resources.cake;
            this.cakesButton.Location = new System.Drawing.Point(110, 19);
            this.cakesButton.Name = "cakesButton";
            this.cakesButton.Size = new System.Drawing.Size(75, 75);
            this.cakesButton.TabIndex = 1;
            this.cakesButton.UseVisualStyleBackColor = true;
            this.cakesButton.Click += new System.EventHandler(this.cakesButton_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.Image = global::BakeryInterface.Properties.Resources.orderList;
            this.ordersButton.Location = new System.Drawing.Point(16, 19);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(75, 75);
            this.ordersButton.TabIndex = 0;
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.navigationBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox shoppingBox;
        private System.Windows.Forms.GroupBox navigationBox;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Button cakesButton;
        private System.Windows.Forms.Button drinksButton;
        private System.Windows.Forms.Button iceCreamButton;
        private System.Windows.Forms.Panel contentPanel;
    }
}

