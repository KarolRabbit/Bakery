namespace BakeryInterface
{
    partial class Drinks
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
            this.coffeeBox = new System.Windows.Forms.GroupBox();
            this.radioMilkNo = new System.Windows.Forms.RadioButton();
            this.radioMilkYes = new System.Windows.Forms.RadioButton();
            this.milkChoice = new System.Windows.Forms.GroupBox();
            this.sizeCoffee = new System.Windows.Forms.GroupBox();
            this.bigCoffee = new System.Windows.Forms.RadioButton();
            this.smallCoffee = new System.Windows.Forms.RadioButton();
            this.coffeeSelect = new System.Windows.Forms.Button();
            this.teaBox = new System.Windows.Forms.GroupBox();
            this.teaSelect = new System.Windows.Forms.Button();
            this.sizeTea = new System.Windows.Forms.GroupBox();
            this.bigTea = new System.Windows.Forms.RadioButton();
            this.smallTea = new System.Windows.Forms.RadioButton();
            this.lemonChoice = new System.Windows.Forms.GroupBox();
            this.radioLemonNO = new System.Windows.Forms.RadioButton();
            this.radioLemonYes = new System.Windows.Forms.RadioButton();
            this.coffeeBox.SuspendLayout();
            this.milkChoice.SuspendLayout();
            this.sizeCoffee.SuspendLayout();
            this.teaBox.SuspendLayout();
            this.sizeTea.SuspendLayout();
            this.lemonChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // coffeeBox
            // 
            this.coffeeBox.Controls.Add(this.coffeeSelect);
            this.coffeeBox.Controls.Add(this.sizeCoffee);
            this.coffeeBox.Controls.Add(this.milkChoice);
            this.coffeeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coffeeBox.Location = new System.Drawing.Point(12, 12);
            this.coffeeBox.Name = "coffeeBox";
            this.coffeeBox.Size = new System.Drawing.Size(326, 82);
            this.coffeeBox.TabIndex = 0;
            this.coffeeBox.TabStop = false;
            this.coffeeBox.Text = "Kawa";
            // 
            // radioMilkNo
            // 
            this.radioMilkNo.AutoSize = true;
            this.radioMilkNo.ForeColor = System.Drawing.Color.Black;
            this.radioMilkNo.Location = new System.Drawing.Point(6, 39);
            this.radioMilkNo.Name = "radioMilkNo";
            this.radioMilkNo.Size = new System.Drawing.Size(44, 20);
            this.radioMilkNo.TabIndex = 2;
            this.radioMilkNo.TabStop = true;
            this.radioMilkNo.Text = "nie";
            this.radioMilkNo.UseVisualStyleBackColor = true;
            // 
            // radioMilkYes
            // 
            this.radioMilkYes.AutoSize = true;
            this.radioMilkYes.ForeColor = System.Drawing.Color.Black;
            this.radioMilkYes.Location = new System.Drawing.Point(6, 21);
            this.radioMilkYes.Name = "radioMilkYes";
            this.radioMilkYes.Size = new System.Drawing.Size(44, 20);
            this.radioMilkYes.TabIndex = 1;
            this.radioMilkYes.TabStop = true;
            this.radioMilkYes.Text = "tak";
            this.radioMilkYes.UseVisualStyleBackColor = true;
            // 
            // milkChoice
            // 
            this.milkChoice.Controls.Add(this.radioMilkNo);
            this.milkChoice.Controls.Add(this.radioMilkYes);
            this.milkChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.milkChoice.Location = new System.Drawing.Point(77, 11);
            this.milkChoice.Name = "milkChoice";
            this.milkChoice.Size = new System.Drawing.Size(105, 65);
            this.milkChoice.TabIndex = 1;
            this.milkChoice.TabStop = false;
            this.milkChoice.Text = "mleko";
            // 
            // sizeCoffee
            // 
            this.sizeCoffee.Controls.Add(this.bigCoffee);
            this.sizeCoffee.Controls.Add(this.smallCoffee);
            this.sizeCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sizeCoffee.Location = new System.Drawing.Point(199, 11);
            this.sizeCoffee.Name = "sizeCoffee";
            this.sizeCoffee.Size = new System.Drawing.Size(105, 65);
            this.sizeCoffee.TabIndex = 3;
            this.sizeCoffee.TabStop = false;
            this.sizeCoffee.Text = "rozmiar";
            // 
            // bigCoffee
            // 
            this.bigCoffee.AutoSize = true;
            this.bigCoffee.ForeColor = System.Drawing.Color.Black;
            this.bigCoffee.Location = new System.Drawing.Point(6, 39);
            this.bigCoffee.Name = "bigCoffee";
            this.bigCoffee.Size = new System.Drawing.Size(55, 20);
            this.bigCoffee.TabIndex = 2;
            this.bigCoffee.TabStop = true;
            this.bigCoffee.Text = "duża";
            this.bigCoffee.UseVisualStyleBackColor = true;
            // 
            // smallCoffee
            // 
            this.smallCoffee.AutoSize = true;
            this.smallCoffee.ForeColor = System.Drawing.Color.Black;
            this.smallCoffee.Location = new System.Drawing.Point(6, 21);
            this.smallCoffee.Name = "smallCoffee";
            this.smallCoffee.Size = new System.Drawing.Size(59, 20);
            this.smallCoffee.TabIndex = 1;
            this.smallCoffee.TabStop = true;
            this.smallCoffee.Text = "mała";
            this.smallCoffee.UseVisualStyleBackColor = true;
            // 
            // coffeeSelect
            // 
            this.coffeeSelect.Image = global::BakeryInterface.Properties.Resources.coffee;
            this.coffeeSelect.Location = new System.Drawing.Point(6, 18);
            this.coffeeSelect.Name = "coffeeSelect";
            this.coffeeSelect.Size = new System.Drawing.Size(55, 55);
            this.coffeeSelect.TabIndex = 4;
            this.coffeeSelect.UseVisualStyleBackColor = true;
            // 
            // teaBox
            // 
            this.teaBox.Controls.Add(this.teaSelect);
            this.teaBox.Controls.Add(this.sizeTea);
            this.teaBox.Controls.Add(this.lemonChoice);
            this.teaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teaBox.Location = new System.Drawing.Point(12, 100);
            this.teaBox.Name = "teaBox";
            this.teaBox.Size = new System.Drawing.Size(326, 82);
            this.teaBox.TabIndex = 5;
            this.teaBox.TabStop = false;
            this.teaBox.Text = "Herbata";
            // 
            // teaSelect
            // 
            this.teaSelect.Image = global::BakeryInterface.Properties.Resources.tea;
            this.teaSelect.Location = new System.Drawing.Point(6, 18);
            this.teaSelect.Name = "teaSelect";
            this.teaSelect.Size = new System.Drawing.Size(55, 55);
            this.teaSelect.TabIndex = 4;
            this.teaSelect.UseVisualStyleBackColor = true;
            // 
            // sizeTea
            // 
            this.sizeTea.Controls.Add(this.bigTea);
            this.sizeTea.Controls.Add(this.smallTea);
            this.sizeTea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sizeTea.Location = new System.Drawing.Point(199, 11);
            this.sizeTea.Name = "sizeTea";
            this.sizeTea.Size = new System.Drawing.Size(105, 65);
            this.sizeTea.TabIndex = 3;
            this.sizeTea.TabStop = false;
            this.sizeTea.Text = "rozmiar";
            // 
            // bigTea
            // 
            this.bigTea.AutoSize = true;
            this.bigTea.ForeColor = System.Drawing.Color.Black;
            this.bigTea.Location = new System.Drawing.Point(6, 39);
            this.bigTea.Name = "bigTea";
            this.bigTea.Size = new System.Drawing.Size(55, 20);
            this.bigTea.TabIndex = 2;
            this.bigTea.TabStop = true;
            this.bigTea.Text = "duża";
            this.bigTea.UseVisualStyleBackColor = true;
            // 
            // smallTea
            // 
            this.smallTea.AutoSize = true;
            this.smallTea.ForeColor = System.Drawing.Color.Black;
            this.smallTea.Location = new System.Drawing.Point(6, 21);
            this.smallTea.Name = "smallTea";
            this.smallTea.Size = new System.Drawing.Size(59, 20);
            this.smallTea.TabIndex = 1;
            this.smallTea.TabStop = true;
            this.smallTea.Text = "mała";
            this.smallTea.UseVisualStyleBackColor = true;
            // 
            // lemonChoice
            // 
            this.lemonChoice.Controls.Add(this.radioLemonNO);
            this.lemonChoice.Controls.Add(this.radioLemonYes);
            this.lemonChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lemonChoice.Location = new System.Drawing.Point(77, 11);
            this.lemonChoice.Name = "lemonChoice";
            this.lemonChoice.Size = new System.Drawing.Size(105, 65);
            this.lemonChoice.TabIndex = 1;
            this.lemonChoice.TabStop = false;
            this.lemonChoice.Text = "cytryna";
            // 
            // radioLemonNO
            // 
            this.radioLemonNO.AutoSize = true;
            this.radioLemonNO.ForeColor = System.Drawing.Color.Black;
            this.radioLemonNO.Location = new System.Drawing.Point(6, 39);
            this.radioLemonNO.Name = "radioLemonNO";
            this.radioLemonNO.Size = new System.Drawing.Size(44, 20);
            this.radioLemonNO.TabIndex = 2;
            this.radioLemonNO.TabStop = true;
            this.radioLemonNO.Text = "nie";
            this.radioLemonNO.UseVisualStyleBackColor = true;
            // 
            // radioLemonYes
            // 
            this.radioLemonYes.AutoSize = true;
            this.radioLemonYes.ForeColor = System.Drawing.Color.Black;
            this.radioLemonYes.Location = new System.Drawing.Point(6, 21);
            this.radioLemonYes.Name = "radioLemonYes";
            this.radioLemonYes.Size = new System.Drawing.Size(44, 20);
            this.radioLemonYes.TabIndex = 1;
            this.radioLemonYes.TabStop = true;
            this.radioLemonYes.Text = "tak";
            this.radioLemonYes.UseVisualStyleBackColor = true;
            // 
            // Drinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 310);
            this.Controls.Add(this.teaBox);
            this.Controls.Add(this.coffeeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Drinks";
            this.Text = "ordersList";
            this.coffeeBox.ResumeLayout(false);
            this.milkChoice.ResumeLayout(false);
            this.milkChoice.PerformLayout();
            this.sizeCoffee.ResumeLayout(false);
            this.sizeCoffee.PerformLayout();
            this.teaBox.ResumeLayout(false);
            this.sizeTea.ResumeLayout(false);
            this.sizeTea.PerformLayout();
            this.lemonChoice.ResumeLayout(false);
            this.lemonChoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox coffeeBox;
        private System.Windows.Forms.RadioButton radioMilkNo;
        private System.Windows.Forms.RadioButton radioMilkYes;
        private System.Windows.Forms.GroupBox milkChoice;
        private System.Windows.Forms.GroupBox sizeCoffee;
        private System.Windows.Forms.RadioButton bigCoffee;
        private System.Windows.Forms.RadioButton smallCoffee;
        private System.Windows.Forms.Button coffeeSelect;
        private System.Windows.Forms.GroupBox teaBox;
        private System.Windows.Forms.Button teaSelect;
        private System.Windows.Forms.GroupBox sizeTea;
        private System.Windows.Forms.RadioButton bigTea;
        private System.Windows.Forms.RadioButton smallTea;
        private System.Windows.Forms.GroupBox lemonChoice;
        private System.Windows.Forms.RadioButton radioLemonNO;
        private System.Windows.Forms.RadioButton radioLemonYes;
    }
}