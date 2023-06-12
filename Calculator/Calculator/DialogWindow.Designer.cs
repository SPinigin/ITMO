namespace Calculator
{
    partial class DialogWindow
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
            this.labelOpisanie = new System.Windows.Forms.Label();
            this.labelKoeffA = new System.Windows.Forms.Label();
            this.labelKoeffB = new System.Windows.Forms.Label();
            this.labelKoeffC = new System.Windows.Forms.Label();
            this.textBoxKoeffA = new System.Windows.Forms.TextBox();
            this.textBoxKoeffB = new System.Windows.Forms.TextBox();
            this.textBoxKoeffC = new System.Windows.Forms.TextBox();
            this.butСalculate = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOpisanie
            // 
            this.labelOpisanie.AutoSize = true;
            this.labelOpisanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpisanie.Location = new System.Drawing.Point(14, 17);
            this.labelOpisanie.Name = "labelOpisanie";
            this.labelOpisanie.Size = new System.Drawing.Size(259, 16);
            this.labelOpisanie.TabIndex = 0;
            this.labelOpisanie.Text = "Квадратное уравнение a*x² + b*x + c = 0";
            // 
            // labelKoeffA
            // 
            this.labelKoeffA.AutoSize = true;
            this.labelKoeffA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKoeffA.Location = new System.Drawing.Point(20, 53);
            this.labelKoeffA.Name = "labelKoeffA";
            this.labelKoeffA.Size = new System.Drawing.Size(121, 16);
            this.labelKoeffA.TabIndex = 1;
            this.labelKoeffA.Text = "Коэффициент a =";
            // 
            // labelKoeffB
            // 
            this.labelKoeffB.AutoSize = true;
            this.labelKoeffB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKoeffB.Location = new System.Drawing.Point(20, 83);
            this.labelKoeffB.Name = "labelKoeffB";
            this.labelKoeffB.Size = new System.Drawing.Size(121, 16);
            this.labelKoeffB.TabIndex = 2;
            this.labelKoeffB.Text = "Коэффициент b =";
            // 
            // labelKoeffC
            // 
            this.labelKoeffC.AutoSize = true;
            this.labelKoeffC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKoeffC.Location = new System.Drawing.Point(20, 115);
            this.labelKoeffC.Name = "labelKoeffC";
            this.labelKoeffC.Size = new System.Drawing.Size(120, 16);
            this.labelKoeffC.TabIndex = 3;
            this.labelKoeffC.Text = "Коэффициент c =";
            // 
            // textBoxKoeffA
            // 
            this.textBoxKoeffA.Location = new System.Drawing.Point(146, 49);
            this.textBoxKoeffA.Name = "textBoxKoeffA";
            this.textBoxKoeffA.Size = new System.Drawing.Size(53, 20);
            this.textBoxKoeffA.TabIndex = 4;
            this.textBoxKoeffA.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxKoeffA_Validating);
            // 
            // textBoxKoeffB
            // 
            this.textBoxKoeffB.Location = new System.Drawing.Point(146, 79);
            this.textBoxKoeffB.Name = "textBoxKoeffB";
            this.textBoxKoeffB.Size = new System.Drawing.Size(53, 20);
            this.textBoxKoeffB.TabIndex = 5;
            this.textBoxKoeffB.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxKoeffB_Validating);
            // 
            // textBoxKoeffC
            // 
            this.textBoxKoeffC.Location = new System.Drawing.Point(146, 111);
            this.textBoxKoeffC.Name = "textBoxKoeffC";
            this.textBoxKoeffC.Size = new System.Drawing.Size(53, 20);
            this.textBoxKoeffC.TabIndex = 6;
            this.textBoxKoeffC.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxKoeffC_Validating);
            // 
            // butСalculate
            // 
            this.butСalculate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butСalculate.Location = new System.Drawing.Point(20, 166);
            this.butСalculate.Name = "butСalculate";
            this.butСalculate.Size = new System.Drawing.Size(118, 30);
            this.butСalculate.TabIndex = 7;
            this.butСalculate.Text = "Рассчитать";
            this.butСalculate.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(146, 166);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(118, 30);
            this.butCancel.TabIndex = 8;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // DialogWindow
            // 
            this.AcceptButton = this.butСalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butСalculate);
            this.Controls.Add(this.textBoxKoeffC);
            this.Controls.Add(this.textBoxKoeffB);
            this.Controls.Add(this.textBoxKoeffA);
            this.Controls.Add(this.labelKoeffC);
            this.Controls.Add(this.labelKoeffB);
            this.Controls.Add(this.labelKoeffA);
            this.Controls.Add(this.labelOpisanie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DialogWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Квадратное уравнение";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOpisanie;
        private System.Windows.Forms.Label labelKoeffA;
        private System.Windows.Forms.Label labelKoeffB;
        private System.Windows.Forms.Label labelKoeffC;
        private System.Windows.Forms.TextBox textBoxKoeffA;
        private System.Windows.Forms.TextBox textBoxKoeffB;
        private System.Windows.Forms.TextBox textBoxKoeffC;
        private System.Windows.Forms.Button butСalculate;
        private System.Windows.Forms.Button butCancel;
    }
}
