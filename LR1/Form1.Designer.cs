
namespace LR1
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
            this.TextBox_X = new System.Windows.Forms.TextBox();
            this.Label_X = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Y = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Label_Y = new System.Windows.Forms.Label();
            this.Label_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox_X
            // 
            this.TextBox_X.Location = new System.Drawing.Point(156, 80);
            this.TextBox_X.Name = "TextBox_X";
            this.TextBox_X.Size = new System.Drawing.Size(224, 20);
            this.TextBox_X.TabIndex = 0;
            this.TextBox_X.Text = "1";
            // 
            // Label_X
            // 
            this.Label_X.AutoSize = true;
            this.Label_X.Location = new System.Drawing.Point(153, 64);
            this.Label_X.Name = "Label_X";
            this.Label_X.Size = new System.Drawing.Size(12, 13);
            this.Label_X.TabIndex = 1;
            this.Label_X.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // TextBox_Y
            // 
            this.TextBox_Y.Location = new System.Drawing.Point(156, 133);
            this.TextBox_Y.Name = "TextBox_Y";
            this.TextBox_Y.Size = new System.Drawing.Size(224, 20);
            this.TextBox_Y.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label_Y
            // 
            this.Label_Y.AutoSize = true;
            this.Label_Y.Location = new System.Drawing.Point(156, 117);
            this.Label_Y.Name = "Label_Y";
            this.Label_Y.Size = new System.Drawing.Size(12, 13);
            this.Label_Y.TabIndex = 7;
            this.Label_Y.Text = "y";
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Location = new System.Drawing.Point(537, 169);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(32, 13);
            this.Label_Result.TabIndex = 8;
            this.Label_Result.Text = "result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.Label_Y);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_Y);
            this.Controls.Add(this.Label_X);
            this.Controls.Add(this.TextBox_X);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_X;
        private System.Windows.Forms.Label Label_X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_Y;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Label_Y;
        private System.Windows.Forms.Label Label_Result;
    }
}

