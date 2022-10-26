using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4計算入場費
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Resize(object sender, EventArgs e)
		{

		}

		private void calcButton_Click(object sender, EventArgs e)
		{
			string people = textBox1.Text;
			string car = textBox2.Text;


			try
			{
				//防呆都是正整數
				int check1 = checkpeople(people);
				int check2 = checkcar(car);

				//計算費用
				int totalmoney = Money(check1, check2);

				//顯示
				spendLabel.Text = totalmoney.ToString();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private int checkcar(string car)
		{
			
			bool isInt = int.TryParse(car, out int people2);
			return isInt ? people2 : throw new Exception("車要輸入正整數");
		}

		private int checkpeople(string people)
		{
			bool isInt = int.TryParse(people, out int people2);
			return	isInt ? people2 : throw new Exception("人要輸入正整數");
		}


		private int Money(int peopleNumber, int carNumber)
		{

			int peoplemoney = 60;
			int carmoney2 = 200;

			int total = peopleNumber * peoplemoney + carNumber * carmoney2;
			return total;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
