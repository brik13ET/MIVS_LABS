namespace LAB3
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
			this.listViewEvent = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listView = new System.Windows.Forms.ListView();
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonGenerate = new System.Windows.Forms.Button();
			this.Sum = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBoxYellow = new System.Windows.Forms.PictureBox();
			this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
			this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
			this.pictureBoxBlack = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listViewEvent
			// 
			this.listViewEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listViewEvent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2});
			this.listViewEvent.HideSelection = false;
			this.listViewEvent.Location = new System.Drawing.Point(0, 17);
			this.listViewEvent.Name = "listViewEvent";
			this.listViewEvent.Size = new System.Drawing.Size(265, 126);
			this.listViewEvent.TabIndex = 0;
			this.listViewEvent.UseCompatibleStateImageBehavior = false;
			this.listViewEvent.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Событие";
			this.columnHeader1.Width = 125;
			// 
			// columnHeader3
			// 
			this.columnHeader3.DisplayIndex = 2;
			this.columnHeader3.Text = "Статус";
			this.columnHeader3.Width = 136;
			// 
			// columnHeader2
			// 
			this.columnHeader2.DisplayIndex = 1;
			this.columnHeader2.Text = "Уведомление";
			this.columnHeader2.Width = 157;
			// 
			// listView
			// 
			this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
			this.listView.HideSelection = false;
			this.listView.Location = new System.Drawing.Point(1, 18);
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(264, 128);
			this.listView.TabIndex = 1;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Событие";
			this.columnHeader4.Width = 98;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Статус";
			this.columnHeader5.Width = 87;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Уведомление";
			this.columnHeader6.Width = 141;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Момент времени";
			this.columnHeader7.Width = 184;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Таблица событий:";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(5, 1);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(123, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Таблица уведомлений:";
			// 
			// buttonGenerate
			// 
			this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGenerate.Location = new System.Drawing.Point(229, 320);
			this.buttonGenerate.Name = "buttonGenerate";
			this.buttonGenerate.Size = new System.Drawing.Size(262, 89);
			this.buttonGenerate.TabIndex = 4;
			this.buttonGenerate.Text = "Сгенерировать";
			this.buttonGenerate.UseVisualStyleBackColor = true;
			this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
			// 
			// Sum
			// 
			this.Sum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Sum.AutoSize = true;
			this.Sum.Location = new System.Drawing.Point(226, 297);
			this.Sum.Name = "Sum";
			this.Sum.Size = new System.Drawing.Size(126, 13);
			this.Sum.TabIndex = 5;
			this.Sum.Text = "Время моделирования:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, -1);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Сигнал:";
			// 
			// pictureBoxYellow
			// 
			this.pictureBoxYellow.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.pictureBoxYellow.Image = global::LAB3.Properties.Resources.java_ico;
			this.pictureBoxYellow.Location = new System.Drawing.Point(16, 15);
			this.pictureBoxYellow.Name = "pictureBoxYellow";
			this.pictureBoxYellow.Size = new System.Drawing.Size(125, 90);
			this.pictureBoxYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxYellow.TabIndex = 7;
			this.pictureBoxYellow.TabStop = false;
			// 
			// pictureBoxBlue
			// 
			this.pictureBoxBlue.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.pictureBoxBlue.Image = global::LAB3.Properties.Resources.asm_ico;
			this.pictureBoxBlue.Location = new System.Drawing.Point(16, 118);
			this.pictureBoxBlue.Name = "pictureBoxBlue";
			this.pictureBoxBlue.Size = new System.Drawing.Size(125, 90);
			this.pictureBoxBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxBlue.TabIndex = 8;
			this.pictureBoxBlue.TabStop = false;
			// 
			// pictureBoxGreen
			// 
			this.pictureBoxGreen.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.pictureBoxGreen.Image = global::LAB3.Properties.Resources.net_ico;
			this.pictureBoxGreen.Location = new System.Drawing.Point(16, 220);
			this.pictureBoxGreen.Name = "pictureBoxGreen";
			this.pictureBoxGreen.Size = new System.Drawing.Size(125, 90);
			this.pictureBoxGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxGreen.TabIndex = 9;
			this.pictureBoxGreen.TabStop = false;
			// 
			// pictureBoxBlack
			// 
			this.pictureBoxBlack.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.pictureBoxBlack.Image = global::LAB3.Properties.Resources.os_ico;
			this.pictureBoxBlack.Location = new System.Drawing.Point(16, 320);
			this.pictureBoxBlack.Name = "pictureBoxBlack";
			this.pictureBoxBlack.Size = new System.Drawing.Size(125, 89);
			this.pictureBoxBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxBlack.TabIndex = 10;
			this.pictureBoxBlack.TabStop = false;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(147, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Сдаётся ООП";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(148, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Сдаётся АСМ";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(148, 253);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Сдаются К.Сети";
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(148, 357);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Сдаётся OS";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(228, 6);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.listViewEvent);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.label5);
			this.splitContainer1.Panel2.Controls.Add(this.listView);
			this.splitContainer1.Size = new System.Drawing.Size(263, 289);
			this.splitContainer1.SplitterDistance = 144;
			this.splitContainer1.SplitterWidth = 2;
			this.splitContainer1.TabIndex = 15;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 434);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBoxBlack);
			this.Controls.Add(this.pictureBoxGreen);
			this.Controls.Add(this.pictureBoxBlue);
			this.Controls.Add(this.pictureBoxYellow);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Sum);
			this.Controls.Add(this.buttonGenerate);
			this.MinimumSize = new System.Drawing.Size(520, 473);
			this.Name = "Form1";
			this.Text = "Лабораторная работа 3";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEvent;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxYellow;
        private System.Windows.Forms.PictureBox pictureBoxBlue;
        private System.Windows.Forms.PictureBox pictureBoxGreen;
        private System.Windows.Forms.PictureBox pictureBoxBlack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

