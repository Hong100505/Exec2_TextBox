namespace Q1輸入數值是否1_99
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
			this.ckeckButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.resultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ckeckButton
			// 
			this.ckeckButton.Location = new System.Drawing.Point(59, 88);
			this.ckeckButton.Name = "ckeckButton";
			this.ckeckButton.Size = new System.Drawing.Size(75, 23);
			this.ckeckButton.TabIndex = 0;
			this.ckeckButton.Text = "檢查";
			this.ckeckButton.UseVisualStyleBackColor = true;
			this.ckeckButton.Click += new System.EventHandler(this.ckeckButton_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(59, 49);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(75, 22);
			this.textBox1.TabIndex = 1;
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Location = new System.Drawing.Point(157, 58);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(30, 12);
			this.resultLabel.TabIndex = 2;
			this.resultLabel.Text = "result";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(285, 203);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.ckeckButton);
			this.Name = "Form1";
			this.Text = "Q1輸入數值是否1~99";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ckeckButton;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label resultLabel;
	}
}

