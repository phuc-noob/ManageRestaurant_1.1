﻿namespace ManageRestaurent1._1
{
    partial class staticMonth
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2Button_day = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_month = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_money = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart_day = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_day)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button_day
            // 
            this.guna2Button_day.BorderRadius = 5;
            this.guna2Button_day.CheckedState.Parent = this.guna2Button_day;
            this.guna2Button_day.CustomImages.Parent = this.guna2Button_day;
            this.guna2Button_day.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button_day.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2Button_day.HoverState.Parent = this.guna2Button_day;
            this.guna2Button_day.Location = new System.Drawing.Point(1085, 699);
            this.guna2Button_day.Name = "guna2Button_day";
            this.guna2Button_day.ShadowDecoration.Parent = this.guna2Button_day;
            this.guna2Button_day.Size = new System.Drawing.Size(180, 45);
            this.guna2Button_day.TabIndex = 14;
            this.guna2Button_day.Text = "Static Day";
            this.guna2Button_day.Click += new System.EventHandler(this.guna2Button_day_Click);
            // 
            // guna2Button_month
            // 
            this.guna2Button_month.BorderRadius = 5;
            this.guna2Button_month.CheckedState.Parent = this.guna2Button_month;
            this.guna2Button_month.CustomImages.Parent = this.guna2Button_month;
            this.guna2Button_month.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2Button_month.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_month.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button_month.HoverState.Parent = this.guna2Button_month;
            this.guna2Button_month.Location = new System.Drawing.Point(1085, 620);
            this.guna2Button_month.Name = "guna2Button_month";
            this.guna2Button_month.ShadowDecoration.Parent = this.guna2Button_month;
            this.guna2Button_month.Size = new System.Drawing.Size(180, 45);
            this.guna2Button_month.TabIndex = 13;
            this.guna2Button_month.Text = "Static Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1201, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "vnđ";
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_money.Location = new System.Drawing.Point(1030, 484);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(100, 32);
            this.label_money.TabIndex = 11;
            this.label_money.Text = "00000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(915, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total :";
            // 
            // chart_day
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_day.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_day.Legends.Add(legend1);
            this.chart_day.Location = new System.Drawing.Point(35, 5);
            this.chart_day.Name = "chart_day";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "money";
            this.chart_day.Series.Add(series1);
            this.chart_day.Size = new System.Drawing.Size(1426, 476);
            this.chart_day.TabIndex = 9;
            this.chart_day.Text = "chart1";
            // 
            // staticMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.guna2Button_day);
            this.Controls.Add(this.guna2Button_month);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_money);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart_day);
            this.Name = "staticMonth";
            this.Size = new System.Drawing.Size(1479, 893);
            this.Load += new System.EventHandler(this.staticMonth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_day)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button_day;
        private Guna.UI2.WinForms.Guna2Button guna2Button_month;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label_money;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart_day;
    }
}
