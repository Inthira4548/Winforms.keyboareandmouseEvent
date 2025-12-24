namespace Winforms.keyboareandmouseEvent
{
    partial class Form2
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
            label1 = new Label();
            btnTest = new Button();
            lblTarget = new Label();
            txtSource = new TextBox();
            btnMove = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 57);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // btnTest
            // 
            btnTest.Location = new Point(296, 48);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(94, 29);
            btnTest.TabIndex = 1;
            btnTest.Text = "button1";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.MouseEnter += btnTest_MouseEnter;
            btnTest.MouseLeave += btnTest_MouseLeave;
            // 
            // lblTarget
            // 
            lblTarget.AllowDrop = true;
            lblTarget.AutoSize = true;
            lblTarget.Location = new Point(314, 229);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(50, 20);
            lblTarget.TabIndex = 2;
            lblTarget.Text = "label2";
            lblTarget.DragDrop += lblTarget_DragDrop;
            lblTarget.DragEnter += lblTarget_DragEnter;
            // 
            // txtSource
            // 
            txtSource.Location = new Point(159, 222);
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(125, 27);
            txtSource.TabIndex = 3;
            txtSource.MouseDown += txtSource_MouseDown;
            // 
            // btnMove
            // 
            btnMove.Location = new Point(191, 348);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(94, 29);
            btnMove.TabIndex = 4;
            btnMove.Text = "(btnMove)";
            btnMove.UseVisualStyleBackColor = true;
            btnMove.MouseDown += btnMove_MouseDown;
            btnMove.MouseMove += btnMove_MouseMove;
            btnMove.MouseUp += btnMove_MouseUp;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMove);
            Controls.Add(txtSource);
            Controls.Add(lblTarget);
            Controls.Add(btnTest);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            MouseClick += Form2_MouseClick;
            MouseMove += Form2_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnTest;
        private Label lblTarget;
        private TextBox txtSource;
        private Button btnMove;
    }
}