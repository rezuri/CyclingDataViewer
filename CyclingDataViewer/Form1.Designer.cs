namespace CyclingDataViewer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGetFiles1 = new System.Windows.Forms.Button();
            this.lblFile1 = new System.Windows.Forms.Label();
            this.lblFile2 = new System.Windows.Forms.Label();
            this.btnGetFiles2 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGetFiles1
            // 
            this.btnGetFiles1.Location = new System.Drawing.Point(29, 47);
            this.btnGetFiles1.Name = "btnGetFiles1";
            this.btnGetFiles1.Size = new System.Drawing.Size(75, 36);
            this.btnGetFiles1.TabIndex = 0;
            this.btnGetFiles1.Text = "button1";
            this.btnGetFiles1.UseVisualStyleBackColor = true;
            this.btnGetFiles1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFile1
            // 
            this.lblFile1.AutoSize = true;
            this.lblFile1.Location = new System.Drawing.Point(144, 55);
            this.lblFile1.Name = "lblFile1";
            this.lblFile1.Size = new System.Drawing.Size(51, 20);
            this.lblFile1.TabIndex = 1;
            this.lblFile1.Text = "label1";
            // 
            // lblFile2
            // 
            this.lblFile2.AutoSize = true;
            this.lblFile2.Location = new System.Drawing.Point(144, 184);
            this.lblFile2.Name = "lblFile2";
            this.lblFile2.Size = new System.Drawing.Size(51, 20);
            this.lblFile2.TabIndex = 3;
            this.lblFile2.Text = "label1";
            // 
            // btnGetFiles2
            // 
            this.btnGetFiles2.Location = new System.Drawing.Point(29, 176);
            this.btnGetFiles2.Name = "btnGetFiles2";
            this.btnGetFiles2.Size = new System.Drawing.Size(75, 36);
            this.btnGetFiles2.TabIndex = 2;
            this.btnGetFiles2.Text = "button2";
            this.btnGetFiles2.UseVisualStyleBackColor = true;
            this.btnGetFiles2.Click += new System.EventHandler(this.btnGetFiles2_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(29, 291);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 47);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "button1";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(249, 55);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(935, 698);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 818);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblFile2);
            this.Controls.Add(this.btnGetFiles2);
            this.Controls.Add(this.lblFile1);
            this.Controls.Add(this.btnGetFiles1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGetFiles1;
        private System.Windows.Forms.Label lblFile1;
        private System.Windows.Forms.Label lblFile2;
        private System.Windows.Forms.Button btnGetFiles2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

