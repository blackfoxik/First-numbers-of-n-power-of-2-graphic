namespace Graphic
{
    partial class FirstNumberOfNPowerOfTwoGraphicForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,0");
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series39 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series40 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series41 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series42 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series43 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series44 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series45 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildGraphicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearGraphicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea5.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            legend5.Title = "First number";
            this.chart.Legends.Add(legend5);
            this.chart.Location = new System.Drawing.Point(1, 12);
            this.chart.Name = "chart";
            series37.BorderColor = System.Drawing.Color.White;
            series37.ChartArea = "ChartArea1";
            series37.Color = System.Drawing.Color.DodgerBlue;
            series37.CustomProperties = "DrawSideBySide=True";
            series37.IsValueShownAsLabel = true;
            series37.LabelBackColor = System.Drawing.Color.White;
            series37.Legend = "Legend1";
            series37.Name = "Ones";
            dataPoint5.IsValueShownAsLabel = true;
            dataPoint5.Label = "";
            dataPoint5.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series37.Points.Add(dataPoint5);
            series37.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series37.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)(((((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopRight)
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomLeft)
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomRight)));
            series37.YValuesPerPoint = 2;
            series38.ChartArea = "ChartArea1";
            series38.Color = System.Drawing.Color.Lime;
            series38.IsValueShownAsLabel = true;
            series38.Legend = "Legend1";
            series38.Name = "Twos";
            series39.ChartArea = "ChartArea1";
            series39.Color = System.Drawing.Color.Fuchsia;
            series39.IsValueShownAsLabel = true;
            series39.Legend = "Legend1";
            series39.Name = "Threes";
            series40.BorderColor = System.Drawing.Color.Black;
            series40.ChartArea = "ChartArea1";
            series40.Color = System.Drawing.Color.Yellow;
            series40.IsValueShownAsLabel = true;
            series40.Legend = "Legend1";
            series40.Name = "Fours";
            series41.ChartArea = "ChartArea1";
            series41.IsValueShownAsLabel = true;
            series41.Legend = "Legend1";
            series41.Name = "Fives";
            series42.ChartArea = "ChartArea1";
            series42.IsValueShownAsLabel = true;
            series42.Legend = "Legend1";
            series42.Name = "Sixes";
            series43.ChartArea = "ChartArea1";
            series43.IsValueShownAsLabel = true;
            series43.Legend = "Legend1";
            series43.Name = "Sevens";
            series44.ChartArea = "ChartArea1";
            series44.IsValueShownAsLabel = true;
            series44.Legend = "Legend1";
            series44.Name = "Eights";
            series45.ChartArea = "ChartArea1";
            series45.IsValueShownAsLabel = true;
            series45.Legend = "Legend1";
            series45.Name = "Nines";
            this.chart.Series.Add(series37);
            this.chart.Series.Add(series38);
            this.chart.Series.Add(series39);
            this.chart.Series.Add(series40);
            this.chart.Series.Add(series41);
            this.chart.Series.Add(series42);
            this.chart.Series.Add(series43);
            this.chart.Series.Add(series44);
            this.chart.Series.Add(series45);
            this.chart.Size = new System.Drawing.Size(903, 506);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuildGraphicToolStripMenuItem,
            this.ClearGraphicToolStripMenuItem});
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.MenuToolStripMenuItem.Text = "Menu";
            // 
            // BuildGraphicToolStripMenuItem
            // 
            this.BuildGraphicToolStripMenuItem.Name = "BuildGraphicToolStripMenuItem";
            this.BuildGraphicToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BuildGraphicToolStripMenuItem.Text = "Build graphic";
            this.BuildGraphicToolStripMenuItem.Click += new System.EventHandler(this.BuildGraphicToolStripMenuItemClick);
            // 
            // ClearGraphicToolStripMenuItem
            // 
            this.ClearGraphicToolStripMenuItem.Name = "ClearGraphicToolStripMenuItem";
            this.ClearGraphicToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ClearGraphicToolStripMenuItem.Text = "Clear graphic";
            this.ClearGraphicToolStripMenuItem.Click += new System.EventHandler(this.ClearGraphicToolStripMenuItemClick);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(400, 524);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 2;
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(158, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "POWER OF TWO";
            // 
            // FirstNumberOfNPowerOfTwoGraphicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chart);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FirstNumberOfNPowerOfTwoGraphicForm";
            this.Text = "Graphic";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuildGraphicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearGraphicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
    }
}

