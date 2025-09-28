namespace WindowsFormsApp1
{
    partial class Task44
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
            this.textX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.textB = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.textA = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textX
            // 
            this.textX.Location = new System.Drawing.Point(177, 28);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(100, 20);
            this.textX.TabIndex = 29;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(32, 9);
            this.labelX.Name = "labelX";
            this.labelX.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.labelX.Size = new System.Drawing.Size(108, 54);
            this.labelX.TabIndex = 28;
            this.labelX.Text = "Введите x:";
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(176, 137);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(100, 20);
            this.textB.TabIndex = 35;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(31, 117);
            this.labelB.Name = "labelB";
            this.labelB.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.labelB.Size = new System.Drawing.Size(109, 54);
            this.labelB.TabIndex = 34;
            this.labelB.Text = "Введите b:";
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(177, 83);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(100, 20);
            this.textA.TabIndex = 33;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(32, 63);
            this.labelA.Name = "labelA";
            this.labelA.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.labelA.Size = new System.Drawing.Size(108, 54);
            this.labelA.TabIndex = 32;
            this.labelA.Text = "Введите a:";
            // 
            // ResultBox
            // 
            this.ResultBox.AutoSize = true;
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultBox.Location = new System.Drawing.Point(32, 231);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(0, 24);
            this.ResultBox.TabIndex = 37;
            this.ResultBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 31);
            this.button1.TabIndex = 36;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Task44
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 306);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.textA);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textX);
            this.Controls.Add(this.labelX);
            this.Name = "Task44";
            this.Text = "Task44";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label ResultBox;
        private System.Windows.Forms.Button button1;
    }
}