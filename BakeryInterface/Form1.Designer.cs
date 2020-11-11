namespace BakeryInterface
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
            this.navigationBox = new System.Windows.Forms.GroupBox();
            this.shoppingBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.navigationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Info;
            this.mainPanel.Controls.Add(this.shoppingBox);
            this.mainPanel.Controls.Add(this.navigationBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(784, 461);
            this.mainPanel.TabIndex = 0;
            // 
            // navigationBox
            // 
            this.navigationBox.Controls.Add(this.button1);
            this.navigationBox.Location = new System.Drawing.Point(12, 12);
            this.navigationBox.Name = "navigationBox";
            this.navigationBox.Size = new System.Drawing.Size(370, 440);
            this.navigationBox.TabIndex = 0;
            this.navigationBox.TabStop = false;
            this.navigationBox.Text = "Nawigacja";
            // 
            // shoppingBox
            // 
            this.shoppingBox.Location = new System.Drawing.Point(402, 12);
            this.shoppingBox.Name = "shoppingBox";
            this.shoppingBox.Size = new System.Drawing.Size(370, 440);
            this.shoppingBox.TabIndex = 1;
            this.shoppingBox.TabStop = false;
            this.shoppingBox.Text = "Szczegóły zamówienia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button button1;
    }
}

