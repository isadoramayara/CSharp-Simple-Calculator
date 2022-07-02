
namespace IMSS.Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.boxDisplay = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblExpression = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(38, 401);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(77, 55);
            this.btnOne.TabIndex = 2;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.numButtons);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(149, 401);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(77, 55);
            this.btnTwo.TabIndex = 3;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.numButtons);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(260, 401);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(77, 55);
            this.btnThree.TabIndex = 4;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.numButtons);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(38, 324);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(77, 55);
            this.btnFour.TabIndex = 5;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.numButtons);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(149, 324);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(77, 55);
            this.btnFive.TabIndex = 6;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.numButtons);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(260, 324);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(77, 55);
            this.btnSix.TabIndex = 7;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.numButtons);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(38, 247);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(77, 55);
            this.btnSeven.TabIndex = 8;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.numButtons);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(149, 247);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(77, 55);
            this.btnEight.TabIndex = 9;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.numButtons);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(260, 247);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(77, 55);
            this.btnNine.TabIndex = 10;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.numButtons);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(38, 478);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(77, 55);
            this.btnZero.TabIndex = 1;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.numButtons);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(149, 478);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(77, 55);
            this.btnDot.TabIndex = 0;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.numButtons);
            // 
            // btnClearAll
            // 
            this.btnClearAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearAll.Location = new System.Drawing.Point(192, 170);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(145, 55);
            this.btnClearAll.TabIndex = 22;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // boxDisplay
            // 
            this.boxDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.boxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDisplay.Location = new System.Drawing.Point(37, 78);
            this.boxDisplay.MaximumSize = new System.Drawing.Size(500, 500);
            this.boxDisplay.MaxLength = 17;
            this.boxDisplay.MinimumSize = new System.Drawing.Size(4, 5);
            this.boxDisplay.Name = "boxDisplay";
            this.boxDisplay.ReadOnly = true;
            this.boxDisplay.Size = new System.Drawing.Size(410, 49);
            this.boxDisplay.TabIndex = 1;
            this.boxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.boxDisplay.TextChanged += new System.EventHandler(this.boxDisplay_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(37, 170);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 55);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(260, 478);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(77, 55);
            this.btnEqual.TabIndex = 24;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(371, 170);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(77, 55);
            this.btnDivision.TabIndex = 16;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.mathOperators);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(371, 247);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(77, 55);
            this.btnMulti.TabIndex = 17;
            this.btnMulti.Text = "×";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.mathOperators);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(371, 324);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(77, 55);
            this.btnMinus.TabIndex = 18;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.mathOperators);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(371, 401);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(77, 132);
            this.btnPlus.TabIndex = 19;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.mathOperators);
            // 
            // lblExpression
            // 
            this.lblExpression.AutoSize = true;
            this.lblExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpression.Location = new System.Drawing.Point(38, 50);
            this.lblExpression.MaximumSize = new System.Drawing.Size(410, 25);
            this.lblExpression.MinimumSize = new System.Drawing.Size(410, 25);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(410, 25);
            this.lblExpression.TabIndex = 25;
            this.lblExpression.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClearAll;
            this.ClientSize = new System.Drawing.Size(485, 559);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.boxDisplay);
            this.Controls.Add(this.btnOne);
            this.Name = "Calculator";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.TextBox boxDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblExpression;
    }
}

