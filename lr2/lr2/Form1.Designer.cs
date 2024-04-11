namespace lr2
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
            TextBox_Input = new TextBox();
            Button_Calculate = new Button();
            Label_Sum = new Label();
            Label_Average = new Label();
            SuspendLayout();
            // 
            // TextBox_Input
            // 
            TextBox_Input.Location = new Point(385, 89);
            TextBox_Input.Name = "TextBox_Input";
            TextBox_Input.Size = new Size(100, 23);
            TextBox_Input.TabIndex = 0;
            // 
            // Button_Calculate
            // 
            Button_Calculate.Location = new Point(398, 200);
            Button_Calculate.Name = "Button_Calculate";
            Button_Calculate.Size = new Size(75, 23);
            Button_Calculate.TabIndex = 1;
            Button_Calculate.Text = "Calculate";
            Button_Calculate.UseVisualStyleBackColor = true;
            Button_Calculate.Click += Button_Calculate_Click;
            // 
            // Label_Sum
            // 
            Label_Sum.AutoSize = true;
            Label_Sum.Location = new Point(435, 132);
            Label_Sum.Name = "Label_Sum";
            Label_Sum.Size = new Size(0, 15);
            Label_Sum.TabIndex = 2;
            // 
            // Label_Average
            // 
            Label_Average.AutoSize = true;
            Label_Average.Location = new Point(435, 171);
            Label_Average.Name = "Label_Average";
            Label_Average.Size = new Size(0, 15);
            Label_Average.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Label_Average);
            Controls.Add(Label_Sum);
            Controls.Add(Button_Calculate);
            Controls.Add(TextBox_Input);
            Name = "Form1";
            Text = "S";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBox_Input;
        private Button Button_Calculate;
        private Label Label_Sum;
        private Label Label_Average;
    }
}
