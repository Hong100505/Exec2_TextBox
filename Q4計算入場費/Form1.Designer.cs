namespace Q4計算入場費
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.calcButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.spendLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// calcButton
			// 
			this.calcButton.Location = new System.Drawing.Point(94, 189);
			this.calcButton.Name = "calcButton";
			this.calcButton.Size = new System.Drawing.Size(157, 22);
			this.calcButton.TabIndex = 0;
			this.calcButton.Text = "計算";
			this.calcButton.UseVisualStyleBackColor = true;
			this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(151, 77);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(151, 115);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(92, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "人";
			this.label1.Resize += new System.EventHandler(this.label1_Resize);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(94, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "車";
			// 
			// spendLabel
			// 
			this.spendLabel.AutoSize = true;
			this.spendLabel.Location = new System.Drawing.Point(218, 159);
			this.spendLabel.Name = "spendLabel";
			this.spendLabel.Size = new System.Drawing.Size(29, 12);
			this.spendLabel.TabIndex = 5;
			this.spendLabel.Text = "費用";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(361, 288);
			this.Controls.Add(this.spendLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.calcButton);
			this.Name = "Form1";
			this.Text = "Q4計算入場費";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button calcButton;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label spendLabel;
	}
}

