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
            this.btnUpdateSize = new System.Windows.Forms.Button();
            this.nupArraySize = new System.Windows.Forms.NumericUpDown();
            this.lblArray = new System.Windows.Forms.Label();
            this.btnResetMS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbAlgos = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TrackBar();
            this.btnFastSort = new System.Windows.Forms.Button();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupArraySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.LightGray;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.btnUpdateSize);
            this.mainPanel.Controls.Add(this.nupArraySize);
            this.mainPanel.Controls.Add(this.lblArray);
            this.mainPanel.Controls.Add(this.btnResetMS);
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
            // btnUpdateSize
            // 
            this.btnUpdateSize.Location = new System.Drawing.Point(107, 75);
            this.btnUpdateSize.Name = "btnUpdateSize";
            this.btnUpdateSize.Size = new System.Drawing.Size(158, 23);
            this.btnUpdateSize.TabIndex = 10;
            this.btnUpdateSize.Text = "Update Size";
            this.btnUpdateSize.UseVisualStyleBackColor = true;
            this.btnUpdateSize.Click += new System.EventHandler(this.btnUpdateSize_Click);
            // 
            // nupArraySize
            // 
            this.nupArraySize.Location = new System.Drawing.Point(13, 78);
            this.nupArraySize.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nupArraySize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nupArraySize.Name = "nupArraySize";
            this.nupArraySize.Size = new System.Drawing.Size(87, 20);
            this.nupArraySize.TabIndex = 9;
            this.nupArraySize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupArraySize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Location = new System.Drawing.Point(11, 61);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(57, 13);
            this.lblArray.TabIndex = 8;
            this.lblArray.Text = "Array Size:";
            // 
            // btnResetMS
            // 
            this.btnResetMS.Location = new System.Drawing.Point(85, 436);
            this.btnResetMS.Name = "btnResetMS";
            this.btnResetMS.Size = new System.Drawing.Size(75, 23);
            this.btnResetMS.TabIndex = 7;
            this.btnResetMS.Text = "Reset Time";
            this.btnResetMS.UseVisualStyleBackColor = true;
            this.btnResetMS.Click += new System.EventHandler(this.btnResetMS_Click);
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
            "Insertion Sort",
            "Bogo Sort",
            "Bubble Sort"});
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 681);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sorting Visualizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupArraySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnFastSort;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TrackBar tbTime;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbAlgos;
        private System.Windows.Forms.Button btnResetMS;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.NumericUpDown nupArraySize;
        private System.Windows.Forms.Button btnUpdateSize;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

