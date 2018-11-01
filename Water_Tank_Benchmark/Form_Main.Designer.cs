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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Main));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_Settings = new System.Windows.Forms.ToolStripMenuItem();
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
            this.chart_Characteristics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radioButton_Start = new System.Windows.Forms.RadioButton();
            this.radioButton_Stop = new System.Windows.Forms.RadioButton();
            this.radioButton_Restart = new System.Windows.Forms.RadioButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.chart_Characteristics)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Settings,
            this.toolStripMenuItem_About});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(720, 24);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // toolStripMenuItem_Settings
            // 
            this.toolStripMenuItem_Settings.Name = "toolStripMenuItem_Settings";
            this.toolStripMenuItem_Settings.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem_Settings.Text = "Settings";
            this.toolStripMenuItem_Settings.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
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
            this.statusStrip_Parameters.Size = new System.Drawing.Size(720, 24);
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
            this.splitContainer_DisplayZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_DisplayZone.Location = new System.Drawing.Point(0, 24);
            this.splitContainer_DisplayZone.Name = "splitContainer_DisplayZone";
            // 
            // splitContainer_DisplayZone.Panel1
            // 
            this.splitContainer_DisplayZone.Panel1.Controls.Add(this.radioButton_Restart);
            this.splitContainer_DisplayZone.Panel1.Controls.Add(this.radioButton_Stop);
            this.splitContainer_DisplayZone.Panel1.Controls.Add(this.radioButton_Start);
            this.splitContainer_DisplayZone.Panel1.Controls.Add(this.checkBox_Controller);
            this.splitContainer_DisplayZone.Panel1.Controls.Add(this.checkBox_Pump);
            this.splitContainer_DisplayZone.Panel1.Controls.Add(this.trackBar_Xd);
            this.splitContainer_DisplayZone.Panel1.Controls.Add(this.pictureBox_WhiteBar);
            this.splitContainer_DisplayZone.Panel1.Controls.Add(this.pictureBox_BlueBar);
            this.splitContainer_DisplayZone.Panel1.Controls.Add(this.pictureBox_Backgroung);
            // 
            // splitContainer_DisplayZone.Panel2
            // 
            this.splitContainer_DisplayZone.Panel2.Controls.Add(this.chart_Characteristics);
            this.splitContainer_DisplayZone.Size = new System.Drawing.Size(720, 371);
            this.splitContainer_DisplayZone.SplitterDistance = 238;
            this.splitContainer_DisplayZone.TabIndex = 2;
            // 
            // checkBox_Controller
            // 
            this.checkBox_Controller.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_Controller.BackColor = System.Drawing.Color.White;
            this.checkBox_Controller.Checked = true;
            this.checkBox_Controller.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Controller.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Controller.Location = new System.Drawing.Point(132, 30);
            this.checkBox_Controller.Name = "checkBox_Controller";
            this.checkBox_Controller.Size = new System.Drawing.Size(24, 24);
            this.checkBox_Controller.TabIndex = 8;
            this.checkBox_Controller.Text = "C";
            this.checkBox_Controller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_Controller.UseVisualStyleBackColor = false;
            // 
            // checkBox_Pump
            // 
            this.checkBox_Pump.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_Pump.BackColor = System.Drawing.Color.White;
            this.checkBox_Pump.Checked = true;
            this.checkBox_Pump.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Pump.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Pump.Location = new System.Drawing.Point(49, 54);
            this.checkBox_Pump.Name = "checkBox_Pump";
            this.checkBox_Pump.Size = new System.Drawing.Size(24, 24);
            this.checkBox_Pump.TabIndex = 7;
            this.checkBox_Pump.Text = "P";
            this.checkBox_Pump.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // pictureBox_WhiteBar
            // 
            this.pictureBox_WhiteBar.BackColor = System.Drawing.Color.White;
            this.pictureBox_WhiteBar.Location = new System.Drawing.Point(84, 106);
            this.pictureBox_WhiteBar.Name = "pictureBox_WhiteBar";
            this.pictureBox_WhiteBar.Size = new System.Drawing.Size(72, 122);
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
            this.pictureBox_Backgroung.Size = new System.Drawing.Size(238, 371);
            this.pictureBox_Backgroung.TabIndex = 0;
            this.pictureBox_Backgroung.TabStop = false;
            // 
            // chart_Characteristics
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_Characteristics.ChartAreas.Add(chartArea2);
            this.chart_Characteristics.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart_Characteristics.Legends.Add(legend2);
            this.chart_Characteristics.Location = new System.Drawing.Point(0, 0);
            this.chart_Characteristics.Name = "chart_Characteristics";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.DodgerBlue;
            series4.Legend = "Legend1";
            series4.LegendText = "X(t), m";
            series4.Name = "Series_X";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.IndianRed;
            series5.Legend = "Legend1";
            series5.LegendText = "U(t), V";
            series5.Name = "Series_U";
            series5.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series6.Legend = "Legend1";
            series6.LegendText = "Xd(t), m";
            series6.Name = "Series_Xd";
            this.chart_Characteristics.Series.Add(series4);
            this.chart_Characteristics.Series.Add(series5);
            this.chart_Characteristics.Series.Add(series6);
            this.chart_Characteristics.Size = new System.Drawing.Size(478, 371);
            this.chart_Characteristics.TabIndex = 0;
            title2.Name = "Title1";
            title2.Text = "Water tank characteristics";
            this.chart_Characteristics.Titles.Add(title2);
            // 
            // radioButton_Start
            // 
            this.radioButton_Start.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_Start.BackColor = System.Drawing.Color.White;
            this.radioButton_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Start.Location = new System.Drawing.Point(109, 327);
            this.radioButton_Start.Name = "radioButton_Start";
            this.radioButton_Start.Size = new System.Drawing.Size(24, 24);
            this.radioButton_Start.TabIndex = 9;
            this.radioButton_Start.Text = "▶";
            this.radioButton_Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_Start.UseVisualStyleBackColor = false;
            // 
            // radioButton_Stop
            // 
            this.radioButton_Stop.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_Stop.BackColor = System.Drawing.Color.White;
            this.radioButton_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Stop.Location = new System.Drawing.Point(140, 327);
            this.radioButton_Stop.Name = "radioButton_Stop";
            this.radioButton_Stop.Size = new System.Drawing.Size(24, 24);
            this.radioButton_Stop.TabIndex = 10;
            this.radioButton_Stop.Text = "⏹";
            this.radioButton_Stop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton_Stop.UseVisualStyleBackColor = false;
            // 
            // radioButton_Restart
            // 
            this.radioButton_Restart.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_Restart.BackColor = System.Drawing.Color.White;
            this.radioButton_Restart.Checked = true;
            this.radioButton_Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Restart.Location = new System.Drawing.Point(79, 327);
            this.radioButton_Restart.Name = "radioButton_Restart";
            this.radioButton_Restart.Size = new System.Drawing.Size(24, 24);
            this.radioButton_Restart.TabIndex = 11;
            this.radioButton_Restart.TabStop = true;
            this.radioButton_Restart.Text = "🔁";
            this.radioButton_Restart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_Restart.UseVisualStyleBackColor = false;
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 419);
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
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.statusStrip_Parameters.ResumeLayout(false);
            this.statusStrip_Parameters.PerformLayout();
            this.splitContainer_DisplayZone.Panel1.ResumeLayout(false);
            this.splitContainer_DisplayZone.Panel1.PerformLayout();
            this.splitContainer_DisplayZone.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_DisplayZone)).EndInit();
            this.splitContainer_DisplayZone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Xd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WhiteBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BlueBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Backgroung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Characteristics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Settings;
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
        private System.Windows.Forms.RadioButton radioButton_Restart;
        private System.Windows.Forms.RadioButton radioButton_Stop;
        private System.Windows.Forms.RadioButton radioButton_Start;
    }
}

