using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2輸入日期是否大於今天
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			DateTime dt = DateTime.Now;
			string value = dt.ToString("yyyy/MM/dd");
			nowTimelabel.Text = "今天日期是" + value;

		}

		private void checkButton_Click(object sender, EventArgs e)
		{
			string value2 = textBox1.Text;
			//DateTime dt2 = Convert.ToDateTime(value2);


			// 比較日期大小
			try
			{
				// 防呆不是數字
				DateTime check = CheckTime(value2);


				DateTime dt2 = check;
				
				if (dt2 < DateTime.Now)
				{
					resultLabel.Text = "小於今天";
				}
				else
				{
					resultLabel.Text = "大於今天";
				}
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}



		//防呆不是數字 輸入長度
		private DateTime CheckTime(string value2)
		{
			if (value2.Length == 10)
			{
				bool isInt = DateTime.TryParse(value2, out DateTime val);
				return isInt ? val : throw new Exception("要輸入時間數字(格式為yyyy/MM/dd)");
			}
			else
			{
				throw new Exception("要輸入時間數字(格式為yyyy/MM/dd)");
			}
		}


		private void resultLabel_Click(object sender, EventArgs e)
		{

		}
	}
}
