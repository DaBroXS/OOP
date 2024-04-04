namespace forms
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
            Button_Cheak = new Button();
            Label_Result = new Label();
            TextBox_Input = new TextBox();
            SuspendLayout();
            // 
            // Button_Cheak
            // 
            Button_Cheak.Location = new Point(354, 150);
            Button_Cheak.Name = "Button_Cheak";
            Button_Cheak.Size = new Size(75, 23);
            Button_Cheak.TabIndex = 0;
            Button_Cheak.Text = "Cheak";
            Button_Cheak.UseVisualStyleBackColor = true;
            Button_Cheak.Click += Button_Cheak_Click;
            // 
            // Label_Resoult
            // 
            Label_Result.AutoSize = true;
            Label_Result.Location = new Point(372, 200);
            Label_Result.Name = "Label_Resoult";
            Label_Result.Size = new Size(0, 15);
            Label_Result.TabIndex = 1;
            // 
            // TextBox_Input
            // 
            TextBox_Input.Location = new Point(341, 106);
            TextBox_Input.Name = "TextBox_Input";
            TextBox_Input.Size = new Size(100, 23);
            TextBox_Input.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TextBox_Input);
            Controls.Add(Label_Result);
            Controls.Add(Button_Cheak);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Cheak;
        private Label Label_Result;
        private TextBox TextBox_Input;
    }
}
