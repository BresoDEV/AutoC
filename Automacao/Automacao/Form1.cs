using System.Windows.Forms;

namespace Automacao
{
    public partial class Form1 : Form
    {
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
                $"Tem. Monitor: {Screen.PrimaryScreen.Bounds.Size.Width}x{Screen.PrimaryScreen.Bounds.Size.Width}";
        }



        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    label1.Text = dlg.FileName;
                    button3.Enabled = true;

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
            auto.interpretarCodigo(label1.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            auto.tempoDelay = 1;
            auto.trigger_clicks((int)numericUpDown1.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            auto.mover_mouse(100, 100);
            auto.mover_mouse(500, 100);
            auto.mover_mouse(500, 500);
            auto.mover_mouse(100, 500);
            auto.mover_mouse(100, 100);
        }
    }
}
