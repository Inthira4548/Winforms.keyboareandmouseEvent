namespace Winforms.keyboareandmouseEvent
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
            lblResult = new Label();
            txtInput = new TextBox();
            txtCode = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.Location = new Point(44, 72);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(102, 73);
            lblResult.TabIndex = 0;
            lblResult.Text = "label1";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(100, 69);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(208, 27);
            txtInput.TabIndex = 1;
            txtInput.KeyPress += txtInput_KeyPress;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(100, 118);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(208, 27);
            txtCode.TabIndex = 2;
            txtCode.KeyPress += txtCode_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 27);
            textBox1.TabIndex = 3;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(txtCode);
            Controls.Add(txtInput);
            Controls.Add(lblResult);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private TextBox txtInput;
        private TextBox txtCode;
        private TextBox textBox1;
    }
}
