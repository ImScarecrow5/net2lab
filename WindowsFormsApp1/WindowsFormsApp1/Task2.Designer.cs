namespace WindowsFormsApp1
{
    partial class Task2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textX3 = new System.Windows.Forms.TextBox();
            this.textX2 = new System.Windows.Forms.TextBox();
            this.textX1 = new System.Windows.Forms.TextBox();
            this.labelX3 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.textY3 = new System.Windows.Forms.TextBox();
            this.textY2 = new System.Windows.Forms.TextBox();
            this.textY1 = new System.Windows.Forms.TextBox();
            this.labelY3 = new System.Windows.Forms.Label();
            this.labelY2 = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(125, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Известно, что точки с координатами (x1, y1), (x2, y2), (x3, y3) \r\nявляются тремя " +
    "вершинами некоторого параллелограмма.\r\nНайти координаты четвертой вершины.";
            // 
            // textX3
            // 
            this.textX3.Location = new System.Drawing.Point(243, 225);
            this.textX3.Name = "textX3";
            this.textX3.Size = new System.Drawing.Size(100, 20);
            this.textX3.TabIndex = 13;
            // 
            // textX2
            // 
            this.textX2.Location = new System.Drawing.Point(243, 172);
            this.textX2.Name = "textX2";
            this.textX2.Size = new System.Drawing.Size(100, 20);
            this.textX2.TabIndex = 12;
            // 
            // textX1
            // 
            this.textX1.Location = new System.Drawing.Point(243, 118);
            this.textX1.Name = "textX1";
            this.textX1.Size = new System.Drawing.Size(100, 20);
            this.textX1.TabIndex = 11;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX3.Location = new System.Drawing.Point(98, 205);
            this.labelX3.Name = "labelX3";
            this.labelX3.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.labelX3.Size = new System.Drawing.Size(118, 54);
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "Введите x3:";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX2.Location = new System.Drawing.Point(98, 151);
            this.labelX2.Margin = new System.Windows.Forms.Padding(15, 150, 3, 0);
            this.labelX2.Name = "labelX2";
            this.labelX2.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.labelX2.Size = new System.Drawing.Size(118, 54);
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "Введите x2:";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX1.Location = new System.Drawing.Point(98, 99);
            this.labelX1.Name = "labelX1";
            this.labelX1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.labelX1.Size = new System.Drawing.Size(118, 54);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "Введите x1:";
            // 
            // textY3
            // 
            this.textY3.Location = new System.Drawing.Point(523, 225);
            this.textY3.Name = "textY3";
            this.textY3.Size = new System.Drawing.Size(100, 20);
            this.textY3.TabIndex = 19;
            // 
            // textY2
            // 
            this.textY2.Location = new System.Drawing.Point(523, 172);
            this.textY2.Name = "textY2";
            this.textY2.Size = new System.Drawing.Size(100, 20);
            this.textY2.TabIndex = 18;
            // 
            // textY1
            // 
            this.textY1.Location = new System.Drawing.Point(523, 118);
            this.textY1.Name = "textY1";
            this.textY1.Size = new System.Drawing.Size(100, 20);
            this.textY1.TabIndex = 17;
            // 
            // labelY3
            // 
            this.labelY3.AutoSize = true;
            this.labelY3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY3.Location = new System.Drawing.Point(378, 205);
            this.labelY3.Name = "labelY3";
            this.labelY3.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.labelY3.Size = new System.Drawing.Size(117, 54);
            this.labelY3.TabIndex = 16;
            this.labelY3.Text = "Введите y3:";
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY2.Location = new System.Drawing.Point(378, 151);
            this.labelY2.Margin = new System.Windows.Forms.Padding(15, 150, 3, 0);
            this.labelY2.Name = "labelY2";
            this.labelY2.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.labelY2.Size = new System.Drawing.Size(117, 54);
            this.labelY2.TabIndex = 15;
            this.labelY2.Text = "Введите y2:";
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY1.Location = new System.Drawing.Point(378, 99);
            this.labelY1.Name = "labelY1";
            this.labelY1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.labelY1.Size = new System.Drawing.Size(117, 54);
            this.labelY1.TabIndex = 14;
            this.labelY1.Text = "Введите y1:";
            // 
            // ResultBox
            // 
            this.ResultBox.AutoSize = true;
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultBox.Location = new System.Drawing.Point(306, 365);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(0, 24);
            this.ResultBox.TabIndex = 21;
            this.ResultBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 422);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textY3);
            this.Controls.Add(this.textY2);
            this.Controls.Add(this.textY1);
            this.Controls.Add(this.labelY3);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.textX3);
            this.Controls.Add(this.textX2);
            this.Controls.Add(this.textX1);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.label1);
            this.Name = "Task2";
            this.Text = "Task2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textX3;
        private System.Windows.Forms.TextBox textX2;
        private System.Windows.Forms.TextBox textX1;
        private System.Windows.Forms.Label labelX3;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.TextBox textY3;
        private System.Windows.Forms.TextBox textY2;
        private System.Windows.Forms.TextBox textY1;
        private System.Windows.Forms.Label labelY3;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.Label ResultBox;
        private System.Windows.Forms.Button button1;
    }
}