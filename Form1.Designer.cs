namespace machineCoffe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBlackCoffee = new Button();
            btnMocha = new Button();
            btnLatte = new Button();
            btnChocolate = new Button();
            lblWater = new Label();
            lblCoffee = new Label();
            lblChocolate = new Label();
            lblMilk = new Label();
            gbIngredient = new GroupBox();
            btnRefill = new Button();
            lbBlackCoffee = new Label();
            lblBlackCoffeeCount = new TextBox();
            lblMochaCount = new TextBox();
            lbMocha = new Label();
            lblLatteCount = new TextBox();
            lbLatte = new Label();
            lblChocolateCount = new TextBox();
            lbChocolate = new Label();
            gbIngredient.SuspendLayout();
            SuspendLayout();
            // 
            // btnBlackCoffee
            // 
            btnBlackCoffee.Location = new Point(283, 212);
            btnBlackCoffee.Name = "btnBlackCoffee";
            btnBlackCoffee.Size = new Size(141, 37);
            btnBlackCoffee.TabIndex = 12;
            btnBlackCoffee.Text = "BlackCoffee";
            btnBlackCoffee.UseVisualStyleBackColor = true;
            btnBlackCoffee.Click += btnBlackCoffee_Click;
            // 
            // btnMocha
            // 
            btnMocha.Location = new Point(283, 265);
            btnMocha.Name = "btnMocha";
            btnMocha.Size = new Size(141, 37);
            btnMocha.TabIndex = 13;
            btnMocha.Text = "Mocha";
            btnMocha.UseVisualStyleBackColor = true;
            btnMocha.Click += btnMocha_Click;
            // 
            // btnLatte
            // 
            btnLatte.Location = new Point(477, 212);
            btnLatte.Name = "btnLatte";
            btnLatte.Size = new Size(141, 37);
            btnLatte.TabIndex = 14;
            btnLatte.Text = "Latte";
            btnLatte.UseVisualStyleBackColor = true;
            btnLatte.Click += btnLatte_Click;
            // 
            // btnChocolate
            // 
            btnChocolate.Location = new Point(477, 265);
            btnChocolate.Name = "btnChocolate";
            btnChocolate.Size = new Size(141, 37);
            btnChocolate.TabIndex = 15;
            btnChocolate.Text = "Chocolate";
            btnChocolate.UseVisualStyleBackColor = true;
            btnChocolate.Click += btnChocolate_Click;
            // 
            // lblWater
            // 
            lblWater.AutoSize = true;
            lblWater.Location = new Point(16, 28);
            lblWater.Name = "lblWater";
            lblWater.Size = new Size(78, 15);
            lblWater.TabIndex = 16;
            lblWater.Text = "Water: 2000 g";
            // 
            // lblCoffee
            // 
            lblCoffee.AutoSize = true;
            lblCoffee.Location = new Point(16, 53);
            lblCoffee.Name = "lblCoffee";
            lblCoffee.Size = new Size(76, 15);
            lblCoffee.TabIndex = 17;
            lblCoffee.Text = "Coffee: 500 g";
            // 
            // lblChocolate
            // 
            lblChocolate.AutoSize = true;
            lblChocolate.Location = new Point(16, 80);
            lblChocolate.Name = "lblChocolate";
            lblChocolate.Size = new Size(95, 15);
            lblChocolate.TabIndex = 18;
            lblChocolate.Text = "Chocolate: 300 g";
            // 
            // lblMilk
            // 
            lblMilk.AutoSize = true;
            lblMilk.Location = new Point(16, 104);
            lblMilk.Name = "lblMilk";
            lblMilk.Size = new Size(64, 15);
            lblMilk.TabIndex = 19;
            lblMilk.Text = "Milk: 500 g";
            // 
            // gbIngredient
            // 
            gbIngredient.Controls.Add(lblWater);
            gbIngredient.Controls.Add(lblMilk);
            gbIngredient.Controls.Add(lblCoffee);
            gbIngredient.Controls.Add(lblChocolate);
            gbIngredient.Location = new Point(323, 36);
            gbIngredient.Name = "gbIngredient";
            gbIngredient.Size = new Size(258, 133);
            gbIngredient.TabIndex = 20;
            gbIngredient.TabStop = false;
            gbIngredient.Text = "ingredient";
            gbIngredient.Enter += gbIngredient_Enter;
            // 
            // btnRefill
            // 
            btnRefill.Location = new Point(395, 319);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(108, 27);
            btnRefill.TabIndex = 21;
            btnRefill.Text = "Refill";
            btnRefill.UseVisualStyleBackColor = true;
            btnRefill.Click += btnRefill_Click;
            // 
            // lbBlackCoffee
            // 
            lbBlackCoffee.AutoSize = true;
            lbBlackCoffee.Location = new Point(24, 124);
            lbBlackCoffee.Name = "lbBlackCoffee";
            lbBlackCoffee.Size = new Size(70, 15);
            lbBlackCoffee.TabIndex = 22;
            lbBlackCoffee.Text = "BlackCoffee";
            // 
            // lblBlackCoffeeCount
            // 
            lblBlackCoffeeCount.Location = new Point(98, 116);
            lblBlackCoffeeCount.Name = "lblBlackCoffeeCount";
            lblBlackCoffeeCount.Size = new Size(122, 23);
            lblBlackCoffeeCount.TabIndex = 23;
            // 
            // lblMochaCount
            // 
            lblMochaCount.Location = new Point(98, 145);
            lblMochaCount.Name = "lblMochaCount";
            lblMochaCount.Size = new Size(122, 23);
            lblMochaCount.TabIndex = 25;
            // 
            // lbMocha
            // 
            lbMocha.AutoSize = true;
            lbMocha.Location = new Point(48, 153);
            lbMocha.Name = "lbMocha";
            lbMocha.Size = new Size(44, 15);
            lbMocha.TabIndex = 24;
            lbMocha.Text = "Mocha";
            // 
            // lblLatteCount
            // 
            lblLatteCount.Location = new Point(98, 174);
            lblLatteCount.Name = "lblLatteCount";
            lblLatteCount.Size = new Size(122, 23);
            lblLatteCount.TabIndex = 27;
            // 
            // lbLatte
            // 
            lbLatte.AutoSize = true;
            lbLatte.Location = new Point(54, 182);
            lbLatte.Name = "lbLatte";
            lbLatte.Size = new Size(33, 15);
            lbLatte.TabIndex = 26;
            lbLatte.Text = "Latte";
            // 
            // lblChocolateCount
            // 
            lblChocolateCount.Location = new Point(98, 204);
            lblChocolateCount.Name = "lblChocolateCount";
            lblChocolateCount.Size = new Size(122, 23);
            lblChocolateCount.TabIndex = 29;
            // 
            // lbChocolate
            // 
            lbChocolate.AutoSize = true;
            lbChocolate.Location = new Point(31, 207);
            lbChocolate.Name = "lbChocolate";
            lbChocolate.Size = new Size(61, 15);
            lbChocolate.TabIndex = 28;
            lbChocolate.Text = "Chocolate";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(630, 358);
            Controls.Add(lblChocolateCount);
            Controls.Add(lbChocolate);
            Controls.Add(lblLatteCount);
            Controls.Add(lbLatte);
            Controls.Add(lblMochaCount);
            Controls.Add(lbMocha);
            Controls.Add(lblBlackCoffeeCount);
            Controls.Add(lbBlackCoffee);
            Controls.Add(btnRefill);
            Controls.Add(gbIngredient);
            Controls.Add(btnChocolate);
            Controls.Add(btnLatte);
            Controls.Add(btnMocha);
            Controls.Add(btnBlackCoffee);
            Name = "Form1";
            Text = "Form1";
            gbIngredient.ResumeLayout(false);
            gbIngredient.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBlackCoffee;
        private Button btnMocha;
        private Button btnLatte;
        private Button btnChocolate;
        private Label lblWater;
        private Label lblCoffee;
        private Label lblChocolate;
        private Label lblMilk;
        private GroupBox gbIngredient;
        private Button btnRefill;
        private Label lbBlackCoffee;
        private TextBox lblBlackCoffeeCount;
        private TextBox lblMochaCount;
        private Label lbMocha;
        private TextBox lblLatteCount;
        private Label lbLatte;
        private TextBox lblChocolateCount;
        private Label lbChocolate;
    }
}
