namespace WindowsFormsApp1
{
    partial class InputsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Confirm_Button = new System.Windows.Forms.Button();
            this.Goal_Name = new System.Windows.Forms.TextBox();
            this.CreateNewGoal = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Create A Goal";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(219, 456);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(155, 47);
            this.Cancel_Button.TabIndex = 15;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.Location = new System.Drawing.Point(569, 456);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(155, 47);
            this.Confirm_Button.TabIndex = 14;
            this.Confirm_Button.Text = "Confirm";
            this.Confirm_Button.UseVisualStyleBackColor = true;
            // 
            // Goal_Name
            // 
            this.Goal_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Goal_Name.Location = new System.Drawing.Point(219, 181);
            this.Goal_Name.Name = "Goal_Name";
            this.Goal_Name.Size = new System.Drawing.Size(536, 22);
            this.Goal_Name.TabIndex = 11;
            // 
            // CreateNewGoal
            // 
            this.CreateNewGoal.AutoSize = true;
            this.CreateNewGoal.BackColor = System.Drawing.SystemColors.Control;
            this.CreateNewGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewGoal.Location = new System.Drawing.Point(216, 161);
            this.CreateNewGoal.Name = "CreateNewGoal";
            this.CreateNewGoal.Size = new System.Drawing.Size(44, 16);
            this.CreateNewGoal.TabIndex = 10;
            this.CreateNewGoal.Text = "Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(162, -10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(644, 540);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(219, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(536, 22);
            this.textBox1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(216, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(216, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(429, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Please enter the amount you earn or receive on a monthly/weekly basis";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(219, 384);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(536, 22);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "£";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(216, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Please choose which one applies to you";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Weekly",
            "Monthly"});
            this.comboBox1.Location = new System.Drawing.Point(219, 314);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(535, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Select one";
            // 
            // InputsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(964, 528);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Confirm_Button);
            this.Controls.Add(this.Goal_Name);
            this.Controls.Add(this.CreateNewGoal);
            this.Controls.Add(this.pictureBox2);
            this.Name = "InputsForm";
            this.Text = "InputsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Confirm_Button;
        private System.Windows.Forms.TextBox Goal_Name;
        private System.Windows.Forms.Label CreateNewGoal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}