
namespace OpenWeather
{
    partial class Weather
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
            this.GetWeather = new System.Windows.Forms.Button();
            this.citylabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.Temperature = new System.Windows.Forms.Label();
            this.WindSpeed = new System.Windows.Forms.Label();
            this.Details = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetWeather
            // 
            this.GetWeather.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetWeather.Location = new System.Drawing.Point(428, 45);
            this.GetWeather.Name = "GetWeather";
            this.GetWeather.Size = new System.Drawing.Size(96, 31);
            this.GetWeather.TabIndex = 0;
            this.GetWeather.Text = "Найти";
            this.GetWeather.UseVisualStyleBackColor = true;
            this.GetWeather.Click += new System.EventHandler(this.GetWeather_Click);
            // 
            // citylabel
            // 
            this.citylabel.BackColor = System.Drawing.Color.Transparent;
            this.citylabel.Font = new System.Drawing.Font("Century", 14F);
            this.citylabel.Location = new System.Drawing.Point(45, 45);
            this.citylabel.Name = "citylabel";
            this.citylabel.Size = new System.Drawing.Size(100, 23);
            this.citylabel.TabIndex = 1;
            this.citylabel.Text = "Город";
            this.citylabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.citylabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 14F);
            this.label2.Location = new System.Drawing.Point(45, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Температура";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 14F);
            this.label3.Location = new System.Drawing.Point(45, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Скорость ветра";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 14F);
            this.label4.Location = new System.Drawing.Point(45, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Описание";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // City
            // 
            this.City.Font = new System.Drawing.Font("Century", 14.25F);
            this.City.Location = new System.Drawing.Point(183, 42);
            this.City.Multiline = true;
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(200, 32);
            this.City.TabIndex = 5;
            // 
            // Temperature
            // 
            this.Temperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Temperature.Font = new System.Drawing.Font("Century", 14F);
            this.Temperature.Location = new System.Drawing.Point(189, 182);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(237, 38);
            this.Temperature.TabIndex = 6;
            this.Temperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WindSpeed
            // 
            this.WindSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WindSpeed.Font = new System.Drawing.Font("Century", 14F);
            this.WindSpeed.Location = new System.Drawing.Point(189, 231);
            this.WindSpeed.Name = "WindSpeed";
            this.WindSpeed.Size = new System.Drawing.Size(237, 34);
            this.WindSpeed.TabIndex = 7;
            this.WindSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Details
            // 
            this.Details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Details.Font = new System.Drawing.Font("Century", 14F);
            this.Details.Location = new System.Drawing.Point(189, 279);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(237, 34);
            this.Details.TabIndex = 8;
            this.Details.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OpenWeather.Properties.Resources.sky;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(685, 423);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.WindSpeed);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.citylabel);
            this.Controls.Add(this.GetWeather);
            this.Name = "Weather";
            this.Text = "Погода";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetWeather;
        private System.Windows.Forms.Label citylabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.Label WindSpeed;
        private System.Windows.Forms.Label Details;
    }
}

