namespace Triangle
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SideA = new System.Windows.Forms.MaskedTextBox();
            this.SideB = new System.Windows.Forms.MaskedTextBox();
            this.SideC = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PLabel = new System.Windows.Forms.Label();
            this.SLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SideA
            // 
            this.SideA.Location = new System.Drawing.Point(75, 122);
            this.SideA.Mask = "00000";
            this.SideA.Name = "SideA";
            this.SideA.Size = new System.Drawing.Size(36, 20);
            this.SideA.TabIndex = 1;
            // 
            // SideB
            // 
            this.SideB.Location = new System.Drawing.Point(271, 122);
            this.SideB.Mask = "00000";
            this.SideB.Name = "SideB";
            this.SideB.Size = new System.Drawing.Size(36, 20);
            this.SideB.TabIndex = 2;
            // 
            // SideC
            // 
            this.SideC.Location = new System.Drawing.Point(173, 264);
            this.SideC.Mask = "00000";
            this.SideC.Name = "SideC";
            this.SideC.Size = new System.Drawing.Size(36, 20);
            this.SideC.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Расчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PLabel.Location = new System.Drawing.Point(173, 287);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(0, 20);
            this.PLabel.TabIndex = 5;
            // 
            // SLabel
            // 
            this.SLabel.AutoSize = true;
            this.SLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SLabel.Location = new System.Drawing.Point(173, 317);
            this.SLabel.Name = "SLabel";
            this.SLabel.Size = new System.Drawing.Size(0, 20);
            this.SLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 346);
            this.Controls.Add(this.SLabel);
            this.Controls.Add(this.PLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SideC);
            this.Controls.Add(this.SideB);
            this.Controls.Add(this.SideA);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Triangle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox SideA;
        private System.Windows.Forms.MaskedTextBox SideB;
        private System.Windows.Forms.MaskedTextBox SideC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PLabel;
        private System.Windows.Forms.Label SLabel;
    }
}

