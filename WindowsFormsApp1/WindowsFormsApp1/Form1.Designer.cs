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
			this.InputCounterCount = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.OutputTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.CountTill)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InputDelayTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InputCounterCount)).BeginInit();
			this.SuspendLayout();
			// 
			// StartButton
			// 
			this.StartButton.Location = new System.Drawing.Point(517, 28);
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
			this.InputSelectedCounter.Location = new System.Drawing.Point(390, 30);
			this.InputSelectedCounter.Name = "InputSelectedCounter";
			this.InputSelectedCounter.Size = new System.Drawing.Size(121, 21);
			this.InputSelectedCounter.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(387, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Counter type:";
			// 
			// CountTill
			// 
			this.CountTill.Location = new System.Drawing.Point(138, 31);
			this.CountTill.Name = "CountTill";
			this.CountTill.Size = new System.Drawing.Size(120, 20);
			this.CountTill.TabIndex = 3;
			// 
			// InputDelayTime
			// 
			this.InputDelayTime.Location = new System.Drawing.Point(264, 31);
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
			this.label2.Location = new System.Drawing.Point(138, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Count till:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(261, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Delay (ms):";
			// 
			// InputCounterCount
			// 
			this.InputCounterCount.Location = new System.Drawing.Point(12, 31);
			this.InputCounterCount.Name = "InputCounterCount";
			this.InputCounterCount.Size = new System.Drawing.Size(120, 20);
			this.InputCounterCount.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Counter count:";
			// 
			// OutputTextBox
			// 
			this.OutputTextBox.Location = new System.Drawing.Point(12, 57);
			this.OutputTextBox.Multiline = true;
			this.OutputTextBox.Name = "OutputTextBox";
			this.OutputTextBox.Size = new System.Drawing.Size(580, 127);
			this.OutputTextBox.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(620, 207);
			this.Controls.Add(this.OutputTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.InputCounterCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.InputDelayTime);
			this.Controls.Add(this.CountTill);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.InputSelectedCounter);
			this.Controls.Add(this.StartButton);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.CountTill)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InputDelayTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InputCounterCount)).EndInit();
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
		private System.Windows.Forms.NumericUpDown InputCounterCount;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox OutputTextBox;
	}
}

