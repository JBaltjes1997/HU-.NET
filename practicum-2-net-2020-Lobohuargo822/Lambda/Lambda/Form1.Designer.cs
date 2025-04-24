namespace Lambda
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.num1lab = new System.Windows.Forms.Label();
            this.num1Text = new System.Windows.Forms.TextBox();
            this.methodOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lambdaOutput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.num2Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num3Text = new System.Windows.Forms.TextBox();
            this.num3TextLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // num1lab
            // 
            this.num1lab.AutoSize = true;
            this.num1lab.Location = new System.Drawing.Point(34, 27);
            this.num1lab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.num1lab.Name = "num1lab";
            this.num1lab.Size = new System.Drawing.Size(60, 15);
            this.num1lab.TabIndex = 4;
            this.num1lab.Text = "Number 1";
            // 
            // num1Text
            // 
            this.num1Text.Location = new System.Drawing.Point(136, 23);
            this.num1Text.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.num1Text.Name = "num1Text";
            this.num1Text.Size = new System.Drawing.Size(31, 23);
            this.num1Text.TabIndex = 5;
            this.num1Text.TextChanged += new System.EventHandler(this.num1Text_TextChanged);
            // 
            // methodOutput
            // 
            this.methodOutput.Location = new System.Drawing.Point(37, 157);
            this.methodOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.methodOutput.Name = "methodOutput";
            this.methodOutput.Size = new System.Drawing.Size(285, 264);
            this.methodOutput.TabIndex = 6;
            this.methodOutput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Method output";
            // 
            // lambdaOutput
            // 
            this.lambdaOutput.Location = new System.Drawing.Point(363, 157);
            this.lambdaOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lambdaOutput.Name = "lambdaOutput";
            this.lambdaOutput.Size = new System.Drawing.Size(285, 264);
            this.lambdaOutput.TabIndex = 8;
            this.lambdaOutput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lambda output";
            // 
            // num2Text
            // 
            this.num2Text.Location = new System.Drawing.Point(136, 57);
            this.num2Text.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.num2Text.Name = "num2Text";
            this.num2Text.Size = new System.Drawing.Size(31, 23);
            this.num2Text.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number 2";
            // 
            // num3Text
            // 
            this.num3Text.Location = new System.Drawing.Point(136, 90);
            this.num3Text.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.num3Text.Name = "num3Text";
            this.num3Text.Size = new System.Drawing.Size(31, 23);
            this.num3Text.TabIndex = 13;
            // 
            // num3TextLb
            // 
            this.num3TextLb.AutoSize = true;
            this.num3TextLb.Location = new System.Drawing.Point(34, 93);
            this.num3TextLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.num3TextLb.Name = "num3TextLb";
            this.num3TextLb.Size = new System.Drawing.Size(60, 15);
            this.num3TextLb.TabIndex = 12;
            this.num3TextLb.Text = "Number 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 468);
            this.Controls.Add(this.num3Text);
            this.Controls.Add(this.num3TextLb);
            this.Controls.Add(this.num2Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lambdaOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.methodOutput);
            this.Controls.Add(this.num1Text);
            this.Controls.Add(this.num1lab);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label num1lab;
        private System.Windows.Forms.TextBox num1Text;
        private System.Windows.Forms.RichTextBox methodOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox lambdaOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num2Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num3Text;
        private System.Windows.Forms.Label num3TextLb;
    }
}

