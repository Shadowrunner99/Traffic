namespace Traffic
{
    partial class Cross
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
            this.red1 = new System.Windows.Forms.Timer(this.components);
            this.yellow1 = new System.Windows.Forms.Timer(this.components);
            this.green1 = new System.Windows.Forms.Timer(this.components);
            this.red2 = new System.Windows.Forms.Timer(this.components);
            this.yellow2 = new System.Windows.Forms.Timer(this.components);
            this.green2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.trafficLight1 = new Traffic.TrafficLight();
            this.trafficLight2 = new Traffic.TrafficLight();
            this.crossroads1 = new Traffic.Crossroads();
            ((System.ComponentModel.ISupportInitialize)(this.trafficLight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficLight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossroads1)).BeginInit();
            this.SuspendLayout();
            // 
            // red1
            // 
            this.red1.Interval = 3000;
            this.red1.Tick += new System.EventHandler(this.red1_Tick);
            // 
            // yellow1
            // 
            this.yellow1.Interval = 2000;
            this.yellow1.Tick += new System.EventHandler(this.yellow1_Tick);
            // 
            // green1
            // 
            this.green1.Interval = 5000;
            this.green1.Tick += new System.EventHandler(this.green1_Tick);
            // 
            // red2
            // 
            this.red2.Interval = 5000;
            this.red2.Tick += new System.EventHandler(this.red2_Tick);
            // 
            // yellow2
            // 
            this.yellow2.Interval = 1000;
            this.yellow2.Tick += new System.EventHandler(this.yellow2_Tick);
            // 
            // green2
            // 
            this.green2.Interval = 2000;
            this.green2.Tick += new System.EventHandler(this.green2_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "Auto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trafficLight1
            // 
            this.trafficLight1.ImageLocation = "D:\\c#\\green.png";
            this.trafficLight1.Location = new System.Drawing.Point(320, 171);
            this.trafficLight1.Name = "trafficLight1";
            this.trafficLight1.Size = new System.Drawing.Size(28, 70);
            this.trafficLight1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trafficLight1.TabIndex = 1;
            this.trafficLight1.TabStop = false;
            // 
            // trafficLight2
            // 
            this.trafficLight2.ImageLocation = "D:\\c#\\green.png";
            this.trafficLight2.Location = new System.Drawing.Point(200, 330);
            this.trafficLight2.Name = "trafficLight2";
            this.trafficLight2.Size = new System.Drawing.Size(28, 70);
            this.trafficLight2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trafficLight2.TabIndex = 2;
            this.trafficLight2.TabStop = false;
            // 
            // crossroads1
            // 
            this.crossroads1.BackColor = System.Drawing.Color.Transparent;
            this.crossroads1.ImageLocation = "D:\\c#\\cross.png";
            this.crossroads1.Location = new System.Drawing.Point(20, 30);
            this.crossroads1.Name = "crossroads1";
            this.crossroads1.Size = new System.Drawing.Size(500, 500);
            this.crossroads1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crossroads1.TabIndex = 0;
            this.crossroads1.TabStop = false;
            // 
            // Cross
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trafficLight1);
            this.Controls.Add(this.trafficLight2);
            this.Controls.Add(this.crossroads1);
            this.Name = "Cross";
            this.Text = "Cross";
            ((System.ComponentModel.ISupportInitialize)(this.trafficLight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficLight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossroads1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer red1;
        private Crossroads crossroads1;
        private TrafficLight trafficLight1;
        private TrafficLight trafficLight2;
        private System.Windows.Forms.Timer yellow1;
        private System.Windows.Forms.Timer green1;
        private System.Windows.Forms.Timer red2;
        private System.Windows.Forms.Timer yellow2;
        private System.Windows.Forms.Timer green2;
        private System.Windows.Forms.Button button1;
    }
}