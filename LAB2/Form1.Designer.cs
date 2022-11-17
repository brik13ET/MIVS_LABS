namespace MIVS_Lab2
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1
			// 
			this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.AxisX.LabelStyle.Format = "00.00";
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
			chartArea1.AxisX.MajorGrid.LineWidth = 2;
			chartArea1.AxisX.Maximum = 60D;
			chartArea1.AxisX.Minimum = 0D;
			chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			chartArea1.AxisY.MajorGrid.Enabled = false;
			chartArea1.AxisY.Maximum = 500D;
			chartArea1.AxisY.Minimum = 0D;
			chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Location = new System.Drawing.Point(465, 51);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(307, 378);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.IntegralHeight = false;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(226, 51);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(233, 378);
			this.listBox1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.button1.Location = new System.Drawing.Point(500, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(133, 33);
			this.button1.TabIndex = 4;
			this.button1.Text = "Расчёт";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.button2.Location = new System.Drawing.Point(639, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(133, 33);
			this.button2.TabIndex = 5;
			this.button2.Text = "Очистить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "T";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label2.Location = new System.Drawing.Point(226, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(18, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "λ";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(36, 15);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(184, 26);
			this.textBox1.TabIndex = 8;
			this.textBox1.Text = "2";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(250, 15);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(184, 26);
			this.textBox2.TabIndex = 9;
			this.textBox2.Text = "0.2";
			// 
			// listBox2
			// 
			this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.listBox2.FormattingEnabled = true;
			this.listBox2.IntegralHeight = false;
			this.listBox2.ItemHeight = 20;
			this.listBox2.Location = new System.Drawing.Point(12, 51);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(208, 378);
			this.listBox2.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 441);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.chart1);
			this.MinimumSize = new System.Drawing.Size(800, 480);
			this.Name = "Form1";
			this.Text = "Ибрагим Алеев 6304";
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ListBox listBox2;
	}
}

