namespace Задание_2_г
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
            this.Ishlabel = new System.Windows.Forms.Label();
            this.Ish = new System.Windows.Forms.TextBox();
            this.Nlabel = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.NumericUpDown();
            this.Search = new System.Windows.Forms.Button();
            this.Slov = new System.Windows.Forms.TextBox();
            this.Slovlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.N)).BeginInit();
            this.SuspendLayout();
            // 
            // Ishlabel
            // 
            this.Ishlabel.AutoSize = true;
            this.Ishlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ishlabel.Location = new System.Drawing.Point(12, 18);
            this.Ishlabel.Name = "Ishlabel";
            this.Ishlabel.Size = new System.Drawing.Size(203, 28);
            this.Ishlabel.TabIndex = 0;
            this.Ishlabel.Text = "Исходная строка";
            // 
            // Ish
            // 
            this.Ish.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ish.Location = new System.Drawing.Point(236, 15);
            this.Ish.Name = "Ish";
            this.Ish.Size = new System.Drawing.Size(552, 36);
            this.Ish.TabIndex = 1;
            // 
            // Nlabel
            // 
            this.Nlabel.AutoSize = true;
            this.Nlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nlabel.Location = new System.Drawing.Point(16, 63);
            this.Nlabel.Name = "Nlabel";
            this.Nlabel.Size = new System.Drawing.Size(202, 28);
            this.Nlabel.TabIndex = 2;
            this.Nlabel.Text = "Количество букв";
            // 
            // N
            // 
            this.N.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.N.Location = new System.Drawing.Point(236, 61);
            this.N.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(120, 36);
            this.N.TabIndex = 3;
            this.N.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(304, 103);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(159, 48);
            this.Search.TabIndex = 5;
            this.Search.Text = "Узнать";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Slov
            // 
            this.Slov.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Slov.Location = new System.Drawing.Point(17, 185);
            this.Slov.Name = "Slov";
            this.Slov.ReadOnly = true;
            this.Slov.Size = new System.Drawing.Size(771, 36);
            this.Slov.TabIndex = 6;
            // 
            // Slovlabel
            // 
            this.Slovlabel.AutoSize = true;
            this.Slovlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Slovlabel.Location = new System.Drawing.Point(176, 154);
            this.Slovlabel.Name = "Slovlabel";
            this.Slovlabel.Size = new System.Drawing.Size(448, 28);
            this.Slovlabel.TabIndex = 4;
            this.Slovlabel.Text = "Слова, меньше введённого количества";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 230);
            this.Controls.Add(this.Slov);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Slovlabel);
            this.Controls.Add(this.N);
            this.Controls.Add(this.Nlabel);
            this.Controls.Add(this.Ish);
            this.Controls.Add(this.Ishlabel);
            this.Name = "Form1";
            this.Text = "Задание 2";
            ((System.ComponentModel.ISupportInitialize)(this.N)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ishlabel;
        private System.Windows.Forms.TextBox Ish;
        private System.Windows.Forms.Label Nlabel;
        private System.Windows.Forms.NumericUpDown N;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox Slov;
        private System.Windows.Forms.Label Slovlabel;
    }
}

