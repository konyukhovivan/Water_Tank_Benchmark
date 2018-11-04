namespace Water_Tank_Benchmark
{
    partial class form_Settings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Default = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_Accept = new System.Windows.Forms.Button();
            this.button_Reject = new System.Windows.Forms.Button();
            this.propertyGrid_Settings = new System.Windows.Forms.PropertyGrid();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Default);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 370);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(284, 35);
            this.panel1.TabIndex = 0;
            // 
            // button_Default
            // 
            this.button_Default.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Default.Location = new System.Drawing.Point(2, 2);
            this.button_Default.Name = "button_Default";
            this.button_Default.Size = new System.Drawing.Size(280, 31);
            this.button_Default.TabIndex = 0;
            this.button_Default.Text = "Set as in the article";
            this.button_Default.UseVisualStyleBackColor = true;
            this.button_Default.Click += new System.EventHandler(this.button_Default_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 37);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_Accept);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button_Reject);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Size = new System.Drawing.Size(284, 37);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_Accept
            // 
            this.button_Accept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Accept.Location = new System.Drawing.Point(2, 2);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(136, 33);
            this.button_Accept.TabIndex = 0;
            this.button_Accept.Text = "Accept changes";
            this.button_Accept.UseVisualStyleBackColor = true;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // button_Reject
            // 
            this.button_Reject.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Reject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Reject.Location = new System.Drawing.Point(2, 2);
            this.button_Reject.Name = "button_Reject";
            this.button_Reject.Size = new System.Drawing.Size(136, 33);
            this.button_Reject.TabIndex = 1;
            this.button_Reject.Text = "Reject changes";
            this.button_Reject.UseVisualStyleBackColor = true;
            this.button_Reject.Click += new System.EventHandler(this.button_Reject_Click);
            // 
            // propertyGrid_Settings
            // 
            this.propertyGrid_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid_Settings.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid_Settings.Name = "propertyGrid_Settings";
            this.propertyGrid_Settings.Size = new System.Drawing.Size(284, 333);
            this.propertyGrid_Settings.TabIndex = 2;
            this.propertyGrid_Settings.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid_Settings_PropertyValueChanged);
            // 
            // form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Reject;
            this.ClientSize = new System.Drawing.Size(284, 405);
            this.ControlBox = false;
            this.Controls.Add(this.propertyGrid_Settings);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parameters of the objects";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Default;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.Button button_Reject;
        private System.Windows.Forms.PropertyGrid propertyGrid_Settings;
    }
}