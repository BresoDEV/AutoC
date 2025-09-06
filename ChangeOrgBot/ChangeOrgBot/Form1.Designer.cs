namespace ChangeOrgBot
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            checkBox1 = new CheckBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(12, 41);
            button1.Name = "button1";
            button1.Size = new Size(224, 23);
            button1.TabIndex = 0;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "https://www.change.org/p/nomear-os-aprovados-na-funda%C3%A7%C3%A3o-de-assist%C3%AAncia-social-de-caxias-do-sul?source_location=search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 136);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 165);
            label2.Name = "label2";
            label2.Size = new Size(43, 51);
            label2.TabIndex = 3;
            label2.Text = "label2\r\nlabel2\r\nlabel2";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(107, 70);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(129, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = SystemColors.ButtonFace;
            radioButton1.Location = new Point(12, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(66, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Portaria";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = SystemColors.ButtonFace;
            radioButton2.Location = new Point(107, 12);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "PC Gamer";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(12, 231);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(130, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Minimizar ao iniciar";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(12, 72);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 9;
            label3.Text = "Repetições:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(button2);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(242, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(80, 110);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Scrool mouse";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(6, 22);
            numericUpDown2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(66, 23);
            numericUpDown2.TabIndex = 1;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button2
            // 
            button2.ForeColor = Color.FromArgb(64, 64, 64);
            button2.Location = new Point(6, 56);
            button2.Name = "button2";
            button2.Size = new Size(66, 23);
            button2.TabIndex = 0;
            button2.Text = "Scrollar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(148, 231);
            button3.Name = "button3";
            button3.Size = new Size(174, 23);
            button3.TabIndex = 11;
            button3.Text = "Teste de Log";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(331, 257);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            ForeColor = SystemColors.ButtonFace;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private CheckBox checkBox1;
        private Label label3;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown2;
        private Button button2;
        private Button button3;
    }
}
