namespace Automacao
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
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            button1 = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.Location = new Point(12, 27);
            button2.Name = "button2";
            button2.Size = new Size(104, 23);
            button2.TabIndex = 3;
            button2.Text = "Abrir Script";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(12, 56);
            button3.Name = "button3";
            button3.Size = new Size(104, 23);
            button3.TabIndex = 5;
            button3.Text = "Executar Script";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(126, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(159, 89);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Debug";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.Location = new Point(215, 20);
            button1.Name = "button1";
            button1.Size = new Size(52, 23);
            button1.TabIndex = 7;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(12, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(273, 53);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "trigger_clicks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 24);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 9;
            label3.Text = "Quantidade de Clicks";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(137, 20);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(76, 23);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // button4
            // 
            button4.Location = new Point(381, 56);
            button4.Name = "button4";
            button4.Size = new Size(52, 23);
            button4.TabIndex = 9;
            button4.Text = "Iniciar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(291, 156);
            Controls.Add(button4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            TopMost = true;
            TransparencyKey = SystemColors.ActiveBorder;
            Load += Form1_Load;
            KeyUp += Form1_KeyUp;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Button button2;
        private Label label1;
        private Button button3;
        private GroupBox groupBox1;
        private Label label2;
        private Button button1;
        private GroupBox groupBox2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button button4;
    }
}
