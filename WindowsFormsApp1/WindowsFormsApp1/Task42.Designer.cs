namespace WindowsFormsApp1
{
    partial class Task42
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
            this.textR = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textR
            // 
            this.textR.Location = new System.Drawing.Point(169, 37);
            this.textR.Name = "textR";
            this.textR.Size = new System.Drawing.Size(100, 20);
            this.textR.TabIndex = 30;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR.Location = new System.Drawing.Point(24, 16);
            this.labelR.Margin = new System.Windows.Forms.Padding(15, 150, 3, 0);
            this.labelR.Name = "labelR";
            this.labelR.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.labelR.Size = new System.Drawing.Size(111, 54);
            this.labelR.TabIndex = 29;
            this.labelR.Text = "Введите R:";
            // 
            // ResultBox
            // 
            this.ResultBox.AutoSize = true;
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultBox.Location = new System.Drawing.Point(33, 131);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(0, 24);
            this.ResultBox.TabIndex = 32;
            this.ResultBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 31);
            this.button1.TabIndex = 31;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Task42
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 233);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textR);
            this.Controls.Add(this.labelR);
            this.Name = "Task42";
            this.Text = "Task42";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textR;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label ResultBox;
        private System.Windows.Forms.Button button1;
    }
}