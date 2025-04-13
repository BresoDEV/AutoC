using System.Buffers.Text;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Automacao
{
    public partial class Form1 : Form
    {
        public static bool scriptFoiAlterado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            auto.soltar_todas_teclas();

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
             
            label2.Text = $"Mouse X: {Cursor.Position.X}\n" +
                $"Mouse Y: {Cursor.Position.Y}\n" +
                $"Tam. Monitor: {Screen.PrimaryScreen.Bounds.Size.Width}x{Screen.PrimaryScreen.Bounds.Size.Width}";
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Thread.Sleep((int)numericUpDown2.Value);
            auto.scroll_baixo((int)numericUpDown1.Value);
        }






        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (scriptFoiAlterado)
            {
                DialogResult result = MessageBox.Show("Você deseja continuar?\nO script atual será perdido se não foi salvo", "Alerta", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (dlg.FileName.Contains(auto.extensaoScript))

                        richTextBox1.Text = auto.dec(File.ReadAllText(dlg.FileName));

                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (lexica.linhas_terminam_com_ponto_e_virgula(richTextBox1))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = $"Script Files (*{auto.extensaoScript})|*{auto.extensaoScript}";
                    saveFileDialog.DefaultExt = $"{auto.extensaoScript.Replace(".", "")}";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            File.WriteAllText(saveFileDialog.FileName, auto.enc(richTextBox1.Text));

                            scriptFoiAlterado = false;
                        }
                        catch (Exception ex) { }
                    }
                }
            }


        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            scriptFoiAlterado = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (lexica.linhas_terminam_com_ponto_e_virgula(richTextBox1))
            {
                if (lexica.linhas_nativos_corretos(richTextBox1))
                {
                    this.Text = "Executando...";
                    if (checkBox1.Checked)
                    {
                        this.WindowState = FormWindowState.Minimized;
                    }
                    Thread.Sleep((int)numericUpDown2.Value);
                    auto.interpretarCodigo(richTextBox1.Text);
                    this.Text = "";
                }
                else
                {
                    this.Text = "Erro";
                }
                    
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "pararMouseZerado": richTextBox1.Text += "pararMouseZerado;"; break;
                case "alerta_msg": richTextBox1.Text += "alerta_msg Hello World;"; break;
                case "digitar_teclado": richTextBox1.Text += "digitar_teclado Hello World;"; break;
                case "add_arquivo_area_de_transferencia": richTextBox1.Text += "add_arquivo_area_de_transferencia c:/Foto.png;"; break;
                case "definir_delay": richTextBox1.Text += "definir_delay 1000;"; break;
                case "mover_mouse": richTextBox1.Text += "mover_mouse X Y;"; break;
                case "mover_mouse_relativo": richTextBox1.Text += "mover_mouse_relativo X Y;"; break;
                case "mover_mouse_e_clicar_esquerdo": richTextBox1.Text += "mover_mouse_e_clicar_esquerdo X Y;"; break;
                case "mover_mouse_e_clicar_direito": richTextBox1.Text += "mover_mouse_e_clicar_direito X Y;"; break;
                case "mover_mouse_e_duplo_click": richTextBox1.Text += "mover_mouse_e_duplo_click X Y;"; break;
                case "scroll_baixo": richTextBox1.Text += "scroll_baixo 10;"; break;
                case "scroll_cima": richTextBox1.Text += "scroll_cima 10;"; break;
                case "trigger_clicks": richTextBox1.Text += "trigger_clicks 10;"; break;
                case "soltar_click_mouse_direito": richTextBox1.Text += "soltar_click_mouse_direito;"; break;
                case "soltar_click_mouse_esquerdo": richTextBox1.Text += "soltar_click_mouse_esquerdo;"; break;
                case "click_mouse_direito_sem_soltar": richTextBox1.Text += "click_mouse_direito_sem_soltar;"; break;
                case "click_mouse_esquerdo_sem_soltar": richTextBox1.Text += "click_mouse_esquerdo_sem_soltar;"; break;
                case "click_mouse_direito_padrao": richTextBox1.Text += "click_mouse_direito_padrao;"; break;
                case "click_mouse_esquerdo_padrao": richTextBox1.Text += "click_mouse_esquerdo_padrao;"; break;
                case "ctrlC": richTextBox1.Text += "ctrlC;"; break;
                case "ctrlV": richTextBox1.Text += "ctrlV;"; break;
                case "duplo_click_mouse": richTextBox1.Text += "duplo_click_mouse;"; break;
                case "AltTab": richTextBox1.Text += "AltTab;"; break;
                case "Enter": richTextBox1.Text += "Enter;"; break;
                case "SegurarCTRL": richTextBox1.Text += "SegurarCTRL;"; break;
                case "SoltarCTRL": richTextBox1.Text += "SoltarCTRL;"; break;
                case "SegurarALT": richTextBox1.Text += "SegurarALT;"; break;
                case "SoltarALT": richTextBox1.Text += "SoltarALT;"; break;
                case "SegurarSHIFT": richTextBox1.Text += "SegurarSHIFT;"; break;
                case "SoltarSHIFT": richTextBox1.Text += "SoltarSHIFT;"; break;
                case "soltar_todas_teclas": richTextBox1.Text += "soltar_todas_teclas;"; break;
                case "obter_idade_pessoa": richTextBox1.Text += "obter_idade_pessoa;"; break;
                case "obter_rg_pessoa": richTextBox1.Text += "obter_rg_pessoa;"; break;
                case "obter_cpf_pontuado_pessoa": richTextBox1.Text += "obter_cpf_pontuado_pessoa;"; break;
                case "obter_Email_pessoa": richTextBox1.Text += "obter_Email_pessoa;"; break;
                case "obter_nome_completo_pessoa": richTextBox1.Text += "obter_nome_completo_pessoa;"; break;
                case "obter_sobrenome_pessoa": richTextBox1.Text += "obter_sobrenome_pessoa;"; break;
                case "obter_nome_pessoa": richTextBox1.Text += "obter_nome_pessoa;"; break;
                case "criar_pessoa": richTextBox1.Text += "criar_pessoa;"; break;
                case "obter_pessoa_completa": richTextBox1.Text += "obter_pessoa_completa;"; break;
                case "alerta_msg_transferencia": richTextBox1.Text += "alerta_msg_transferencia;"; break;
                case "digitar_teclado_area_de_transferencia": richTextBox1.Text += "digitar_teclado_area_de_transferencia;"; break;
                
                    //case "": richTextBox1.Text += ";";break;
            }
            /*
                  
                 
                 
                 
                 
             */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread.Sleep((int)numericUpDown2.Value);
            auto.scroll_cima((int)numericUpDown1.Value);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("Você deseja continuar?\nO script atual será perdido se não foi salvo", "Alerta", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    richTextBox1.Text = "";
                }
            }
            else
            {
                richTextBox1.Text = "";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Segoe UI", Convert.ToSingle(trackBar1.Value), FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "## Interrompe o script ao por o mouse em X=0 e Y=0;"+Environment.NewLine+
                "pararMouseZerado;" + Environment.NewLine +
                "## Define o intervalo entre funcoes;" + Environment.NewLine +
                "definir_delay 2000;" + Environment.NewLine +
                "## Define o numero de repetiçoes;" + Environment.NewLine +
                "repetir 0;"+ Environment.NewLine +
                "alerta_msg Finalizou o script;"+ Environment.NewLine ;
        }
    }
}
