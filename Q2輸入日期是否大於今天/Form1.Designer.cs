namespace Q2輸入日期是否大於今天
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.checkButton = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			this.nowTimelabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(52, 31);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 0;
			// 
			// checkButton
			// 
			this.checkButton.Location = new System.Drawing.Point(52, 93);
			this.checkButton.Name = "checkButton";
			this.checkButton.Size = new System.Drawing.Size(100, 23);
			this.checkButton.TabIndex = 1;
			this.checkButton.Text = "檢查";
			this.checkButton.UseVisualStyleBackColor = true;
			this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Location = new System.Drawing.Point(189, 64);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(56, 12);
			this.resultLabel.TabIndex = 2;
			this.resultLabel.Text = "resultLabel";
			this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
			// 
			// nowTimelabel
			// 
			this.nowTimelabel.AutoSize = true;
			this.nowTimelabel.Location = new System.Drawing.Point(191, 31);
			this.nowTimelabel.Name = "nowTimelabel";
			this.nowTimelabel.Size = new System.Drawing.Size(71, 12);
			this.nowTimelabel.TabIndex = 3;
			this.nowTimelabel.Text = "nowTimelabel";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 186);
			this.Controls.Add(this.nowTimelabel);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.checkButton);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Q2輸入日期是否大於今天";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button checkButton;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.Label nowTimelabel;
	}
}

