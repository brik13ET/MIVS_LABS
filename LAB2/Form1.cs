using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIVS_Lab2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		double T;
		double lambda;
		const int N = 1000;
		int grps = 15;
		Random rnd = new Random();
		double[] times;

		double rnd_exp(double lambda_)
		{
			return -Math.Log(rnd.NextDouble()) / lambda_;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (grps <= 2)
			{
				MessageBox.Show("Bad groups count [var $grps must be > 15]");
				return;
			}
			Double.TryParse(textBox1.Text, out T);
			Double.TryParse(textBox2.Text.Replace('.', ','), out lambda);
			times = new double[N];
			double min = T + rnd_exp(lambda), max = T + rnd_exp(lambda);
			for (int i = 0; i < times.Length; i++)
			{
				times[i] = T + rnd_exp(lambda);
				if (times[i] > max)
					max = times[i];
				if (times[i] < min)
					min = times[i];
			}
			double stp = (max - min) / (grps - 2);
			int[] cnts = new int[grps];
			for (int i = 0; i < N; i++)
			{
				double c = times[i];
				int c_grp = 0;
				while (c > stp)
				{
					c -= stp;
					c_grp++;
				}
				cnts[c_grp]++;
			}
			listBox1.Items.Clear();
			foreach (var item in times)
			{
				listBox1.Items.Add(item.ToString("0000.0000"));
			}
			double sum = 0;
			listBox2.Items.Clear();
			foreach (var item in times)
			{
				sum += item;
				listBox2.Items.Add(sum.ToString("0000.0000"));
			}
			chart1.Series[0].Points.Clear();
			for (int i = 0; i < grps; i++)
			{
				chart1.Series[0].Points.AddXY(min + i*stp, cnts[i]);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			listBox2.Items.Clear();
			chart1.Series[0].Points.Clear();
		}
	}
}
