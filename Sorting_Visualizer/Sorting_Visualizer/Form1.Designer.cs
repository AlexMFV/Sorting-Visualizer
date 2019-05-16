namespace Sorting_Visualizer
{
    partial class Form1
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbAlgos = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TrackBar();
            this.btnFastSort = new System.Windows.Forms.Button();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTime)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.LightGray;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.cbbAlgos);
            this.mainPanel.Controls.Add(this.btnSort);
            this.mainPanel.Controls.Add(this.lblTime);
            this.mainPanel.Controls.Add(this.tbTime);
            this.mainPanel.Controls.Add(this.btnFastSort);
            this.mainPanel.Controls.Add(this.btnRandomize);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainPanel.Location = new System.Drawing.Point(984, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(280, 681);
            this.mainPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Algorithms:";
            // 
            // cbbAlgos
            // 
            this.cbbAlgos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAlgos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbbAlgos.FormattingEnabled = true;
            this.cbbAlgos.Items.AddRange(new object[] {
            "Selection Sort",
            "Insertion Sort"});
            this.cbbAlgos.Location = new System.Drawing.Point(11, 24);
            this.cbbAlgos.MaxDropDownItems = 15;
            this.cbbAlgos.Name = "cbbAlgos";
            this.cbbAlgos.Size = new System.Drawing.Size(254, 21);
            this.cbbAlgos.TabIndex = 5;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(13, 506);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(253, 71);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort using Algorithm";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(19, 440);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(61, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time: 40ms";
            // 
            // tbTime
            // 
            this.tbTime.LargeChange = 100;
            this.tbTime.Location = new System.Drawing.Point(13, 459);
            this.tbTime.Maximum = 1000;
            this.tbTime.Minimum = 10;
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(254, 45);
            this.tbTime.SmallChange = 10;
            this.tbTime.TabIndex = 2;
            this.tbTime.TickFrequency = 10;
            this.tbTime.Value = 40;
            this.tbTime.ValueChanged += new System.EventHandler(this.tbTime_ValueChanged);
            // 
            // btnFastSort
            // 
            this.btnFastSort.Location = new System.Drawing.Point(13, 583);
            this.btnFastSort.Name = "btnFastSort";
            this.btnFastSort.Size = new System.Drawing.Size(253, 40);
            this.btnFastSort.TabIndex = 1;
            this.btnFastSort.Text = "Instant Sort (No Algorithm)";
            this.btnFastSort.UseVisualStyleBackColor = true;
            this.btnFastSort.Click += new System.EventHandler(this.btnFastSort_Click);
            // 
            // btnRandomize
            // 
            this.btnRandomize.Location = new System.Drawing.Point(13, 629);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(253, 40);
            this.btnRandomize.TabIndex = 0;
            this.btnRandomize.Text = "Randomize";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 681);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sorting Visualizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnFastSort;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TrackBar tbTime;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbAlgos;
    }
}

