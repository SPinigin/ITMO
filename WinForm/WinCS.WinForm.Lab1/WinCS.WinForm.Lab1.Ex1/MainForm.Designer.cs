namespace WinCS.WinForm.Lab1.Ex1
{
    partial class TreyResearch
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
            this.borderStyle = new System.Windows.Forms.Button();
            this.resize = new System.Windows.Forms.Button();
            this.opacity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // borderStyle
            // 
            this.borderStyle.Location = new System.Drawing.Point(57, 32);
            this.borderStyle.Name = "borderStyle";
            this.borderStyle.Size = new System.Drawing.Size(162, 51);
            this.borderStyle.TabIndex = 0;
            this.borderStyle.Text = "Border Style";
            this.borderStyle.UseVisualStyleBackColor = true;
            this.borderStyle.Click += new System.EventHandler(this.borderStyle_Click);
            // 
            // resize
            // 
            this.resize.Location = new System.Drawing.Point(322, 32);
            this.resize.Name = "resize";
            this.resize.Size = new System.Drawing.Size(162, 51);
            this.resize.TabIndex = 1;
            this.resize.Text = "Resize";
            this.resize.UseVisualStyleBackColor = true;
            this.resize.Click += new System.EventHandler(this.resize_Click);
            // 
            // opacity
            // 
            this.opacity.Location = new System.Drawing.Point(584, 32);
            this.opacity.Name = "opacit";
            this.opacity.Size = new System.Drawing.Size(162, 51);
            this.opacity.TabIndex = 2;
            this.opacity.Text = "Opacity";
            this.opacity.UseVisualStyleBackColor = true;
            this.opacity.Click += new System.EventHandler(this.opacit_Click);
            // 
            // TreyResearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.opacity);
            this.Controls.Add(this.resize);
            this.Controls.Add(this.borderStyle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "TreyResearch";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Trey Research";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button borderStyle;
        private System.Windows.Forms.Button resize;
        private System.Windows.Forms.Button opacity;
    }
}