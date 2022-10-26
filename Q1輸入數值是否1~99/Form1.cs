using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Q1輸入數值是否1_99
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ckeckButton_Click(object sender, EventArgs e)
		{
			string value = textBox1.Text;
			
			//計算1~99之間
			try
			{
				//防呆
				int check = GetNumber(value);

				if (check > 0 && check < 99)
				{
					resultLabel.Text = "符合";
				}
				else
				{
					resultLabel.Text = "不符合";
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private int GetNumber(string number2)
		{			
			bool isInt = int.TryParse(number2, out int result);
			return isInt ? result : throw new Exception("不是數字");
		}
		
	}
}
