
using System;

namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txbNumber1 = new System.Windows.Forms.TextBox();
            this.txbNumber2 = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rem = new System.Windows.Forms.Label();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonMinusPlus = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button1x = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.history = new System.Windows.Forms.TextBox();
            this.History1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbNumber1
            // 
            this.txbNumber1.Location = new System.Drawing.Point(14, 33);
            this.txbNumber1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txbNumber1.Multiline = true;
            this.txbNumber1.Name = "txbNumber1";
            this.txbNumber1.Size = new System.Drawing.Size(227, 40);
            this.txbNumber1.TabIndex = 1;
            this.txbNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbNumber2
            // 
            this.txbNumber2.Location = new System.Drawing.Point(98, 8);
            this.txbNumber2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txbNumber2.Multiline = true;
            this.txbNumber2.Name = "txbNumber2";
            this.txbNumber2.Size = new System.Drawing.Size(143, 23);
            this.txbNumber2.TabIndex = 2;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(185, 138);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(56, 25);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(272, 19);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 37);
            this.lblResult.TabIndex = 4;
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(185, 42);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(56, 25);
            this.btnDiv.TabIndex = 5;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(185, 71);
            this.btnMult.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(56, 25);
            this.btnMult.TabIndex = 6;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(185, 103);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(56, 25);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Location = new System.Drawing.Point(253, 40);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rem);
            this.splitContainer1.Panel1.Controls.Add(this.txbNumber1);
            this.splitContainer1.Panel1.Controls.Add(this.lblResult);
            this.splitContainer1.Panel1.Controls.Add(this.txbNumber2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonPercent);
            this.splitContainer1.Panel2.Controls.Add(this.button0);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDot);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSum);
            this.splitContainer1.Panel2.Controls.Add(this.buttonMinusPlus);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCE);
            this.splitContainer1.Panel2.Controls.Add(this.buttonC);
            this.splitContainer1.Panel2.Controls.Add(this.buttonX);
            this.splitContainer1.Panel2.Controls.Add(this.button10);
            this.splitContainer1.Panel2.Controls.Add(this.button11);
            this.splitContainer1.Panel2.Controls.Add(this.button1x);
            this.splitContainer1.Panel2.Controls.Add(this.btnMinus);
            this.splitContainer1.Panel2.Controls.Add(this.btnDiv);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.btnPlus);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.button5);
            this.splitContainer1.Panel2.Controls.Add(this.btnMult);
            this.splitContainer1.Panel2.Controls.Add(this.button6);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.button8);
            this.splitContainer1.Panel2.Controls.Add(this.button9);
            this.splitContainer1.Panel2.Controls.Add(this.button7);
            this.splitContainer1.Size = new System.Drawing.Size(350, 285);
            this.splitContainer1.SplitterDistance = 88;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 9;
            // 
            // rem
            // 
            this.rem.AutoSize = true;
            this.rem.Location = new System.Drawing.Point(194, 11);
            this.rem.Name = "rem";
            this.rem.Size = new System.Drawing.Size(0, 15);
            this.rem.TabIndex = 5;
            // 
            // buttonPercent
            // 
            this.buttonPercent.Location = new System.Drawing.Point(3, 10);
            this.buttonPercent.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(56, 25);
            this.buttonPercent.TabIndex = 30;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.buttonPercent_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(63, 168);
            this.button0.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(56, 25);
            this.button0.TabIndex = 27;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Location = new System.Drawing.Point(126, 168);
            this.buttonDot.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(56, 25);
            this.buttonDot.TabIndex = 28;
            this.buttonDot.Text = ".";
            this.buttonDot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDot.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDot.UseCompatibleTextRendering = true;
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(185, 168);
            this.buttonSum.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(56, 25);
            this.buttonSum.TabIndex = 26;
            this.buttonSum.Text = "=";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonMinusPlus
            // 
            this.buttonMinusPlus.Location = new System.Drawing.Point(2, 168);
            this.buttonMinusPlus.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonMinusPlus.Name = "buttonMinusPlus";
            this.buttonMinusPlus.Size = new System.Drawing.Size(56, 25);
            this.buttonMinusPlus.TabIndex = 29;
            this.buttonMinusPlus.Text = "+/-";
            this.buttonMinusPlus.UseVisualStyleBackColor = true;
            this.buttonMinusPlus.Click += new System.EventHandler(this.buttonMinusPlus_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(63, 10);
            this.buttonCE.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(56, 25);
            this.buttonCE.TabIndex = 23;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(126, 10);
            this.buttonC.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(56, 25);
            this.buttonC.TabIndex = 24;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(185, 10);
            this.buttonX.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(56, 25);
            this.buttonX.TabIndex = 22;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(63, 42);
            this.button10.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(56, 25);
            this.button10.TabIndex = 19;
            this.button10.Text = "X^2";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(126, 42);
            this.button11.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(56, 25);
            this.button11.TabIndex = 20;
            this.button11.Text = "Sqrt";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button1x
            // 
            this.button1x.Location = new System.Drawing.Point(2, 42);
            this.button1x.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1x.Name = "button1x";
            this.button1x.Size = new System.Drawing.Size(56, 25);
            this.button1x.TabIndex = 21;
            this.button1x.Text = "1/x";
            this.button1x.UseVisualStyleBackColor = true;
            this.button1x.Click += new System.EventHandler(this.button1x_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 138);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 25);
            this.button2.TabIndex = 16;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(126, 138);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 25);
            this.button3.TabIndex = 17;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 138);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 25);
            this.button1.TabIndex = 18;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(63, 103);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 25);
            this.button5.TabIndex = 13;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(126, 103);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 25);
            this.button6.TabIndex = 14;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(2, 103);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 25);
            this.button4.TabIndex = 15;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(63, 71);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 25);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(126, 71);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 25);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(2, 71);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 25);
            this.button7.TabIndex = 10;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(502, 48);
            this.history.MinimumSize = new System.Drawing.Size(10, 100);
            this.history.Multiline = true;
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(94, 276);
            this.history.TabIndex = 6;
            // 
            // History1
            // 
            this.History1.Location = new System.Drawing.Point(507, 295);
            this.History1.Name = "History1";
            this.History1.Size = new System.Drawing.Size(85, 23);
            this.History1.TabIndex = 0;
            this.History1.Text = "Delate";
            this.History1.UseVisualStyleBackColor = true;
            this.History1.Click += new System.EventHandler(this.History1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 335);
            this.Controls.Add(this.History1);
            this.Controls.Add(this.history);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        

       

        #endregion
        private System.Windows.Forms.TextBox txbNumber1;
        private System.Windows.Forms.TextBox txbNumber2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button1x;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonMinusPlus;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label rem;
        private System.Windows.Forms.TextBox history;
        private System.Windows.Forms.Button History1;
    }
}

