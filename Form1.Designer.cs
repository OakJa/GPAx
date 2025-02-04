namespace Gpax
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
            btnAdd = new Button();
            label1 = new Label();
            tbGPAxinput = new TextBox();
            tbGPAx = new TextBox();
            label2 = new Label();
            tbGPAMin = new TextBox();
            label3 = new Label();
            tbGPAMax = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(311, 114);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 67);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Adddata";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 69);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 1;
            label1.Text = "ใส่ GPA";
            // 
            // tbGPAxinput
            // 
            tbGPAxinput.Location = new Point(126, 66);
            tbGPAxinput.Name = "tbGPAxinput";
            tbGPAxinput.Size = new Size(140, 27);
            tbGPAxinput.TabIndex = 2;
            // 
            // tbGPAx
            // 
            tbGPAx.Enabled = false;
            tbGPAx.Location = new Point(126, 109);
            tbGPAx.Name = "tbGPAx";
            tbGPAx.Size = new Size(140, 27);
            tbGPAx.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 112);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 3;
            label2.Text = "GPAx";
            // 
            // tbGPAMin
            // 
            tbGPAMin.Enabled = false;
            tbGPAMin.Location = new Point(126, 197);
            tbGPAMin.Name = "tbGPAMin";
            tbGPAMin.Size = new Size(140, 27);
            tbGPAMin.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 200);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 7;
            label3.Text = "GPAmin";
            // 
            // tbGPAMax
            // 
            tbGPAMax.Enabled = false;
            tbGPAMax.Location = new Point(126, 154);
            tbGPAMax.Name = "tbGPAMax";
            tbGPAMax.Size = new Size(140, 27);
            tbGPAMax.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 157);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 5;
            label4.Text = "GPAmax";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 311);
            Controls.Add(tbGPAMin);
            Controls.Add(label3);
            Controls.Add(tbGPAMax);
            Controls.Add(label4);
            Controls.Add(tbGPAx);
            Controls.Add(label2);
            Controls.Add(tbGPAxinput);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private TextBox tbGPAxinput;
        private TextBox tbGPAx;
        private Label label2;
        private TextBox tbGPAMin;
        private Label label3;
        private TextBox tbGPAMax;
        private Label label4;
    }
}
