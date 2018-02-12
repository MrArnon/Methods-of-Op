namespace CM_laba1
{
    partial class Form_for_graphic
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.Graphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.Label_stepen = new System.Windows.Forms.Label();
			this.Epsilon_text = new System.Windows.Forms.TextBox();
			this.Golden_but = new System.Windows.Forms.Button();
			this.A_box = new System.Windows.Forms.TextBox();
			this.B_box = new System.Windows.Forms.TextBox();
			this.Label_interval = new System.Windows.Forms.Label();
			this.Func_value_text = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Value_text = new System.Windows.Forms.TextBox();
			this.Asunder_but = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Graphic)).BeginInit();
			this.SuspendLayout();
			// 
			// Graphic
			// 
			chartArea2.Name = "ChartArea1";
			this.Graphic.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.Graphic.Legends.Add(legend2);
			this.Graphic.Location = new System.Drawing.Point(-1, 2);
			this.Graphic.Name = "Graphic";
			this.Graphic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series2.Legend = "Legend1";
			series2.LegendText = "Функция";
			series2.Name = "Func_graf";
			this.Graphic.Series.Add(series2);
			this.Graphic.Size = new System.Drawing.Size(850, 300);
			this.Graphic.TabIndex = 0;
			this.Graphic.Text = "График";
			title2.Name = "Graphic_func";
			this.Graphic.Titles.Add(title2);
			// 
			// Label_stepen
			// 
			this.Label_stepen.AutoSize = true;
			this.Label_stepen.Location = new System.Drawing.Point(12, 404);
			this.Label_stepen.Name = "Label_stepen";
			this.Label_stepen.Size = new System.Drawing.Size(97, 13);
			this.Label_stepen.TabIndex = 1;
			this.Label_stepen.Text = "Ввидите точность";
			// 
			// Epsilon_text
			// 
			this.Epsilon_text.Location = new System.Drawing.Point(164, 401);
			this.Epsilon_text.Name = "Epsilon_text";
			this.Epsilon_text.Size = new System.Drawing.Size(44, 20);
			this.Epsilon_text.TabIndex = 2;
			this.Epsilon_text.Text = "0,001";
			// 
			// Golden_but
			// 
			this.Golden_but.Location = new System.Drawing.Point(445, 390);
			this.Golden_but.Name = "Golden_but";
			this.Golden_but.Size = new System.Drawing.Size(92, 41);
			this.Golden_but.TabIndex = 3;
			this.Golden_but.Text = "Золотое сечение";
			this.Golden_but.UseVisualStyleBackColor = true;
			this.Golden_but.Click += new System.EventHandler(this.Start_but_Click);
			// 
			// A_box
			// 
			this.A_box.Location = new System.Drawing.Point(15, 350);
			this.A_box.Name = "A_box";
			this.A_box.Size = new System.Drawing.Size(44, 20);
			this.A_box.TabIndex = 4;
			// 
			// B_box
			// 
			this.B_box.Location = new System.Drawing.Point(164, 350);
			this.B_box.Name = "B_box";
			this.B_box.Size = new System.Drawing.Size(44, 20);
			this.B_box.TabIndex = 5;
			// 
			// Label_interval
			// 
			this.Label_interval.AutoSize = true;
			this.Label_interval.Location = new System.Drawing.Point(12, 323);
			this.Label_interval.Name = "Label_interval";
			this.Label_interval.Size = new System.Drawing.Size(151, 13);
			this.Label_interval.TabIndex = 6;
			this.Label_interval.Text = "Ввидите границы интервала";
			// 
			// Func_value_text
			// 
			this.Func_value_text.Location = new System.Drawing.Point(445, 323);
			this.Func_value_text.Name = "Func_value_text";
			this.Func_value_text.Size = new System.Drawing.Size(78, 20);
			this.Func_value_text.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(327, 323);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Значение функции";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(327, 353);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Значение точки";
			// 
			// Value_text
			// 
			this.Value_text.Location = new System.Drawing.Point(445, 353);
			this.Value_text.Name = "Value_text";
			this.Value_text.Size = new System.Drawing.Size(78, 20);
			this.Value_text.TabIndex = 10;
			// 
			// Asunder_but
			// 
			this.Asunder_but.Location = new System.Drawing.Point(330, 390);
			this.Asunder_but.Name = "Asunder_but";
			this.Asunder_but.Size = new System.Drawing.Size(92, 41);
			this.Asunder_but.TabIndex = 11;
			this.Asunder_but.Text = "Деление отрезка";
			this.Asunder_but.UseVisualStyleBackColor = true;
			this.Asunder_but.Click += new System.EventHandler(this.Asunder_but_Click);
			// 
			// Form_for_graphic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(844, 461);
			this.Controls.Add(this.Asunder_but);
			this.Controls.Add(this.Value_text);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Func_value_text);
			this.Controls.Add(this.Label_interval);
			this.Controls.Add(this.B_box);
			this.Controls.Add(this.A_box);
			this.Controls.Add(this.Golden_but);
			this.Controls.Add(this.Epsilon_text);
			this.Controls.Add(this.Label_stepen);
			this.Controls.Add(this.Graphic);
			this.MaximumSize = new System.Drawing.Size(860, 500);
			this.MinimumSize = new System.Drawing.Size(860, 500);
			this.Name = "Form_for_graphic";
			this.Text = "Минимизация";
			((System.ComponentModel.ISupportInitialize)(this.Graphic)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Graphic;
        private System.Windows.Forms.Label Label_stepen;
        private System.Windows.Forms.TextBox Epsilon_text;
        private System.Windows.Forms.Button Golden_but;
        private System.Windows.Forms.TextBox A_box;
        private System.Windows.Forms.TextBox B_box;
        private System.Windows.Forms.Label Label_interval;
        private System.Windows.Forms.TextBox Func_value_text;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Value_text;
		private System.Windows.Forms.Button Asunder_but;
	}
}

