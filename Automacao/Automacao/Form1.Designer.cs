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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button3 = new Button();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            panel1 = new Panel();
            button4 = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            groupBox3 = new GroupBox();
            label5 = new Label();
            trackBar1 = new TrackBar();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(6, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(192, 89);
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
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(6, 100);
            button1.Name = "button1";
            button1.Size = new Size(180, 23);
            button1.TabIndex = 7;
            button1.Text = "Rolar Baixo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(button1);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(192, 137);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rolagem Debug";
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(6, 71);
            button3.Name = "button3";
            button3.Size = new Size(180, 23);
            button3.TabIndex = 10;
            button3.Text = "Rolar Cima";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 24);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 9;
            label3.Text = "Quantidade de Rolagem";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(30, 30, 30);
            numericUpDown1.ForeColor = SystemColors.ButtonFace;
            numericUpDown1.Location = new Point(6, 42);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 23);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(50, 50, 50);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = SystemColors.ScrollBar;
            richTextBox1.Location = new Point(204, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(582, 427);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.baixados__1_;
            pictureBox1.Location = new Point(29, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.baixados;
            pictureBox2.Location = new Point(55, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.OIP;
            pictureBox3.Location = new Point(81, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.images__1_;
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Location = new Point(107, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(20, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(376, 8);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(143, 19);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Minimizar ao Executar";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(30, 30, 30);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.ForeColor = SystemColors.ButtonFace;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "pararMouseZerado", "alerta_msg", "add_arquivo_area_de_transferencia", "definir_delay", "mover_mouse", "mover_mouse_relativo", "mover_mouse_e_clicar_esquerdo", "mover_mouse_e_clicar_direito", "mover_mouse_e_duplo_click", "digitar_teclado", "scroll_baixo", "scroll_cima", "trigger_clicks", "soltar_click_mouse_direito", "soltar_click_mouse_esquerdo", "click_mouse_direito_sem_soltar", "click_mouse_esquerdo_sem_soltar", "click_mouse_direito_padrao", "click_mouse_esquerdo_padrao", "ctrlC", "ctrlV", "duplo_click_mouse", "AltTab", "Enter", "SegurarCTRL", "SoltarCTRL", "SegurarALT", "SoltarALT", "SegurarSHIFT", "SoltarSHIFT", "soltar_todas_teclas", "obter_idade_pessoa", "obter_rg_pessoa", "obter_cpf_pontuado_pessoa", "obter_Email_pessoa", "obter_nome_completo_pessoa", "obter_sobrenome_pessoa", "obter_nome_pessoa", "criar_pessoa", "obter_pessoa_completa", "obter_pessoa_completa", "alerta_msg_transferencia" });
            comboBox1.Location = new Point(6, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 23);
            comboBox1.TabIndex = 20;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(6, 51);
            button2.Name = "button2";
            button2.Size = new Size(180, 23);
            button2.TabIndex = 21;
            button2.Text = "Inserir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(133, 2);
            numericUpDown2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 22;
            numericUpDown2.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(259, 7);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 23;
            label4.Text = "Delay para Iniciar";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 34);
            panel1.TabIndex = 24;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(603, 5);
            button4.Name = "button4";
            button4.Size = new Size(180, 23);
            button4.TabIndex = 24;
            button4.Text = "Estrutura Padrão";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(richTextBox1);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 427);
            panel2.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 30, 30);
            panel4.Controls.Add(groupBox3);
            panel4.Controls.Add(groupBox2);
            panel4.Controls.Add(groupBox1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(204, 427);
            panel4.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(trackBar1);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(button2);
            groupBox3.ForeColor = SystemColors.ButtonFace;
            groupBox3.Location = new Point(6, 245);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(192, 169);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 96);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 0;
            label5.Text = "Tamanho da Fonte:";
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.FromArgb(30, 30, 30);
            trackBar1.Location = new Point(6, 118);
            trackBar1.Maximum = 50;
            trackBar1.Minimum = 10;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(180, 45);
            trackBar1.TabIndex = 22;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Value = 10;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(786, 461);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Breso AutomaticBot Compiler";
            TransparencyKey = SystemColors.ActiveBorder;
            Load += Form1_Load;
            KeyUp += Form1_KeyUp;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Button button1;
        private GroupBox groupBox2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private TrackBar trackBar1;
        private GroupBox groupBox3;
        private Label label5;
        private Button button4;
    }
}
