namespace WeatherStation
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.txt_Temperature = new System.Windows.Forms.TextBox();
            this.txt_Humidity = new System.Windows.Forms.TextBox();
            this.txt_Pressure = new System.Windows.Forms.TextBox();
            this.lbl_TemperatureInput = new System.Windows.Forms.Label();
            this.lbl_HumidityInput = new System.Windows.Forms.Label();
            this.lbl_PressureInput = new System.Windows.Forms.Label();
            this.list_currentReadings = new System.Windows.Forms.ListBox();
            this.list_Average = new System.Windows.Forms.ListBox();
            this.list_Forecast = new System.Windows.Forms.ListBox();
            this.lbl_Temp = new System.Windows.Forms.Label();
            this.lbl_averageReadings = new System.Windows.Forms.Label();
            this.lbl_Forecast = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(35, 31);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(240, 56);
            this.btn_Update.TabIndex = 0;
            this.btn_Update.Text = "Update Measurements";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_Temperature
            // 
            this.txt_Temperature.Location = new System.Drawing.Point(35, 148);
            this.txt_Temperature.Name = "txt_Temperature";
            this.txt_Temperature.Size = new System.Drawing.Size(240, 20);
            this.txt_Temperature.TabIndex = 1;
            // 
            // txt_Humidity
            // 
            this.txt_Humidity.Location = new System.Drawing.Point(35, 224);
            this.txt_Humidity.Name = "txt_Humidity";
            this.txt_Humidity.Size = new System.Drawing.Size(240, 20);
            this.txt_Humidity.TabIndex = 2;
            // 
            // txt_Pressure
            // 
            this.txt_Pressure.Location = new System.Drawing.Point(35, 307);
            this.txt_Pressure.Name = "txt_Pressure";
            this.txt_Pressure.Size = new System.Drawing.Size(240, 20);
            this.txt_Pressure.TabIndex = 3;
            // 
            // lbl_TemperatureInput
            // 
            this.lbl_TemperatureInput.AutoSize = true;
            this.lbl_TemperatureInput.Location = new System.Drawing.Point(35, 129);
            this.lbl_TemperatureInput.Name = "lbl_TemperatureInput";
            this.lbl_TemperatureInput.Size = new System.Drawing.Size(80, 13);
            this.lbl_TemperatureInput.TabIndex = 4;
            this.lbl_TemperatureInput.Text = "Temperature(C)";
            // 
            // lbl_HumidityInput
            // 
            this.lbl_HumidityInput.AutoSize = true;
            this.lbl_HumidityInput.Location = new System.Drawing.Point(35, 205);
            this.lbl_HumidityInput.Name = "lbl_HumidityInput";
            this.lbl_HumidityInput.Size = new System.Drawing.Size(47, 13);
            this.lbl_HumidityInput.TabIndex = 5;
            this.lbl_HumidityInput.Text = "Humidity";
            // 
            // lbl_PressureInput
            // 
            this.lbl_PressureInput.AutoSize = true;
            this.lbl_PressureInput.Location = new System.Drawing.Point(35, 288);
            this.lbl_PressureInput.Name = "lbl_PressureInput";
            this.lbl_PressureInput.Size = new System.Drawing.Size(101, 13);
            this.lbl_PressureInput.TabIndex = 6;
            this.lbl_PressureInput.Text = "Barometric Pressure";
            // 
            // list_currentReadings
            // 
            this.list_currentReadings.FormattingEnabled = true;
            this.list_currentReadings.Location = new System.Drawing.Point(331, 47);
            this.list_currentReadings.Name = "list_currentReadings";
            this.list_currentReadings.Size = new System.Drawing.Size(402, 95);
            this.list_currentReadings.TabIndex = 7;
            // 
            // list_Average
            // 
            this.list_Average.FormattingEnabled = true;
            this.list_Average.Location = new System.Drawing.Point(331, 198);
            this.list_Average.Name = "list_Average";
            this.list_Average.Size = new System.Drawing.Size(402, 95);
            this.list_Average.TabIndex = 8;
            // 
            // list_Forecast
            // 
            this.list_Forecast.FormattingEnabled = true;
            this.list_Forecast.Location = new System.Drawing.Point(331, 344);
            this.list_Forecast.Name = "list_Forecast";
            this.list_Forecast.Size = new System.Drawing.Size(402, 95);
            this.list_Forecast.TabIndex = 9;
            // 
            // lbl_Temp
            // 
            this.lbl_Temp.AutoSize = true;
            this.lbl_Temp.Location = new System.Drawing.Point(331, 28);
            this.lbl_Temp.Name = "lbl_Temp";
            this.lbl_Temp.Size = new System.Drawing.Size(80, 13);
            this.lbl_Temp.TabIndex = 10;
            this.lbl_Temp.Text = "Temperature(C)";
            // 
            // lbl_averageReadings
            // 
            this.lbl_averageReadings.AutoSize = true;
            this.lbl_averageReadings.Location = new System.Drawing.Point(331, 179);
            this.lbl_averageReadings.Name = "lbl_averageReadings";
            this.lbl_averageReadings.Size = new System.Drawing.Size(95, 13);
            this.lbl_averageReadings.TabIndex = 11;
            this.lbl_averageReadings.Text = "Average Readings";
            // 
            // lbl_Forecast
            // 
            this.lbl_Forecast.AutoSize = true;
            this.lbl_Forecast.Location = new System.Drawing.Point(331, 325);
            this.lbl_Forecast.Name = "lbl_Forecast";
            this.lbl_Forecast.Size = new System.Drawing.Size(48, 13);
            this.lbl_Forecast.TabIndex = 12;
            this.lbl_Forecast.Text = "Forecast";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 578);
            this.Controls.Add(this.lbl_Forecast);
            this.Controls.Add(this.lbl_averageReadings);
            this.Controls.Add(this.lbl_Temp);
            this.Controls.Add(this.list_Forecast);
            this.Controls.Add(this.list_Average);
            this.Controls.Add(this.list_currentReadings);
            this.Controls.Add(this.lbl_PressureInput);
            this.Controls.Add(this.lbl_HumidityInput);
            this.Controls.Add(this.lbl_TemperatureInput);
            this.Controls.Add(this.txt_Pressure);
            this.Controls.Add(this.txt_Humidity);
            this.Controls.Add(this.txt_Temperature);
            this.Controls.Add(this.btn_Update);
            this.Name = "Form1";
            this.Text = "Forecast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txt_Temperature;
        private System.Windows.Forms.TextBox txt_Humidity;
        private System.Windows.Forms.TextBox txt_Pressure;
        private System.Windows.Forms.Label lbl_TemperatureInput;
        private System.Windows.Forms.Label lbl_HumidityInput;
        private System.Windows.Forms.Label lbl_PressureInput;
        private System.Windows.Forms.ListBox list_currentReadings;
        private System.Windows.Forms.ListBox list_Average;
        private System.Windows.Forms.ListBox list_Forecast;
        private System.Windows.Forms.Label lbl_Temp;
        private System.Windows.Forms.Label lbl_averageReadings;
        private System.Windows.Forms.Label lbl_Forecast;
    }
}

