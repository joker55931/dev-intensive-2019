
namespace lab6._1
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
            this.Color_Change = new System.Windows.Forms.Button();
            this.Color_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Color_Change
            // 
            this.Color_Change.Location = new System.Drawing.Point(13, 13);
            this.Color_Change.Name = "Color_Change";
            this.Color_Change.Size = new System.Drawing.Size(169, 29);
            this.Color_Change.TabIndex = 0;
            this.Color_Change.Text = "Цвет вне области";
            this.Color_Change.UseVisualStyleBackColor = true;
            this.Color_Change.Click += new System.EventHandler(this.Color_Change_Click);
            // 
            // Color_in
            // 
            this.Color_in.Location = new System.Drawing.Point(13, 58);
            this.Color_in.Name = "Color_in";
            this.Color_in.Size = new System.Drawing.Size(169, 32);
            this.Color_in.TabIndex = 1;
            this.Color_in.Text = "Цвет в области";
            this.Color_in.UseVisualStyleBackColor = true;
            this.Color_in.Click += new System.EventHandler(this.Color_in_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 587);
            this.Controls.Add(this.Color_in);
            this.Controls.Add(this.Color_Change);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Color_Change;
        private System.Windows.Forms.Button Color_in;
    }
}

