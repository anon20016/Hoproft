namespace Hoprof_Karp
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
            this.data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.NumericUpDown();
            this.ls = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeColumns = false;
            this.data.AllowUserToResizeRows = false;
            this.data.BackgroundColor = System.Drawing.Color.Beige;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.ColumnHeadersVisible = false;
            this.data.Location = new System.Drawing.Point(12, 138);
            this.data.MultiSelect = false;
            this.data.Name = "data";
            this.data.RowHeadersVisible = false;
            this.data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.data.Size = new System.Drawing.Size(300, 300);
            this.data.StandardTab = true;
            this.data.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Алгоритм Хопкрофта — Карпа";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Матрица смежности";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Error
            // 
            this.Error.Location = new System.Drawing.Point(320, 339);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(470, 45);
            this.Error.TabIndex = 3;
            this.Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(320, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = "Максимальное паросочетание";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.answer.Location = new System.Drawing.Point(322, 138);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(468, 79);
            this.answer.TabIndex = 5;
            this.answer.Text = "0";
            this.answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(323, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(465, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // size
            // 
            this.size.BackColor = System.Drawing.Color.LightBlue;
            this.size.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size.Location = new System.Drawing.Point(248, 100);
            this.size.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.size.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(64, 30);
            this.size.TabIndex = 7;
            this.size.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ls
            // 
            this.ls.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ls.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ls.FormattingEnabled = true;
            this.ls.ItemHeight = 31;
            this.ls.Location = new System.Drawing.Point(335, 220);
            this.ls.Name = "ls";
            this.ls.Size = new System.Drawing.Size(453, 128);
            this.ls.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ls);
            this.Controls.Add(this.size);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown size;
        private System.Windows.Forms.ListBox ls;
    }
}

