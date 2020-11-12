namespace BakeryInterface
{
    partial class Orders
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
            this.orderList = new System.Windows.Forms.ListBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.tableBox = new System.Windows.Forms.GroupBox();
            this.tableNumber = new System.Windows.Forms.TextBox();
            this.tableBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderList
            // 
            this.orderList.FormattingEnabled = true;
            this.orderList.Location = new System.Drawing.Point(30, 15);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(285, 225);
            this.orderList.TabIndex = 0;
            // 
            // addOrderButton
            // 
            this.addOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addOrderButton.ForeColor = System.Drawing.Color.White;
            this.addOrderButton.Location = new System.Drawing.Point(171, 252);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(144, 46);
            this.addOrderButton.TabIndex = 1;
            this.addOrderButton.Text = "Nowe zamówienie";
            this.addOrderButton.UseVisualStyleBackColor = false;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // tableBox
            // 
            this.tableBox.Controls.Add(this.tableNumber);
            this.tableBox.Location = new System.Drawing.Point(30, 246);
            this.tableBox.Name = "tableBox";
            this.tableBox.Size = new System.Drawing.Size(135, 52);
            this.tableBox.TabIndex = 2;
            this.tableBox.TabStop = false;
            this.tableBox.Text = "nr stolika";
            // 
            // tableNumber
            // 
            this.tableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableNumber.Location = new System.Drawing.Point(21, 20);
            this.tableNumber.Name = "tableNumber";
            this.tableNumber.Size = new System.Drawing.Size(93, 22);
            this.tableNumber.TabIndex = 0;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 310);
            this.Controls.Add(this.tableBox);
            this.Controls.Add(this.addOrderButton);
            this.Controls.Add(this.orderList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.Text = "Orders";
            this.tableBox.ResumeLayout(false);
            this.tableBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox orderList;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.GroupBox tableBox;
        private System.Windows.Forms.TextBox tableNumber;
    }
}