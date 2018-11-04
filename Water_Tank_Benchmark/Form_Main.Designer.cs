namespace Water_Tank_Benchmark
{
    partial class form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Main));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series32 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series33 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series34 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series35 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_Model_Parameters = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_Parameters = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_t = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Xd = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_x = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Xmin = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Xmax = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_H = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer_DisplayZone = new System.Windows.Forms.SplitContainer();
            this.checkBox_Controller = new System.Windows.Forms.CheckBox();
            this.checkBox_Pump = new System.Windows.Forms.CheckBox();
            this.trackBar_Xd = new System.Windows.Forms.TrackBar();
            this.pictureBox_WhiteBar = new System.Windows.Forms.PictureBox();
            this.pictureBox_BlueBar = new System.Windows.Forms.PictureBox();
            this.pictureBox_Backgroung = new System.Windows.Forms.PictureBox();
            this.panel_Tmax_Graph = new System.Windows.Forms.Panel();
            this.label_Tmax = new System.Windows.Forms.Label();
            this.numericUpDown_Tmax = new System.Windows.Forms.NumericUpDown();
            this.chart_Characteristics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip_Helper = new System.Windows.Forms.ToolTip(this.components);
            this.panel_Computation_Controls = new System.Windows.Forms.Panel();
            this.checkBox_Draw = new System.Windows.Forms.CheckBox();
            this.radioButton_Restart = new System.Windows.Forms.RadioButton();
            this.radioButton_Stop = new System.Windows.Forms.RadioButton();
            this.radioButton_Start = new System.Windows.Forms.RadioButton();
            this.menuStrip_Main.SuspendLayout();
            this.statusStrip_Parameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_DisplayZone)).BeginInit();
            this.splitContainer_DisplayZone.Panel1.SuspendLayout();
            this.splitContainer_DisplayZone.Panel2.SuspendLayout();
            this.splitContainer_DisplayZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Xd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WhiteBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BlueBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Backgroung)).BeginInit();
            this.panel_Tmax_Graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Tmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Characteristics)).BeginInit();
            this.panel_Computation_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Model_Parameters,
            this.toolStripMenuItem_About});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(706, 24);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // toolStripMenuItem_Model_Parameters
            // 
            this.toolStripMenuItem_Model_Parameters.Name = "toolStripMenuItem_Model_Parameters";
            this.toolStripMenuItem_Model_Parameters.Size = new System.Drawing.Size(115, 20);
            this.toolStripMenuItem_Model_Parameters.Text = "Model parameters";
            this.toolStripMenuItem_Model_Parameters.Click += new System.EventHandler(this.toolStripMenuItem_Model_Parameters_Click);
            // 
            // toolStripMenuItem_About
            // 
            this.toolStripMenuItem_About.Name = "toolStripMenuItem_About";
            this.toolStripMenuItem_About.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem_About.Text = "About...";
            this.toolStripMenuItem_About.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip_Parameters
            // 
            this.statusStrip_Parameters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_t,
            this.toolStripStatusLabel_Xd,
            this.toolStripStatusLabel_x,
            this.toolStripStatusLabel_Xmin,
            this.toolStripStatusLabel_Xmax,
            this.toolStripStatusLabel_H});
            this.statusStrip_Parameters.Location = new System.Drawing.Point(0, 395);
            this.statusStrip_Parameters.Name = "statusStrip_Parameters";
            this.statusStrip_Parameters.Size = new System.Drawing.Size(706, 24);
            this.statusStrip_Parameters.TabIndex = 1;
            this.statusStrip_Parameters.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_t
            // 
            this.toolStripStatusLabel_t.AutoSize = false;
            this.toolStripStatusLabel_t.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel_t.Name = "toolStripStatusLabel_t";
            this.toolStripStatusLabel_t.Size = new System.Drawing.Size(115, 19);
            this.toolStripStatusLabel_t.Text = "t = ";
            this.toolStripStatusLabel_t.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel_Xd
            // 
            this.toolStripStatusLabel_Xd.AutoSize = false;
            this.toolStripStatusLabel_Xd.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel_Xd.Name = "toolStripStatusLabel_Xd";
            this.toolStripStatusLabel_Xd.Size = new System.Drawing.Size(115, 19);
            this.toolStripStatusLabel_Xd.Text = "Xd = ";
            this.toolStripStatusLabel_Xd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel_x
            // 
            this.toolStripStatusLabel_x.AutoSize = false;
            this.toolStripStatusLabel_x.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel_x.Name = "toolStripStatusLabel_x";
            this.toolStripStatusLabel_x.Size = new System.Drawing.Size(115, 19);
            this.toolStripStatusLabel_x.Text = "X = ";
            this.toolStripStatusLabel_x.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel_Xmin
            // 
            this.toolStripStatusLabel_Xmin.AutoSize = false;
            this.toolStripStatusLabel_Xmin.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel_Xmin.Name = "toolStripStatusLabel_Xmin";
            this.toolStripStatusLabel_Xmin.Size = new System.Drawing.Size(115, 19);
            this.toolStripStatusLabel_Xmin.Text = "Xmin = ";
            this.toolStripStatusLabel_Xmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel_Xmax
            // 
            this.toolStripStatusLabel_Xmax.AutoSize = false;
            this.toolStripStatusLabel_Xmax.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel_Xmax.Name = "toolStripStatusLabel_Xmax";
            this.toolStripStatusLabel_Xmax.Size = new System.Drawing.Size(115, 19);
            this.toolStripStatusLabel_Xmax.Text = "Xmax = ";
            this.toolStripStatusLabel_Xmax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel_H
            // 
            this.toolStripStatusLabel_H.AutoSize = false;
            this.toolStripStatusLabel_H.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel_H.Name = "toolStripStatusLabel_H";
            this.toolStripStatusLabel_H.Size = new System.Drawing.Size(115, 19);
            this.toolStripStatusLabel_H.Text = "H = ";
            this.toolStripStatusLabel_H.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer_DisplayZone
            // 
            this.splitContainer_DisplayZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer_DisplayZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_DisplayZone.IsSplitterFixed = true;
            this.splitContainer_DisplayZone.Location = new System.Drawing.Point(0, 24);
            this.splitContainer_DisplayZone.Name = "splitContainer_DisplayZone";
            // 
            // splitContainer_DisplayZone.Panel1
            // 
            this.splitContainer_DisplayZone.Panel1.Controls.Add(this.panel_Computation_Controls);
            this.splitContainer_DisplayZone.Panel1.Controls.Add(this.checkBox_Controller);
            this.splitContainer_DisplayZone.Panel1.Controls.Add(this.checkBox_Pump);
            this.splitContainer_DisplayZone.Panel1.Controls.Add(this.trackBar_Xd);
            this.splitContainer_DisplayZone.Panel1.Controls.Add(this.pictureBox_WhiteBar);
            this.splitContainer_DisplayZone.Panel1.Controls.Add(this.pictureBox_BlueBar);
            this.splitContainer_DisplayZone.Panel1.Controls.Add(this.pictureBox_Backgroung);
            // 
            // splitContainer_DisplayZone.Panel2
            // 
            this.splitContainer_DisplayZone.Panel2.Controls.Add(this.panel_Tmax_Graph);
            this.splitContainer_DisplayZone.Panel2.Controls.Add(this.chart_Characteristics);
            this.splitContainer_DisplayZone.Size = new System.Drawing.Size(706, 371);
            this.splitContainer_DisplayZone.SplitterDistance = 239;
            this.splitContainer_DisplayZone.SplitterWidth = 6;
            this.splitContainer_DisplayZone.TabIndex = 2;
            // 
            // checkBox_Controller
            // 
            this.checkBox_Controller.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_Controller.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Controller.Location = new System.Drawing.Point(132, 30);
            this.checkBox_Controller.Name = "checkBox_Controller";
            this.checkBox_Controller.Size = new System.Drawing.Size(24, 24);
            this.checkBox_Controller.TabIndex = 8;
            this.checkBox_Controller.Text = "\tC";
            this.checkBox_Controller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip_Helper.SetToolTip(this.checkBox_Controller, "Turn the controller On / Off");
            this.checkBox_Controller.UseVisualStyleBackColor = false;
            // 
            // checkBox_Pump
            // 
            this.checkBox_Pump.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_Pump.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Pump.Location = new System.Drawing.Point(49, 54);
            this.checkBox_Pump.Name = "checkBox_Pump";
            this.checkBox_Pump.Size = new System.Drawing.Size(24, 24);
            this.checkBox_Pump.TabIndex = 7;
            this.checkBox_Pump.Text = "\tP";
            this.checkBox_Pump.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip_Helper.SetToolTip(this.checkBox_Pump, "Turn the pump On / Off");
            this.checkBox_Pump.UseVisualStyleBackColor = false;
            // 
            // trackBar_Xd
            // 
            this.trackBar_Xd.BackColor = System.Drawing.Color.White;
            this.trackBar_Xd.LargeChange = 10;
            this.trackBar_Xd.Location = new System.Drawing.Point(186, 111);
            this.trackBar_Xd.Maximum = 100;
            this.trackBar_Xd.Name = "trackBar_Xd";
            this.trackBar_Xd.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_Xd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar_Xd.RightToLeftLayout = true;
            this.trackBar_Xd.Size = new System.Drawing.Size(45, 162);
            this.trackBar_Xd.SmallChange = 5;
            this.trackBar_Xd.TabIndex = 6;
            this.trackBar_Xd.TickFrequency = 10;
            this.toolTip_Helper.SetToolTip(this.trackBar_Xd, "Adjust the desired water level");
            this.trackBar_Xd.ValueChanged += new System.EventHandler(this.trackBar_Xd_ValueChanged);
            // 
            // pictureBox_WhiteBar
            // 
            this.pictureBox_WhiteBar.BackColor = System.Drawing.Color.White;
            this.pictureBox_WhiteBar.Location = new System.Drawing.Point(84, 106);
            this.pictureBox_WhiteBar.Name = "pictureBox_WhiteBar";
            this.pictureBox_WhiteBar.Size = new System.Drawing.Size(72, 154);
            this.pictureBox_WhiteBar.TabIndex = 1;
            this.pictureBox_WhiteBar.TabStop = false;
            // 
            // pictureBox_BlueBar
            // 
            this.pictureBox_BlueBar.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBox_BlueBar.Location = new System.Drawing.Point(84, 106);
            this.pictureBox_BlueBar.Name = "pictureBox_BlueBar";
            this.pictureBox_BlueBar.Size = new System.Drawing.Size(72, 172);
            this.pictureBox_BlueBar.TabIndex = 2;
            this.pictureBox_BlueBar.TabStop = false;
            // 
            // pictureBox_Backgroung
            // 
            this.pictureBox_Backgroung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Backgroung.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Backgroung.Image")));
            this.pictureBox_Backgroung.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Backgroung.Name = "pictureBox_Backgroung";
            this.pictureBox_Backgroung.Size = new System.Drawing.Size(237, 369);
            this.pictureBox_Backgroung.TabIndex = 0;
            this.pictureBox_Backgroung.TabStop = false;
            // 
            // panel_Tmax_Graph
            // 
            this.panel_Tmax_Graph.AutoSize = true;
            this.panel_Tmax_Graph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Tmax_Graph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Tmax_Graph.Controls.Add(this.label_Tmax);
            this.panel_Tmax_Graph.Controls.Add(this.numericUpDown_Tmax);
            this.panel_Tmax_Graph.Location = new System.Drawing.Point(178, 305);
            this.panel_Tmax_Graph.Name = "panel_Tmax_Graph";
            this.panel_Tmax_Graph.Size = new System.Drawing.Size(102, 28);
            this.panel_Tmax_Graph.TabIndex = 3;
            // 
            // label_Tmax
            // 
            this.label_Tmax.AutoSize = true;
            this.label_Tmax.Location = new System.Drawing.Point(4, 5);
            this.label_Tmax.Name = "label_Tmax";
            this.label_Tmax.Size = new System.Drawing.Size(40, 13);
            this.label_Tmax.TabIndex = 4;
            this.label_Tmax.Text = "tmax, s";
            // 
            // numericUpDown_Tmax
            // 
            this.numericUpDown_Tmax.Location = new System.Drawing.Point(47, 3);
            this.numericUpDown_Tmax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Tmax.Name = "numericUpDown_Tmax";
            this.numericUpDown_Tmax.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_Tmax.TabIndex = 3;
            this.numericUpDown_Tmax.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_Tmax.ValueChanged += new System.EventHandler(this.numericUpDown_Tmax_ValueChanged);
            // 
            // chart_Characteristics
            // 
            this.chart_Characteristics.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            chartArea7.AxisX.MajorGrid.Interval = 0D;
            chartArea7.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea7.AxisX.MinorGrid.Interval = double.NaN;
            chartArea7.AxisX.ScaleView.Zoomable = false;
            chartArea7.AxisX.ScrollBar.Enabled = false;
            chartArea7.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea7.AxisX.Title = "t, s";
            chartArea7.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea7.AxisX2.ScaleView.Zoomable = false;
            chartArea7.AxisX2.ScrollBar.Enabled = false;
            chartArea7.AxisX2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea7.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea7.AxisY.ScaleView.Zoomable = false;
            chartArea7.AxisY.ScrollBar.Enabled = false;
            chartArea7.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea7.AxisY.Title = "x, m";
            chartArea7.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea7.AxisY2.MajorGrid.Interval = 0D;
            chartArea7.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea7.AxisY2.ScaleView.Zoomable = false;
            chartArea7.AxisY2.ScrollBar.Enabled = false;
            chartArea7.AxisY2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea7.AxisY2.Title = "U, V";
            chartArea7.AxisY2.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea7.Name = "ChartArea_Characteristics";
            this.chart_Characteristics.ChartAreas.Add(chartArea7);
            this.chart_Characteristics.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Alignment = System.Drawing.StringAlignment.Center;
            legend7.DockedToChartArea = "ChartArea_Characteristics";
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend7.IsDockedInsideChartArea = false;
            legend7.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend7.Name = "Legend_Characteristics";
            this.chart_Characteristics.Legends.Add(legend7);
            this.chart_Characteristics.Location = new System.Drawing.Point(0, 0);
            this.chart_Characteristics.Name = "chart_Characteristics";
            series31.BorderWidth = 2;
            series31.ChartArea = "ChartArea_Characteristics";
            series31.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series31.Color = System.Drawing.Color.Blue;
            series31.Legend = "Legend_Characteristics";
            series31.LegendText = "X(t), m";
            series31.LegendToolTip = "The level of the water in tank X(t), m";
            series31.Name = "Series_X";
            series31.ToolTip = "The level of the water in tank X(t), m";
            series32.BorderWidth = 2;
            series32.ChartArea = "ChartArea_Characteristics";
            series32.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series32.Color = System.Drawing.Color.Black;
            series32.Legend = "Legend_Characteristics";
            series32.LegendText = "Xd(t), m";
            series32.LegendToolTip = "Desired level of the water Xd(t), m";
            series32.Name = "Series_Xd";
            series32.ToolTip = "Desired level of the water Xd(t), m";
            series33.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series33.BorderWidth = 2;
            series33.ChartArea = "ChartArea_Characteristics";
            series33.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series33.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series33.LabelToolTip = "Xmin, m";
            series33.Legend = "Legend_Characteristics";
            series33.LegendText = "Xmin, m";
            series33.LegendToolTip = "Minimum desired level Xmin, m";
            series33.Name = "Series_Xmin";
            series33.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series33.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)(((((((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Right) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Left) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopRight) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomLeft) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomRight)));
            series33.ToolTip = "Minimum desired level Xmin, m";
            series34.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series34.BorderWidth = 2;
            series34.ChartArea = "ChartArea_Characteristics";
            series34.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series34.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series34.Legend = "Legend_Characteristics";
            series34.LegendText = "Xmax, m";
            series34.LegendToolTip = "Maximum desired level Xmax, m";
            series34.Name = "Series_Xmax";
            series34.ToolTip = "Maximum desired level Xmax, m";
            series35.BorderWidth = 2;
            series35.ChartArea = "ChartArea_Characteristics";
            series35.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series35.Color = System.Drawing.Color.Red;
            series35.Legend = "Legend_Characteristics";
            series35.LegendText = "U(t), V";
            series35.LegendToolTip = "The voltage aplied to the pump U(t), V";
            series35.Name = "Series_U";
            series35.ToolTip = "The voltage aplied to the pump U(t), V";
            series35.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart_Characteristics.Series.Add(series31);
            this.chart_Characteristics.Series.Add(series32);
            this.chart_Characteristics.Series.Add(series33);
            this.chart_Characteristics.Series.Add(series34);
            this.chart_Characteristics.Series.Add(series35);
            this.chart_Characteristics.Size = new System.Drawing.Size(459, 369);
            this.chart_Characteristics.TabIndex = 0;
            title7.Name = "Title1";
            title7.Text = "Water tank characteristics";
            this.chart_Characteristics.Titles.Add(title7);
            // 
            // panel_Computation_Controls
            // 
            this.panel_Computation_Controls.AutoSize = true;
            this.panel_Computation_Controls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Computation_Controls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Computation_Controls.Controls.Add(this.checkBox_Draw);
            this.panel_Computation_Controls.Controls.Add(this.radioButton_Restart);
            this.panel_Computation_Controls.Controls.Add(this.radioButton_Stop);
            this.panel_Computation_Controls.Controls.Add(this.radioButton_Start);
            this.panel_Computation_Controls.Location = new System.Drawing.Point(59, 327);
            this.panel_Computation_Controls.Name = "panel_Computation_Controls";
            this.panel_Computation_Controls.Size = new System.Drawing.Size(123, 32);
            this.panel_Computation_Controls.TabIndex = 13;
            // 
            // checkBox_Draw
            // 
            this.checkBox_Draw.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_Draw.Checked = true;
            this.checkBox_Draw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Draw.Location = new System.Drawing.Point(94, 3);
            this.checkBox_Draw.Name = "checkBox_Draw";
            this.checkBox_Draw.Size = new System.Drawing.Size(24, 24);
            this.checkBox_Draw.TabIndex = 16;
            this.checkBox_Draw.Text = "\t🌢";
            this.toolTip_Helper.SetToolTip(this.checkBox_Draw, "Turn the graphics On / Off");
            this.checkBox_Draw.UseVisualStyleBackColor = true;
            this.checkBox_Draw.CheckedChanged += new System.EventHandler(this.checkBox_Draw_CheckedChanged);
            // 
            // radioButton_Restart
            // 
            this.radioButton_Restart.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_Restart.Checked = true;
            this.radioButton_Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Restart.Location = new System.Drawing.Point(3, 3);
            this.radioButton_Restart.Name = "radioButton_Restart";
            this.radioButton_Restart.Size = new System.Drawing.Size(24, 24);
            this.radioButton_Restart.TabIndex = 15;
            this.radioButton_Restart.TabStop = true;
            this.radioButton_Restart.Text = "🔁";
            this.radioButton_Restart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip_Helper.SetToolTip(this.radioButton_Restart, "Restart");
            this.radioButton_Restart.UseVisualStyleBackColor = false;
            this.radioButton_Restart.CheckedChanged += new System.EventHandler(this.radioButton_Restart_CheckedChanged);
            // 
            // radioButton_Stop
            // 
            this.radioButton_Stop.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Stop.Location = new System.Drawing.Point(63, 3);
            this.radioButton_Stop.Name = "radioButton_Stop";
            this.radioButton_Stop.Size = new System.Drawing.Size(24, 24);
            this.radioButton_Stop.TabIndex = 14;
            this.radioButton_Stop.Text = "⏹";
            this.radioButton_Stop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip_Helper.SetToolTip(this.radioButton_Stop, "Pause");
            this.radioButton_Stop.UseVisualStyleBackColor = false;
            this.radioButton_Stop.CheckedChanged += new System.EventHandler(this.radioButton_Stop_CheckedChanged);
            // 
            // radioButton_Start
            // 
            this.radioButton_Start.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Start.Location = new System.Drawing.Point(33, 3);
            this.radioButton_Start.Name = "radioButton_Start";
            this.radioButton_Start.Size = new System.Drawing.Size(24, 24);
            this.radioButton_Start.TabIndex = 13;
            this.radioButton_Start.Text = "▶";
            this.radioButton_Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip_Helper.SetToolTip(this.radioButton_Start, "Start or continue");
            this.radioButton_Start.UseVisualStyleBackColor = false;
            this.radioButton_Start.CheckedChanged += new System.EventHandler(this.radioButton_Start_CheckedChanged);
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 419);
            this.Controls.Add(this.splitContainer_DisplayZone);
            this.Controls.Add(this.statusStrip_Parameters);
            this.Controls.Add(this.menuStrip_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Water Tank Benchmark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_Main_FormClosing);
            this.Shown += new System.EventHandler(this.form_Main_Shown);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.statusStrip_Parameters.ResumeLayout(false);
            this.statusStrip_Parameters.PerformLayout();
            this.splitContainer_DisplayZone.Panel1.ResumeLayout(false);
            this.splitContainer_DisplayZone.Panel1.PerformLayout();
            this.splitContainer_DisplayZone.Panel2.ResumeLayout(false);
            this.splitContainer_DisplayZone.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_DisplayZone)).EndInit();
            this.splitContainer_DisplayZone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Xd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WhiteBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BlueBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Backgroung)).EndInit();
            this.panel_Tmax_Graph.ResumeLayout(false);
            this.panel_Tmax_Graph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Tmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Characteristics)).EndInit();
            this.panel_Computation_Controls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Model_Parameters;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_About;
        private System.Windows.Forms.StatusStrip statusStrip_Parameters;
        private System.Windows.Forms.SplitContainer splitContainer_DisplayZone;
        private System.Windows.Forms.PictureBox pictureBox_Backgroung;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Characteristics;
        private System.Windows.Forms.TrackBar trackBar_Xd;
        private System.Windows.Forms.PictureBox pictureBox_WhiteBar;
        private System.Windows.Forms.PictureBox pictureBox_BlueBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_t;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Xd;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Xmin;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Xmax;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_H;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_x;
        private System.Windows.Forms.CheckBox checkBox_Controller;
        private System.Windows.Forms.CheckBox checkBox_Pump;
        private System.Windows.Forms.ToolTip toolTip_Helper;
        private System.Windows.Forms.Panel panel_Tmax_Graph;
        private System.Windows.Forms.Label label_Tmax;
        private System.Windows.Forms.NumericUpDown numericUpDown_Tmax;
        private System.Windows.Forms.Panel panel_Computation_Controls;
        private System.Windows.Forms.CheckBox checkBox_Draw;
        private System.Windows.Forms.RadioButton radioButton_Restart;
        private System.Windows.Forms.RadioButton radioButton_Stop;
        private System.Windows.Forms.RadioButton radioButton_Start;
    }
}

