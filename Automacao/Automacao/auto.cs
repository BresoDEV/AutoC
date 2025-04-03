using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Automacao
{

    internal class auto
    {
        public static int tempoDelay = 1000;
        public static int repeats = 1;
        public static bool pararMouseZerado = false;
        public static void interpretarCodigo(string arquivo)
        {
            try
            {
                string[] linhas = File.ReadAllText(arquivo).Split(';');


                //=======================
                //bool faltouVirgula = false;
                //int ctfaltouVirgula = 0;
                //foreach (string line in linhas)
                //{
                //    ctfaltouVirgula++;
                //    if (line.Contains(";"))
                //    {
                //        faltouVirgula = true;
                //        break;
                //    }
                //   
                //}
                //if (faltouVirgula)
                //{
                //    throw new Exception("Erro: faltou ';' no final da linha "+ ctfaltouVirgula);
                //   
                //}
                //=======================


                foreach (string line in linhas)
                {
                    if (line.Contains("pararMouseZerado;"))
                    {
                        pararMouseZerado = true;
                    }
                    if (line.Contains("alerta_msg "))
                    {
                        string b = line.Replace("alerta_msg ", "");
                        b = b.Replace(";", "");
                        alerta_msg(b);
                    }
                    if (line.Contains("definir_delay "))
                    {
                        string b = line.Replace("definir_delay ", "");
                        b = b.Replace(";", "");
                        tempoDelay = Convert.ToInt32(b + "000");
                    }
                    if (line.Contains("mover_mouse "))
                    {
                        string b = line.Replace(";", "");
                        b = b.Replace("mover_mouse ", "");
                        string[] ints = b.Split(' ');
                        mover_mouse(Convert.ToInt32(ints[0]), Convert.ToInt32(ints[1]));
                    }
                    if (line.Contains("mover_mouse_relativo "))
                    {
                        string b = line.Replace("mover_mouse_relativo ", "");
                        string[] ints = b.Split(' ');
                        mover_mouse_relativo(Convert.ToInt32(ints[0]), Convert.ToInt32(ints[1]));
                    }


                    if (line.Contains("mover_mouse_e_clicar_esquerdo "))
                    {
                        string b = line.Replace("mover_mouse_e_clicar_esquerdo ", "");
                        string[] ints = b.Split(' ');
                        mover_mouse_e_clicar_esquerdo(Convert.ToInt32(ints[0]), Convert.ToInt32(ints[1]));
                    }
                    if (line.Contains("mover_mouse_e_clicar_direito "))
                    {
                        string b = line.Replace("mover_mouse_e_clicar_direito ", "");
                        string[] ints = b.Split(' ');
                        mover_mouse_e_clicar_direito(Convert.ToInt32(ints[0]), Convert.ToInt32(ints[1]));
                    }
                    if (line.Contains("mover_mouse_e_duplo_click "))
                    {
                        string b = line.Replace("mover_mouse_e_duplo_click ", "");
                        string[] ints = b.Split(' ');
                        mover_mouse_e_duplo_click(Convert.ToInt32(ints[0]), Convert.ToInt32(ints[1]));
                    }



                    if (line.Contains("digitar_teclado "))
                    {
                        string b = line;
                        b = b.Replace("digitar_teclado ", "");
                        b = b.Replace(";", "");
                        b = b.Replace("\n", "");
                        digitar_teclado(b);
                    }


                    if (line.Contains("scroll_baixo "))
                    {
                        string b = line;
                        b = b.Replace("scroll_baixo ", "");
                        b = b.Replace(";", "");
                        b = b.Replace("\n", "");
                        scroll_baixo(Convert.ToInt32(b));
                    }
                    if (line.Contains("scroll_cima "))
                    {
                        string b = line;
                        b = b.Replace("scroll_cima ", "");
                        b = b.Replace(";", "");
                        b = b.Replace("\n", "");
                        scroll_cima(Convert.ToInt32(b));
                    }

                    if (line.Contains("trigger_clicks "))
                    {
                        string b = line;
                        b = b.Replace("trigger_clicks ", "");
                        b = b.Replace(";", "");
                        b = b.Replace("\n", "");
                        trigger_clicks(Convert.ToInt32(b));
                    }



                    if (line.Contains("soltar_click_mouse_direito;"))
                    {
                        soltar_click_mouse_direito();
                    }
                    if (line.Contains("soltar_click_mouse_esquerdo;"))
                    {
                        soltar_click_mouse_esquerdo();
                    }
                    if (line.Contains("click_mouse_direito_sem_soltar;"))
                    {
                        click_mouse_direito_sem_soltar();
                    }
                    if (line.Contains("click_mouse_esquerdo_sem_soltar;"))
                    {
                        click_mouse_esquerdo_sem_soltar();
                    }
                    if (line.Contains("click_mouse_direito_padrao;"))
                    {
                        click_mouse_direito_padrao();
                    }
                    if (line.Contains("click_mouse_esquerdo_padrao;"))
                    {
                        click_mouse_esquerdo_padrao();
                    }
                    if (line.Contains("ctrlC;"))
                    {
                        ctrlC();
                    }
                    if (line.Contains("ctrlV;"))
                    {
                        ctrlV();
                    }
                    if (line.Contains("duplo_click_mouse;"))
                    {
                        duplo_click_mouse();
                    }
                    if (line.Contains("AltTab;"))
                    {
                        AltTab();
                    }

                    if (line.Contains("Enter;"))
                    {
                        Enter();
                    }


                    if (line.Contains("SegurarCTRL;"))
                    {
                        SegurarCTRL();
                    }
                    if (line.Contains("SoltarCTRL;"))
                    {
                        SoltarCTRL();
                    }


                    if (line.Contains("SegurarALT;"))
                    {
                        SegurarALT();
                    }
                    if (line.Contains("SoltarALT;"))
                    {
                        SoltarALT();
                    }
                    if (line.Contains("SegurarSHIFT;"))
                    {
                        SegurarSHIFT();
                    }
                    if (line.Contains("SoltarSHIFT;"))
                    {
                        SoltarSHIFT();
                    }
                    if (line.Contains("soltar_todas_teclas;"))
                    {
                        soltar_todas_teclas();
                    }

                }

                foreach (string line in linhas)
                {
                    if (line.Contains("repetir "))
                    {
                        string b = line;
                        b = b.Replace("repetir ", "");
                        b = b.Replace(";", "");
                        b = b.Replace("\n", "");
                        if (repeats != Convert.ToInt32(b))
                        {
                            repeats++;
                            interpretarCodigo(arquivo);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }






        public static void wait(int ms)
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(ms);
        }


        public static bool _pararMouseZerado()
        {
            if (pararMouseZerado && Cursor.Position.X == 0 && Cursor.Position.Y == 0)
            {
                return true;
            }
            return false;
        }


        private static void mover_mouse_devagar(int dx, int dy)
        {

            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;

            bool chegou = false;
            int incremento = 8;


            while (!chegou)
            {
                if (x != dx)
                {
                    if (x > dx)
                    {
                        x -= incremento;
                    }
                    else
                    {
                        x += incremento;
                    }
                }
                if (y != dy)
                {
                    if (y > dy)
                    {
                        y -= incremento;
                    }
                    else
                    {
                        y += incremento;
                    }
                }
                Thread.Sleep(1);
                Cursor.Position = new Point(x, y);
                x = Cursor.Position.X;
                y = Cursor.Position.Y;


                if ((x + (incremento + 2)) >= dx && (x - (incremento + 2)) <= dx)
                {
                    if ((y + (incremento + 2)) >= dy && (y - (incremento + 2)) <= dy)
                    {
                        chegou = true;
                    }
                }

            }
            Cursor.Position = new Point(dx, dy);
        }

        public static void duplo_click_mouse()
        {
            if (_pararMouseZerado()) { return; }


            Thread.Sleep(tempoDelay);

            INPUT[] inputs = new INPUT[2];

            // Pressiona
            inputs[0].type = INPUT_MOUSE;
            inputs[0].mi.dwFlags = MOUSEEVENTF_LEFTDOWN;

            // Solta
            inputs[1].type = INPUT_MOUSE;
            inputs[1].mi.dwFlags = MOUSEEVENTF_LEFTUP;

            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

        }
        public static void mover_mouse(int x, int y)
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            mover_mouse_devagar(x, y);
        }

        public static void mover_mouse_e_clicar_esquerdo(int x, int y)
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            mover_mouse_devagar(x, y);
            Thread.Sleep(500);
            click_mouse_esquerdo_padrao();
        }
        public static void mover_mouse_e_duplo_click(int x, int y)
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            mover_mouse_devagar(x, y);
            Thread.Sleep(500);
            duplo_click_mouse();
        }
        public static void mover_mouse_e_clicar_direito(int x, int y)
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            mover_mouse_devagar(x, y);
            Thread.Sleep(500);
            click_mouse_direito_padrao();
        }
        public static void digitar_teclado(string texto)
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            SendKeys.SendWait(texto);
        }
        public static void click_mouse_esquerdo_padrao()
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);

            INPUT[] inputs = new INPUT[2];

            // Pressiona
            inputs[0].type = INPUT_MOUSE;
            inputs[0].mi.dwFlags = MOUSEEVENTF_LEFTDOWN;

            // Solta
            inputs[1].type = INPUT_MOUSE;
            inputs[1].mi.dwFlags = MOUSEEVENTF_LEFTUP;

            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

        }
        public static void click_mouse_direito_padrao()
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);

            INPUT[] inputs = new INPUT[2];

            // Pressiona
            inputs[0].type = INPUT_MOUSE;
            inputs[0].mi.dwFlags = MOUSEEVENTF_RIGHTDOWN;

            // Solta
            inputs[1].type = INPUT_MOUSE;
            inputs[1].mi.dwFlags = MOUSEEVENTF_RIGHTUP;

            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

        }
        public static void click_mouse_esquerdo_sem_soltar()
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);

            INPUT[] inputs = new INPUT[1];

            // Pressiona
            inputs[0].type = INPUT_MOUSE;
            inputs[0].mi.dwFlags = MOUSEEVENTF_LEFTDOWN;

            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

        }
        public static void click_mouse_direito_sem_soltar()
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);

            INPUT[] inputs = new INPUT[1];

            // Pressiona
            inputs[0].type = INPUT_MOUSE;
            inputs[0].mi.dwFlags = MOUSEEVENTF_RIGHTDOWN;

            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

        }
        public static void soltar_click_mouse_esquerdo()
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);

            INPUT[] inputs = new INPUT[1];

            // Solta
            inputs[0].type = INPUT_MOUSE;
            inputs[0].mi.dwFlags = MOUSEEVENTF_LEFTUP;

            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

        }
        public static void soltar_click_mouse_direito()
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);

            INPUT[] inputs = new INPUT[1];

            inputs[0].type = INPUT_MOUSE;
            inputs[0].mi.dwFlags = MOUSEEVENTF_RIGHTUP;

            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

        }
        public static void ctrlC()
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            //SendKeys.SendWait("^c");
            keybd_event((byte)teclas.VK_CONTROL, 0, KEYEVENTF_KEYDOWN, 0);

            // Pressionar C
            keybd_event((byte)teclas.VK_C, 0, KEYEVENTF_KEYDOWN, 0);

            // Soltar C
            keybd_event((byte)teclas.VK_C, 0, KEYEVENTF_KEYUP, 0);

            // Soltar Ctrl
            keybd_event((byte)teclas.VK_CONTROL, 0, KEYEVENTF_KEYUP, 0);



        }
        public static void ctrlV()
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            //SendKeys.SendWait("^c");
            keybd_event((byte)teclas.VK_CONTROL, 0, KEYEVENTF_KEYDOWN, 0);

            // Pressionar C
            keybd_event((byte)teclas.VK_V, 0, KEYEVENTF_KEYDOWN, 0);

            // Soltar C
            keybd_event((byte)teclas.VK_V, 0, KEYEVENTF_KEYUP, 0);

            // Soltar Ctrl
            keybd_event((byte)teclas.VK_CONTROL, 0, KEYEVENTF_KEYUP, 0);
        }
        public static void scroll_baixo(int linhas)
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            mouse_event(0x0800, 0, 0, -40 * linhas, 0);
        }
        public static void scroll_cima(int linhas)
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            mouse_event(0x0800, 0, 0, 40 * linhas, 0);
        }
        public static void mover_mouse_relativo(int x, int y)
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            mover_mouse_devagar(Cursor.Position.X + x, Cursor.Position.Y + y);
        }


        public static void alerta_msg(string m)
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            MessageBox.Show(m);
        }






        public static void AltTab()
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            //SendKeys.SendWait("^c");
            keybd_event((byte)teclas.VK_MENU, 0, KEYEVENTF_KEYDOWN, 0);

            // Pressionar C
            keybd_event((byte)teclas.VK_TAB, 0, KEYEVENTF_KEYDOWN, 0);

            // Soltar C
            keybd_event((byte)teclas.VK_TAB, 0, KEYEVENTF_KEYUP, 0);

            // Soltar Ctrl
            keybd_event((byte)teclas.VK_MENU, 0, KEYEVENTF_KEYUP, 0);

        }

        public static void Enter()
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            //SendKeys.SendWait("^c");
            keybd_event((byte)teclas.VK_RETURN, 0, KEYEVENTF_KEYDOWN, 0);

            keybd_event((byte)teclas.VK_RETURN, 0, KEYEVENTF_KEYUP, 0);

        }
        public static void SegurarCTRL()
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            //SendKeys.SendWait("^c");
            keybd_event((byte)teclas.VK_CONTROL, 0, KEYEVENTF_KEYDOWN, 0);
        }
        public static void SoltarCTRL()
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            //SendKeys.SendWait("^c");
            keybd_event((byte)teclas.VK_CONTROL, 0, KEYEVENTF_KEYUP, 0);
        }
        public static void SegurarALT()
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            //SendKeys.SendWait("^c");
            keybd_event((byte)teclas.VK_MENU, 0, KEYEVENTF_KEYDOWN, 0);
        }
        public static void SoltarALT()
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            //SendKeys.SendWait("^c");
            keybd_event((byte)teclas.VK_MENU, 0, KEYEVENTF_KEYUP, 0);
        }
        public static void SegurarSHIFT()
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            //SendKeys.SendWait("^c");
            keybd_event((byte)teclas.VK_SHIFT, 0, KEYEVENTF_KEYDOWN, 0);
        }
        public static void SoltarSHIFT()
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            //SendKeys.SendWait("^c");
            keybd_event((byte)teclas.VK_SHIFT, 0, KEYEVENTF_KEYUP, 0);
        }

        public static void soltar_todas_teclas()
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            int[] teclas =
            {
                1,2,3,4,5,6,8,9,12,13,16,17,18,19,20,27,32,33,34,
                35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,
                51,52,53,54,55,56,57,65,66,67,68,69,70,71,72,73,
                74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,
                90,96,97,98,99,100,101,102,103,104,105,112,113,
                114,115,116,117,118,119,120,121,122,123,124,125,
                126,127,128,129,130,131,132,133,134,135,144,145,
                160,161,162,163,164,165,173,174,175,176,177,178,
                179,180,181,182,183,186,187,188,189,190,191,192,
                219,220,221,222,229,
            };
            foreach (var item in teclas)
            {
                keybd_event((byte)item, 0, KEYEVENTF_KEYUP, 0);
            }
        }


        public static void trigger_clicks(int quantos_clicks)
        {
            if (_pararMouseZerado()) { return; }

            Thread.Sleep(tempoDelay);
            int _ = 0;
            while (_ < quantos_clicks)
            {
                //Thread.Sleep(1);
                click_mouse_esquerdo_padrao();
                _++;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        struct INPUT
        {
            public int type;
            public MOUSEINPUT mi;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct MOUSEINPUT
        {
            public int dx, dy, mouseData, dwFlags, time;
            public IntPtr dwExtraInfo;
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        private const int INPUT_MOUSE = 0;
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;







        //----------------------------
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);


        private const uint KEYEVENTF_KEYDOWN = 0x0000; // Pressionar
        private const uint KEYEVENTF_KEYUP = 0x0002;   // Soltar

        //------------------------
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, int dwData, uint dwExtraInfo);








    }



    public enum teclas
    {
        // Teclas de controle
        VK_LBUTTON = 0x01,  // Botão esquerdo do mouse
        VK_RBUTTON = 0x02,  // Botão direito do mouse
        VK_CANCEL = 0x03,   // Control-Break
        VK_MBUTTON = 0x04,  // Botão do meio do mouse
        VK_XBUTTON1 = 0x05, // Botão extra do mouse 1
        VK_XBUTTON2 = 0x06, // Botão extra do mouse 2

        VK_BACK = 0x08,     // Backspace
        VK_TAB = 0x09,      // Tabulação
        VK_CLEAR = 0x0C,    // Clear
        VK_RETURN = 0x0D,   // Enter

        VK_SHIFT = 0x10,    // Shift
        VK_CONTROL = 0x11,  // Ctrl
        VK_MENU = 0x12,     // Alt
        VK_PAUSE = 0x13,    // Pause
        VK_CAPITAL = 0x14,  // Caps Lock

        VK_ESCAPE = 0x1B,   // Esc
        VK_SPACE = 0x20,    // Espaço
        VK_PRIOR = 0x21,    // Page Up
        VK_NEXT = 0x22,     // Page Down
        VK_END = 0x23,      // End
        VK_HOME = 0x24,     // Home

        VK_LEFT = 0x25,     // Seta para esquerda
        VK_UP = 0x26,       // Seta para cima
        VK_RIGHT = 0x27,    // Seta para direita
        VK_DOWN = 0x28,     // Seta para baixo

        VK_SELECT = 0x29,   // Select
        VK_PRINT = 0x2A,    // Print
        VK_EXECUTE = 0x2B,  // Execute
        VK_SNAPSHOT = 0x2C, // Print Screen
        VK_INSERT = 0x2D,   // Insert
        VK_DELETE = 0x2E,   // Delete
        VK_HELP = 0x2F,     // Help

        // Teclas de números (Linha superior do teclado)
        VK_0 = 0x30, VK_1 = 0x31, VK_2 = 0x32, VK_3 = 0x33, VK_4 = 0x34,
        VK_5 = 0x35, VK_6 = 0x36, VK_7 = 0x37, VK_8 = 0x38, VK_9 = 0x39,

        // Teclas de letras
        VK_A = 0x41, VK_B = 0x42, VK_C = 0x43, VK_D = 0x44, VK_E = 0x45,
        VK_F = 0x46, VK_G = 0x47, VK_H = 0x48, VK_I = 0x49, VK_J = 0x4A,
        VK_K = 0x4B, VK_L = 0x4C, VK_M = 0x4D, VK_N = 0x4E, VK_O = 0x4F,
        VK_P = 0x50, VK_Q = 0x51, VK_R = 0x52, VK_S = 0x53, VK_T = 0x54,
        VK_U = 0x55, VK_V = 0x56, VK_W = 0x57, VK_X = 0x58, VK_Y = 0x59,
        VK_Z = 0x5A,

        // Teclas do teclado numérico
        VK_NUMPAD0 = 0x60, VK_NUMPAD1 = 0x61, VK_NUMPAD2 = 0x62, VK_NUMPAD3 = 0x63,
        VK_NUMPAD4 = 0x64, VK_NUMPAD5 = 0x65, VK_NUMPAD6 = 0x66, VK_NUMPAD7 = 0x67,
        VK_NUMPAD8 = 0x68, VK_NUMPAD9 = 0x69,

        // Teclas de função
        VK_F1 = 0x70, VK_F2 = 0x71, VK_F3 = 0x72, VK_F4 = 0x73, VK_F5 = 0x74,
        VK_F6 = 0x75, VK_F7 = 0x76, VK_F8 = 0x77, VK_F9 = 0x78, VK_F10 = 0x79,
        VK_F11 = 0x7A, VK_F12 = 0x7B, VK_F13 = 0x7C, VK_F14 = 0x7D, VK_F15 = 0x7E,
        VK_F16 = 0x7F, VK_F17 = 0x80, VK_F18 = 0x81, VK_F19 = 0x82, VK_F20 = 0x83,
        VK_F21 = 0x84, VK_F22 = 0x85, VK_F23 = 0x86, VK_F24 = 0x87,

        // Teclas especiais
        VK_NUMLOCK = 0x90,  // Num Lock
        VK_SCROLL = 0x91,   // Scroll Lock

        VK_LSHIFT = 0xA0,   // Shift esquerdo
        VK_RSHIFT = 0xA1,   // Shift direito
        VK_LCONTROL = 0xA2, // Ctrl esquerdo
        VK_RCONTROL = 0xA3, // Ctrl direito
        VK_LMENU = 0xA4,    // Alt esquerdo
        VK_RMENU = 0xA5,    // Alt direito

        VK_VOLUME_MUTE = 0xAD,   // Silenciar volume
        VK_VOLUME_DOWN = 0xAE,   // Diminuir volume
        VK_VOLUME_UP = 0xAF,     // Aumentar volume

        VK_MEDIA_NEXT_TRACK = 0xB0, // Próxima faixa
        VK_MEDIA_PREV_TRACK = 0xB1, // Faixa anterior
        VK_MEDIA_STOP = 0xB2,       // Parar mídia
        VK_MEDIA_PLAY_PAUSE = 0xB3, // Reproduzir/Pausar mídia

        VK_LAUNCH_MAIL = 0xB4,   // Abrir e-mail
        VK_LAUNCH_MEDIA_SELECT = 0xB5, // Abrir player de mídia
        VK_LAUNCH_APP1 = 0xB6,   // Abrir App 1
        VK_LAUNCH_APP2 = 0xB7,   // Abrir App 2

        VK_OEM_1 = 0xBA,  // Ponto e vírgula (;) ou cedilha (ç) dependendo do layout
        VK_OEM_PLUS = 0xBB, // Sinal de mais (+)
        VK_OEM_COMMA = 0xBC, // Vírgula (,)
        VK_OEM_MINUS = 0xBD, // Sinal de menos (-)
        VK_OEM_PERIOD = 0xBE, // Ponto (.)
        VK_OEM_2 = 0xBF,  // Barra invertida (/ ou ?)
        VK_OEM_3 = 0xC0,  // Acento grave (`) ou til (~)

        VK_OEM_4 = 0xDB,  // Abre colchetes ([)
        VK_OEM_5 = 0xDC,  // Barra invertida (\)
        VK_OEM_6 = 0xDD,  // Fecha colchetes (])
        VK_OEM_7 = 0xDE,  // Aspas simples (') ou aspas duplas (")

        VK_PROCESSKEY = 0xE5,  // Chave de processamento IME
    }

}
