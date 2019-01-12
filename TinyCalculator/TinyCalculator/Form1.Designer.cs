namespace TinyCalculator
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
            this.Display = new System.Windows.Forms.RichTextBox();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.Negate = new System.Windows.Forms.Button();
            this.Solve = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.DeleteLastNumber = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ClearE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.Info;
            this.Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Display.Cursor = System.Windows.Forms.Cursors.Default;
            this.Display.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(12, 12);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Display.Size = new System.Drawing.Size(339, 89);
            this.Display.TabIndex = 0;
            this.Display.Text = "0";
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(12, 305);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(80, 60);
            this.B1.TabIndex = 1;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(98, 305);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(80, 60);
            this.B2.TabIndex = 2;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(185, 305);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(80, 60);
            this.B3.TabIndex = 3;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // B4
            // 
            this.B4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.B4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B4.Location = new System.Drawing.Point(12, 239);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(80, 60);
            this.B4.TabIndex = 4;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = false;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // B5
            // 
            this.B5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.B5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B5.Location = new System.Drawing.Point(98, 239);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(80, 60);
            this.B5.TabIndex = 5;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = false;
            this.B5.Click += new System.EventHandler(this.B5_Click);
            // 
            // B6
            // 
            this.B6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.B6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B6.Location = new System.Drawing.Point(184, 239);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(80, 60);
            this.B6.TabIndex = 6;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = false;
            this.B6.Click += new System.EventHandler(this.B6_Click);
            // 
            // B7
            // 
            this.B7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.B7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B7.Location = new System.Drawing.Point(12, 173);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(80, 60);
            this.B7.TabIndex = 7;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = false;
            this.B7.Click += new System.EventHandler(this.B7_Click);
            // 
            // B8
            // 
            this.B8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.B8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B8.Location = new System.Drawing.Point(98, 173);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(80, 60);
            this.B8.TabIndex = 8;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = false;
            this.B8.Click += new System.EventHandler(this.B8_Click);
            // 
            // B9
            // 
            this.B9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.B9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B9.Location = new System.Drawing.Point(185, 173);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(80, 60);
            this.B9.TabIndex = 9;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = false;
            this.B9.Click += new System.EventHandler(this.B9_Click);
            // 
            // B0
            // 
            this.B0.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.B0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B0.Location = new System.Drawing.Point(98, 371);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(80, 60);
            this.B0.TabIndex = 10;
            this.B0.Text = "0";
            this.B0.UseVisualStyleBackColor = false;
            this.B0.Click += new System.EventHandler(this.B0_Click);
            // 
            // Decimal
            // 
            this.Decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decimal.Location = new System.Drawing.Point(185, 371);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(80, 60);
            this.Decimal.TabIndex = 11;
            this.Decimal.Text = ".";
            this.Decimal.UseVisualStyleBackColor = true;
            this.Decimal.Click += new System.EventHandler(this.Decimal_Click);
            // 
            // Negate
            // 
            this.Negate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Negate.Location = new System.Drawing.Point(12, 371);
            this.Negate.Name = "Negate";
            this.Negate.Size = new System.Drawing.Size(80, 60);
            this.Negate.TabIndex = 12;
            this.Negate.Text = "±";
            this.Negate.UseVisualStyleBackColor = true;
            this.Negate.Click += new System.EventHandler(this.Negate_Click);
            // 
            // Solve
            // 
            this.Solve.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solve.Location = new System.Drawing.Point(271, 371);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(80, 60);
            this.Solve.TabIndex = 13;
            this.Solve.Text = "=";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(271, 305);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(80, 60);
            this.Add.TabIndex = 14;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Subtract
            // 
            this.Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract.Location = new System.Drawing.Point(271, 239);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(80, 60);
            this.Subtract.TabIndex = 15;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.Location = new System.Drawing.Point(271, 173);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(80, 60);
            this.Multiply.TabIndex = 16;
            this.Multiply.Text = "X";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(271, 108);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(80, 60);
            this.Divide.TabIndex = 17;
            this.Divide.Text = "÷";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // DeleteLastNumber
            // 
            this.DeleteLastNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteLastNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteLastNumber.Location = new System.Drawing.Point(185, 107);
            this.DeleteLastNumber.Name = "DeleteLastNumber";
            this.DeleteLastNumber.Size = new System.Drawing.Size(80, 60);
            this.DeleteLastNumber.TabIndex = 18;
            this.DeleteLastNumber.Text = "<-";
            this.DeleteLastNumber.UseVisualStyleBackColor = false;
            this.DeleteLastNumber.Click += new System.EventHandler(this.DeleteLastNumber_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(98, 108);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(80, 60);
            this.Clear.TabIndex = 19;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ClearE
            // 
            this.ClearE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClearE.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearE.Location = new System.Drawing.Point(12, 107);
            this.ClearE.Name = "ClearE";
            this.ClearE.Size = new System.Drawing.Size(80, 60);
            this.ClearE.TabIndex = 20;
            this.ClearE.Text = "CE";
            this.ClearE.UseVisualStyleBackColor = false;
            this.ClearE.Click += new System.EventHandler(this.ClearE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 437);
            this.Controls.Add(this.ClearE);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.DeleteLastNumber);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Solve);
            this.Controls.Add(this.Negate);
            this.Controls.Add(this.Decimal);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "Tiny Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Display;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button B0;
        private System.Windows.Forms.Button Decimal;
        private System.Windows.Forms.Button Negate;
        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button DeleteLastNumber;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ClearE;
    }
}

