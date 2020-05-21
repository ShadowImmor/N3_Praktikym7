namespace Задание_1_г
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
            this.Isnlabel = new System.Windows.Forms.Label();
            this.Isn = new System.Windows.Forms.TextBox();
            this.Change = new System.Windows.Forms.Button();
            this.Ismlabel = new System.Windows.Forms.Label();
            this.Ism = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Isnlabel
            // 
            this.Isnlabel.AutoSize = true;
            this.Isnlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Isnlabel.Location = new System.Drawing.Point(12, 20);
            this.Isnlabel.Name = "Isnlabel";
            this.Isnlabel.Size = new System.Drawing.Size(203, 28);
            this.Isnlabel.TabIndex = 0;
            this.Isnlabel.Text = "Исходная строка";
            // 
            // Isn
            // 
            this.Isn.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Isn.Location = new System.Drawing.Point(252, 17);
            this.Isn.Name = "Isn";
            this.Isn.Size = new System.Drawing.Size(536, 36);
            this.Isn.TabIndex = 1;
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change.Location = new System.Drawing.Point(252, 70);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(283, 53);
            this.Change.TabIndex = 2;
            this.Change.Text = "Поменять местами";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Ismlabel
            // 
            this.Ismlabel.AutoSize = true;
            this.Ismlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ismlabel.Location = new System.Drawing.Point(12, 141);
            this.Ismlabel.Name = "Ismlabel";
            this.Ismlabel.Size = new System.Drawing.Size(234, 28);
            this.Ismlabel.TabIndex = 3;
            this.Ismlabel.Text = "Измененная строка";
            // 
            // Ism
            // 
            this.Ism.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ism.Location = new System.Drawing.Point(252, 138);
            this.Ism.Name = "Ism";
            this.Ism.ReadOnly = true;
            this.Ism.Size = new System.Drawing.Size(536, 36);
            this.Ism.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 193);
            this.Controls.Add(this.Ism);
            this.Controls.Add(this.Ismlabel);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Isn);
            this.Controls.Add(this.Isnlabel);
            this.Name = "Form1";
            this.Text = "Задание 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Isnlabel;
        private System.Windows.Forms.TextBox Isn;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Label Ismlabel;
        private System.Windows.Forms.TextBox Ism;
    }
}

