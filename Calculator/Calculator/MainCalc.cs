using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Calculator
{
    public class Calc : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btn_sbros;
        private System.Windows.Forms.Button btnChangesign;
        private System.Windows.Forms.Button btnpoint;
        private System.Windows.Forms.Button btn_ravno;
        private System.Windows.Forms.Button btn_delenie;
        private System.Windows.Forms.Button btn_umnojenie;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private IContainer components;

        /// <summary>
        /// Объявляем и инициализируем переменные, которые будут
        ///  возникать на экране при нажатии соответствующих кнопок.
        /// </summary>
        private const string odin = "1";
        private const string dva = "2";
        private const string tri = "3";
        private const string chetire = "4";
        private const string pyat = "5";
        private const string shest = "6";
        private const string sem = "7";
        private const string vosem = "8";
        private const string devyat = "9";
        private ToolTip toolTipDel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem view;
        private ToolStripMenuItem ordinary;
        private ToolStripMenuItem engineering;
        private ToolStripMenuItem about;
        private Button squareNum;
        private Button squareRoot;
        private Button obrNumber;
        private Panel panelDopOne;
        private Button chislovStepen;
        private Panel panelOsnov;
        private Panel panelDopTwo;
        private const string nul = "0";

        public Calc()
        {
            InitializeComponent();
            // При запуске приложения на экране будет нуль
            txtOutput.Text = "0";
            // Стартовая форма
            this.Size = new Size(260, 310);
            txtOutput.Size = new Size(228, 26);
            panelOsnov.Location = new Point(13, 94);

        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btn_sbros = new System.Windows.Forms.Button();
            this.btnChangesign = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btn_ravno = new System.Windows.Forms.Button();
            this.btn_delenie = new System.Windows.Forms.Button();
            this.btn_umnojenie = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.toolTipDel = new System.Windows.Forms.ToolTip(this.components);
            this.squareNum = new System.Windows.Forms.Button();
            this.squareRoot = new System.Windows.Forms.Button();
            this.obrNumber = new System.Windows.Forms.Button();
            this.chislovStepen = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.view = new System.Windows.Forms.ToolStripMenuItem();
            this.ordinary = new System.Windows.Forms.ToolStripMenuItem();
            this.engineering = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDopOne = new System.Windows.Forms.Panel();
            this.panelOsnov = new System.Windows.Forms.Panel();
            this.panelDopTwo = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.panelDopOne.SuspendLayout();
            this.panelOsnov.SuspendLayout();
            this.panelDopTwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.AccessibleName = "Display";
            this.txtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtOutput.Cursor = System.Windows.Forms.Cursors.No;
            this.txtOutput.Enabled = false;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOutput.Location = new System.Drawing.Point(8, 40);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOutput.Size = new System.Drawing.Size(268, 26);
            this.txtOutput.TabIndex = 60;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_sbros
            // 
            this.btn_sbros.AccessibleName = "reset";
            this.btn_sbros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sbros.Location = new System.Drawing.Point(176, 0);
            this.btn_sbros.Name = "btn_sbros";
            this.btn_sbros.Size = new System.Drawing.Size(40, 80);
            this.btn_sbros.TabIndex = 0;
            this.btn_sbros.Text = "C";
            this.toolTipDel.SetToolTip(this.btn_sbros, "Клавиша \"Сброс\"");
            this.btn_sbros.Click += new System.EventHandler(this.btn_sbros_Click);
            // 
            // btnChangesign
            // 
            this.btnChangesign.AccessibleName = "change sign";
            this.btnChangesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangesign.Location = new System.Drawing.Point(40, 120);
            this.btnChangesign.Name = "btnChangesign";
            this.btnChangesign.Size = new System.Drawing.Size(40, 40);
            this.btnChangesign.TabIndex = 58;
            this.btnChangesign.Text = "+/-";
            this.btnChangesign.Click += new System.EventHandler(this.btnChangesign_Click);
            // 
            // btnpoint
            // 
            this.btnpoint.AccessibleName = "point ";
            this.btnpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnpoint.Location = new System.Drawing.Point(80, 120);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(40, 40);
            this.btnpoint.TabIndex = 57;
            this.btnpoint.Text = ",";
            this.btnpoint.Click += new System.EventHandler(this.btnpoint_Click);
            // 
            // btn_ravno
            // 
            this.btn_ravno.AccessibleDescription = "ravno";
            this.btn_ravno.AccessibleName = "equal";
            this.btn_ravno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ravno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ravno.Location = new System.Drawing.Point(176, 80);
            this.btn_ravno.Name = "btn_ravno";
            this.btn_ravno.Size = new System.Drawing.Size(40, 80);
            this.btn_ravno.TabIndex = 56;
            this.btn_ravno.Text = "=";
            this.toolTipDel.SetToolTip(this.btn_ravno, "Клавиша \"Равно\"");
            this.btn_ravno.UseVisualStyleBackColor = false;
            this.btn_ravno.Click += new System.EventHandler(this.btn_ravno_Click);
            // 
            // btn_delenie
            // 
            this.btn_delenie.AccessibleName = "divide ";
            this.btn_delenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_delenie.ForeColor = System.Drawing.Color.Green;
            this.btn_delenie.Location = new System.Drawing.Point(136, 0);
            this.btn_delenie.Name = "btn_delenie";
            this.btn_delenie.Size = new System.Drawing.Size(40, 40);
            this.btn_delenie.TabIndex = 55;
            this.btn_delenie.Text = "/";
            this.toolTipDel.SetToolTip(this.btn_delenie, "Клавиша \"Деление\"");
            this.btn_delenie.Click += new System.EventHandler(this.btn_delenie_Click);
            // 
            // btn_umnojenie
            // 
            this.btn_umnojenie.AccessibleName = "multiply ";
            this.btn_umnojenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_umnojenie.ForeColor = System.Drawing.Color.Green;
            this.btn_umnojenie.Location = new System.Drawing.Point(136, 40);
            this.btn_umnojenie.Name = "btn_umnojenie";
            this.btn_umnojenie.Size = new System.Drawing.Size(40, 40);
            this.btn_umnojenie.TabIndex = 54;
            this.btn_umnojenie.Text = "*";
            this.toolTipDel.SetToolTip(this.btn_umnojenie, "Клавиша \"Умножение\"");
            this.btn_umnojenie.Click += new System.EventHandler(this.btn_umnojenie_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.AccessibleName = "plus ";
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_plus.ForeColor = System.Drawing.Color.Green;
            this.btn_plus.Location = new System.Drawing.Point(136, 120);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(40, 40);
            this.btn_plus.TabIndex = 53;
            this.btn_plus.Text = "+";
            this.toolTipDel.SetToolTip(this.btn_plus, "Клавиша \"Сложение\"");
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.AccessibleName = "minus ";
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_minus.ForeColor = System.Drawing.Color.Green;
            this.btn_minus.Location = new System.Drawing.Point(136, 80);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(40, 40);
            this.btn_minus.TabIndex = 52;
            this.btn_minus.Text = "-";
            this.toolTipDel.SetToolTip(this.btn_minus, "Клавиша \"Вычитание\"");
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn0
            // 
            this.btn0.AccessibleName = "zero";
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn0.Location = new System.Drawing.Point(0, 120);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(40, 40);
            this.btn0.TabIndex = 51;
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.AccessibleName = "nine ";
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn9.Location = new System.Drawing.Point(80, 0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 40);
            this.btn9.TabIndex = 50;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.AccessibleName = "eight ";
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn8.Location = new System.Drawing.Point(40, 0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 40);
            this.btn8.TabIndex = 49;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.AccessibleName = "seven ";
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn7.Location = new System.Drawing.Point(0, 0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 40);
            this.btn7.TabIndex = 48;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.AccessibleName = "six ";
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn6.Location = new System.Drawing.Point(80, 40);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 40);
            this.btn6.TabIndex = 47;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.AccessibleName = "five ";
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn5.Location = new System.Drawing.Point(40, 40);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 40);
            this.btn5.TabIndex = 46;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.AccessibleName = "four ";
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn4.Location = new System.Drawing.Point(0, 40);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 40);
            this.btn4.TabIndex = 45;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.AccessibleName = "three ";
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.Location = new System.Drawing.Point(80, 80);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 40);
            this.btn3.TabIndex = 44;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.AccessibleName = "two ";
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Location = new System.Drawing.Point(40, 80);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 40);
            this.btn2.TabIndex = 43;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.AccessibleName = "one ";
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(0, 80);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 40);
            this.btn1.TabIndex = 42;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // squareNum
            // 
            this.squareNum.AccessibleName = "zero";
            this.squareNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareNum.ForeColor = System.Drawing.Color.Blue;
            this.squareNum.Location = new System.Drawing.Point(0, 118);
            this.squareNum.Name = "squareNum";
            this.squareNum.Size = new System.Drawing.Size(40, 40);
            this.squareNum.TabIndex = 65;
            this.squareNum.Text = "x^2";
            this.toolTipDel.SetToolTip(this.squareNum, "Клавиша \"Возведение в квадрат\"");
            this.squareNum.Click += new System.EventHandler(this.squareNum_Click);
            // 
            // squareRoot
            // 
            this.squareRoot.AccessibleName = "four ";
            this.squareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareRoot.ForeColor = System.Drawing.Color.Blue;
            this.squareRoot.Location = new System.Drawing.Point(0, 39);
            this.squareRoot.Name = "squareRoot";
            this.squareRoot.Size = new System.Drawing.Size(40, 40);
            this.squareRoot.TabIndex = 63;
            this.squareRoot.Text = "√";
            this.toolTipDel.SetToolTip(this.squareRoot, "Клавиша \"Квадратный корень\"");
            this.squareRoot.Click += new System.EventHandler(this.squareRoot_Click);
            // 
            // obrNumber
            // 
            this.obrNumber.AccessibleName = "one ";
            this.obrNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.obrNumber.ForeColor = System.Drawing.Color.Blue;
            this.obrNumber.Location = new System.Drawing.Point(0, 79);
            this.obrNumber.Name = "obrNumber";
            this.obrNumber.Size = new System.Drawing.Size(40, 40);
            this.obrNumber.TabIndex = 62;
            this.obrNumber.Text = "1/x";
            this.toolTipDel.SetToolTip(this.obrNumber, "Клавиша \"Обратное значение\"");
            this.obrNumber.Click += new System.EventHandler(this.obrNumber_Click);
            // 
            // chislovStepen
            // 
            this.chislovStepen.AccessibleName = "seven ";
            this.chislovStepen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chislovStepen.ForeColor = System.Drawing.Color.Blue;
            this.chislovStepen.Location = new System.Drawing.Point(0, -1);
            this.chislovStepen.Name = "chislovStepen";
            this.chislovStepen.Size = new System.Drawing.Size(40, 40);
            this.chislovStepen.TabIndex = 64;
            this.chislovStepen.Text = "x^y";
            this.toolTipDel.SetToolTip(this.chislovStepen, "Клавиша \"Возведение в степень\"");
            this.chislovStepen.Click += new System.EventHandler(this.chislovStepen_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.view,
            this.about});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(280, 24);
            this.menuStrip.TabIndex = 61;
            // 
            // view
            // 
            this.view.Checked = true;
            this.view.CheckState = System.Windows.Forms.CheckState.Checked;
            this.view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordinary,
            this.engineering});
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(39, 20);
            this.view.Text = "&Вид";
            // 
            // ordinary
            // 
            this.ordinary.Checked = true;
            this.ordinary.CheckOnClick = true;
            this.ordinary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ordinary.Name = "ordinary";
            this.ordinary.Size = new System.Drawing.Size(148, 22);
            this.ordinary.Text = "&Обычный";
            this.ordinary.Click += new System.EventHandler(this.ordinary_Click);
            // 
            // engineering
            // 
            this.engineering.CheckOnClick = true;
            this.engineering.Name = "engineering";
            this.engineering.Size = new System.Drawing.Size(148, 22);
            this.engineering.Text = "&Инженерный";
            this.engineering.Click += new System.EventHandler(this.engineering_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(94, 20);
            this.about.Text = "&О программе";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // panelDopOne
            // 
            this.panelDopOne.Controls.Add(this.chislovStepen);
            this.panelDopOne.Controls.Add(this.squareNum);
            this.panelDopOne.Controls.Add(this.squareRoot);
            this.panelDopOne.Controls.Add(this.obrNumber);
            this.panelDopOne.Location = new System.Drawing.Point(12, 135);
            this.panelDopOne.Name = "panelDopOne";
            this.panelDopOne.Size = new System.Drawing.Size(40, 159);
            this.panelDopOne.TabIndex = 66;
            this.panelDopOne.Visible = false;
            // 
            // panelOsnov
            // 
            this.panelOsnov.Controls.Add(this.btn7);
            this.panelOsnov.Controls.Add(this.btn1);
            this.panelOsnov.Controls.Add(this.btn2);
            this.panelOsnov.Controls.Add(this.btn_sbros);
            this.panelOsnov.Controls.Add(this.btn3);
            this.panelOsnov.Controls.Add(this.btnChangesign);
            this.panelOsnov.Controls.Add(this.btn4);
            this.panelOsnov.Controls.Add(this.btnpoint);
            this.panelOsnov.Controls.Add(this.btn5);
            this.panelOsnov.Controls.Add(this.btn_ravno);
            this.panelOsnov.Controls.Add(this.btn6);
            this.panelOsnov.Controls.Add(this.btn_delenie);
            this.panelOsnov.Controls.Add(this.btn8);
            this.panelOsnov.Controls.Add(this.btn_umnojenie);
            this.panelOsnov.Controls.Add(this.btn9);
            this.panelOsnov.Controls.Add(this.btn_plus);
            this.panelOsnov.Controls.Add(this.btn0);
            this.panelOsnov.Controls.Add(this.btn_minus);
            this.panelOsnov.Location = new System.Drawing.Point(53, 134);
            this.panelOsnov.Name = "panelOsnov";
            this.panelOsnov.Size = new System.Drawing.Size(215, 160);
            this.panelOsnov.TabIndex = 67;
            // 
            // panelDopTwo
            // 
            this.panelDopTwo.Location = new System.Drawing.Point(11, 93);
            this.panelDopTwo.Name = "panelDopTwo";
            this.panelDopTwo.Size = new System.Drawing.Size(257, 42);
            this.panelDopTwo.TabIndex = 70;
            this.panelDopTwo.Visible = false;
            // 
            // Calc
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(280, 307);
            this.Controls.Add(this.panelDopTwo);
            this.Controls.Add(this.panelOsnov);
            this.Controls.Add(this.panelDopOne);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(140, 0);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор v1.01";
            this.TopMost = true;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelDopOne.ResumeLayout(false);
            this.panelOsnov.ResumeLayout(false);
            this.panelDopTwo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Calc());
        }
        /// <summary>
        /// Обработчики для кнопок  обращаются к методу chislonaEkrane класса mehanizmcalkulyatora
        /// и передают ему одну из постоянных (odin, dva, tri  и т.д.). Результат, возвращаемый методом,
        /// присваивается  свойству Text текстового поля txtOutput.
        /// </summary>

        private void btn1_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(odin);
        }

        private void btn2_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(dva);
        }

        private void btn3_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(tri);
        }

        private void btn4_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(chetire);
        }

        private void btn5_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(pyat);
        }

        private void btn6_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(shest);
        }

        private void btn7_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(sem);
        }

        private void btn8_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(vosem);
        }

        private void btn9_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(devyat);
        }

        private void btn0_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane(nul);
        }

        private void btnChangesign_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.ZnakChisla();
        }

        private void btnpoint_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.ZnakTochki();
        }
        /// <summary>
        /// Обработчики кнопок действия калькулятора передают 
        /// методу DeystvieCalculatora класса mehanizmcalkulyatora переменную перечисления Deystvie.
        /// </summary>

        private void btn_delenie_Click(object sender, System.EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Delenie);
        }

        private void btn_umnojenie_Click(object sender, System.EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Umnojenie);
        }

        private void btn_minus_Click(object sender, System.EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Vichitanie);
        }

        private void btn_plus_Click(object sender, System.EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Slojenie);
        }

        private void btn_ravno_Click(object sender, System.EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.ZnakRavno();
            mehanizmcalkulyatora.Sbros();
        }

        private void btn_sbros_Click(object sender, System.EventArgs e)
        {
            mehanizmcalkulyatora.Sbros();
            txtOutput.Text = "0";
        }

        private void engineering_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 350);
            txtOutput.Size = new Size(268, 26);
            panelOsnov.Location = new Point(53, 134);
            panelDopOne.Visible = true;
            panelDopTwo.Visible = true;
            engineering.Checked = true;
            ordinary.Checked = false;
        }

        private void ordinary_Click(object sender, EventArgs e)
        {
            this.Size = new Size(260, 310);
            txtOutput.Size = new Size(228, 26);
            panelOsnov.Location = new Point(13, 94);
            panelDopOne.Visible = false;
            panelDopTwo.Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            ordinary.Checked = true;
            engineering.Checked = false;

        }

        private void squareNum_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.DopFunctionCalculator("squareNum");
        }

        private void chislovStepen_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.VozvedenieVStepen);
        }

        private void obrNumber_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.DopFunctionCalculator("obrNumber");
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            txtOutput.Text = mehanizmcalkulyatora.DopFunctionCalculator("squareRoot");
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Калькулятор WinForm \nПинигин С.Н. гр.124//05");
        }

    }
    class mehanizmcalkulyatora
    {
        /// <summary>
        ///Создаем перечисление Deystvie, для определения одного из четырех действия калькулятора + 1 действие возведения в степень
        /// </summary>
        public enum Deystvie : int
        {
            NeopredelDeystvie = 0,
            Slojenie = 1,
            Vichitanie = 2,
            Umnojenie = 3,
            Delenie = 4,
            VozvedenieVStepen = 5
        }

        /// <summary>
        /// Объявляем и инициализируем переменную, 
        /// которая будет использоваться для смены знака при нажатии клавиши (+/-)
        /// </summary>

        private static double peremennayaMinus = -1;

        /// <summary>
        /// Объвляем переменные, для работы калькулятора:
        /// resultatVichisleniy - переменная для хранения
        ///  промежуточного результата в механизме калькулятора
        ///  resultatOutput - переменная, значение которой будет сниматься с экрана и  выводиться на него.
        ///  tekusheeDeystvieCalculatora - хранение одного из действия калькулятора.
        ///  pervoeChislo - переменная, в которую будет записываться число на экране
        ///   до нажатия на одну из четырех кнопок с действием.
        ///  vtoroeChislo - второе число на экране.
        ///  dobavlenierazryada при добавлении следующего  разряда эта переменная примет значение true;
        ///  ChislosTochkoy при добавлении десятичного разряда (знака точки) эта переменная примет значение true
        /// </summary>

        private static double resultatVichisleniy;
        private static string resultatOutput;
        private static Deystvie tekusheeDeystvieCalculatora;
        private static double pervoeChislo;
        private static double vtoroeChislo;
        private static bool dobavlenierazryada;
        private static bool ChislosTochkoy;

        /// <summary>
        /// В конструкторе класса mehanizmcalkulyatora инициализируем переменные 
        /// ChislosTochkoy и dobavlenierazryada - при запуске калькулятора на экране 
        /// нет ни разрядности, ни десятичной части.
        /// </summary>

        public mehanizmcalkulyatora()
        {
            ChislosTochkoy = false;
            dobavlenierazryada = false;
        }


        /// <summary>
        /// В этом методе переменная resultatOutput изменяется - при вводе числа ее значение перезаписывается.
        /// </summary>


        public static string chislonaEkrane(string najatayaKlavisha)
        {
            resultatOutput = resultatOutput + najatayaKlavisha;
            return (resultatOutput);
        }
        /// <summary>
        /// Метод, в котором определяется peremenDeystviya - одно значение перечисления Deystvie,
        ///в зависимости от выбора  клавиши +, -, *,  или /
        /// </summary>


        public static void DeystvieCalculatora(Deystvie peremenDeystviya)
        {
            try
            {
                if (resultatOutput != "" && !dobavlenierazryada)
                {
                    pervoeChislo = System.Convert.ToDouble(resultatOutput);
                    tekusheeDeystvieCalculatora = peremenDeystviya;
                    resultatOutput = "";
                    ChislosTochkoy = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }
        /// <summary>
        ///  Дополнительные функции калькулятора: Обратное число, квадратный корень числа, квадрат числа.
        /// </summary>
        public static string DopFunctionCalculator(string parametr)
        {
            double result, stepen;
            switch (parametr)
            {
                case "obrNumber":
                    result = System.Convert.ToDouble(resultatOutput);
                    resultatOutput = System.Convert.ToString(1 / result);
                    break;
                case "squareNum":
                    result = System.Convert.ToDouble(resultatOutput);
                    resultatOutput = System.Convert.ToString(result * result);
                    break;
                case "squareRoot":
                    result = System.Convert.ToDouble(resultatOutput);
                    resultatOutput = System.Convert.ToString(Math.Sqrt(result));
                    break;
            }
            return resultatOutput;
        }

        /// <summary>
        /// При нажатии  кнопки +/- число на экране - tekusheeChislo умножается на -1,
        ///  а затем результат снова присваивается переменной resultatOutput.
        /// </summary>


        public static string ZnakChisla()
        {
            double tekusheeChislo;

            if (resultatOutput != "")
            {
                tekusheeChislo = System.Convert.ToDouble(resultatOutput);
                resultatOutput = System.Convert.ToString(tekusheeChislo * peremennayaMinus);
            }

            return (resultatOutput);
        }

        /// <summary>
        /// При нажатии кнопки ( , ) переменная resultatOutput приобретает дробную часть.
        /// </summary>


        public static string ZnakTochki()
        {
            if (!ChislosTochkoy && !dobavlenierazryada)
            {
                if (resultatOutput != "")
                    resultatOutput = resultatOutput + ",";
                else
                    resultatOutput = "0,";

                ChislosTochkoy = true;
            }

            return (resultatOutput);
        }

        /// <summary>
        /// При нажатии кнопки ZnakRavno обрабатываются значения 
        /// переменнных pervoeChislo и vtoroeChislo, результат присваивается переменной resultatVichisleniy 
        /// которая  затем преобразуется в resultatOutput.
        /// </summary>


        public static string ZnakRavno()
        {
            bool proverkaOshibok = false;

            if (resultatOutput != "")
            {
                vtoroeChislo = System.Convert.ToDouble(resultatOutput);
                dobavlenierazryada = true;

                switch (tekusheeDeystvieCalculatora)
                {
                    case Deystvie.NeopredelDeystvie:
                        proverkaOshibok = false;
                        break;

                    case Deystvie.Slojenie:
                        resultatVichisleniy = pervoeChislo + vtoroeChislo;
                        proverkaOshibok = true;
                        break;

                    case Deystvie.Vichitanie:
                        resultatVichisleniy = pervoeChislo - vtoroeChislo;
                        proverkaOshibok = true;
                        break;

                    case Deystvie.Umnojenie:
                        resultatVichisleniy = pervoeChislo * vtoroeChislo;
                        proverkaOshibok = true;
                        break;

                    case Deystvie.Delenie:
                        resultatVichisleniy = pervoeChislo / vtoroeChislo;
                        proverkaOshibok = true;
                        break;
                    case Deystvie.VozvedenieVStepen:
                        resultatVichisleniy = Math.Pow(pervoeChislo, vtoroeChislo);
                        proverkaOshibok = true;
                        break;
                    default:
                        proverkaOshibok = false;
                        break;
                }

                if (proverkaOshibok)
                    resultatOutput = System.Convert.ToString(resultatVichisleniy);
            }

            return (resultatOutput);
        }

        /// <summary>
        /// При нажатии кнопки  С (сброс) значения переменных обнуляются.
        /// </summary>

        public static void Sbros()
        {
            resultatVichisleniy = 0;
            pervoeChislo = 0;
            vtoroeChislo = 0;
            resultatOutput = "";
            tekusheeDeystvieCalculatora = Deystvie.NeopredelDeystvie;
            ChislosTochkoy = false;
            dobavlenierazryada = false;
        }
    }
}