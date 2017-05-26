namespace WeatherWebservicex
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
            this.btnShowWeather = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxCounty = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtBxCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowWeather
            // 
            this.btnShowWeather.Location = new System.Drawing.Point(27, 250);
            this.btnShowWeather.Name = "btnShowWeather";
            this.btnShowWeather.Size = new System.Drawing.Size(138, 23);
            this.btnShowWeather.TabIndex = 0;
            this.btnShowWeather.Text = "Show Weather";
            this.btnShowWeather.UseVisualStyleBackColor = true;
            this.btnShowWeather.Click += new System.EventHandler(this.btnShowWeather_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBxCounty
            // 
            this.txtBxCounty.Location = new System.Drawing.Point(104, 42);
            this.txtBxCounty.Name = "txtBxCounty";
            this.txtBxCounty.Size = new System.Drawing.Size(240, 20);
            this.txtBxCounty.TabIndex = 3;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(24, 92);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(37, 13);
            this.Result.TabIndex = 4;
            this.Result.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(101, 92);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBxCity
            // 
            this.txtBxCity.Location = new System.Drawing.Point(104, 12);
            this.txtBxCity.Name = "txtBxCity";
            this.txtBxCity.Size = new System.Drawing.Size(240, 20);
            this.txtBxCity.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "City";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 285);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxCity);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.txtBxCounty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowWeather);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowWeather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxCounty;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtBxCity;
        private System.Windows.Forms.Label label2;
    }
}

