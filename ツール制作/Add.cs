﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ツール制作
{
	public partial class Add : Form
	{
		public Add()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			MySqlConnection cn = new MySqlConnection("Data Source=localhost;Database = test;User Id = root;Password = Koujirou6;");

			int PriceValue = int.Parse(this.Price.Text);
			Console.WriteLine(PriceValue);

			//コマンドの作成

			MySqlCommand MySqlCommand = new MySqlCommand(String.Format("INSERT INTO `test`.`usedlist` (`Bought`, `Price`) VALUES('{0}', {1});", this.Bought.Text, PriceValue), cn);
			MySqlCommand.Connection.Open();
			MySqlCommand.ExecuteNonQuery();
			MySqlCommand.Connection.Close();

			this.Bought.Text = "";
			this.Price.Text = "";
		}

		private void Label3_Click(object sender, EventArgs e)
		{

		}

		private void Price_TextChanged(object sender, EventArgs e)
		{

		}


		private void Price_Validating(object sender, CancelEventArgs e)
		{
			if (!Price.Text.All(char.IsDigit))
			{
			this.errorProvider1.SetError(this.Price, "数値を入力してください");
			}
			else
			{
				this.errorProvider1.SetError(this.Price, string.Empty);
			}
		}

		private void Number_TextChanged(object sender, EventArgs e)
		{

		}


		private void Add_Load(object sender, EventArgs e)
		{

		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}

		private void Bought_TextChanged(object sender, EventArgs e)
		{

		}
	}
}