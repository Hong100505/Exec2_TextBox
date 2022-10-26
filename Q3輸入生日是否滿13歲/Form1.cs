using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3輸入生日是否滿13歲
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void checkButton_Click(object sender, EventArgs e)
		{
			try
			{
				DateTime date = BirthDay(textBox1);
				if (DateTime.Today.Year - date.Year >= 13)
				{
					birthLabel.Text = "滿13歲";
				}
				else
				{
					birthLabel.Text = "未滿13歲";
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private DateTime BirthDay(TextBox input)
		{
			string value = input.Text;
			bool isDateTime = DateTime.TryParse(value, out DateTime date);
			date = isDateTime ? date : throw new Exception("格式錯誤");
			bool beforeDate = date < DateTime.Today;
			return beforeDate ? date : throw new Exception("生日不可以大於今天");
		}
	}
}

