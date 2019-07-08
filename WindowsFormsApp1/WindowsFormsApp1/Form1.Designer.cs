namespace Counter.WinForms
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
            this.StartButton = new System.Windows.Forms.Button();
            this.InputSelectedCounter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CountTill = new System.Windows.Forms.NumericUpDown();
            this.InputDelayTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.AddCounterButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CountTill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputDelayTime)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(472, 28);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // InputSelectedCounter
            // 
            this.InputSelectedCounter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputSelectedCounter.FormattingEnabled = true;
            this.InputSelectedCounter.ImeMode = System.Windows.Forms.ImeMode.On;
            this.InputSelectedCounter.Items.AddRange(new object[] {
            "Text",
            "Numeric"});
            this.InputSelectedCounter.Location = new System.Drawing.Point(12, 30);
            this.InputSelectedCounter.Name = "InputSelectedCounter";
            this.InputSelectedCounter.Size = new System.Drawing.Size(121, 21);
            this.InputSelectedCounter.TabIndex = 1;
            this.InputSelectedCounter.SelectedIndexChanged += new System.EventHandler(this.InputSelectedCounter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Counter type:";
            // 
            // CountTill
            // 
            this.CountTill.Location = new System.Drawing.Point(128, 20);
            this.CountTill.Name = "CountTill";
            this.CountTill.Size = new System.Drawing.Size(120, 20);
            this.CountTill.TabIndex = 3;
            // 
            // InputDelayTime
            // 
            this.InputDelayTime.Location = new System.Drawing.Point(2, 20);
            this.InputDelayTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.InputDelayTime.Name = "InputDelayTime";
            this.InputDelayTime.Size = new System.Drawing.Size(120, 20);
            this.InputDelayTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Count till:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delay (ms):";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(12, 57);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(535, 127);
            this.OutputTextBox.TabIndex = 9;
            // 
            // AddCounterButton
            // 
            this.AddCounterButton.Location = new System.Drawing.Point(391, 28);
            this.AddCounterButton.Name = "AddCounterButton";
            this.AddCounterButton.Size = new System.Drawing.Size(75, 23);
            this.AddCounterButton.TabIndex = 10;
            this.AddCounterButton.Text = "Add";
            this.AddCounterButton.UseVisualStyleBackColor = true;
            this.AddCounterButton.Click += new System.EventHandler(this.AddCounterButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(253, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(12, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 44);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CountTill);
            this.panel2.Controls.Add(this.InputDelayTime);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(139, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 52);
            this.panel2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 258);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddCounterButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputSelectedCounter);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CountTill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputDelayTime)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.ComboBox InputSelectedCounter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown CountTill;
		private System.Windows.Forms.NumericUpDown InputDelayTime;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button AddCounterButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

