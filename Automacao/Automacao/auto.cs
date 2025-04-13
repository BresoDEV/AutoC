using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Automacao
{
    class faker
    {
        private static string[] primeirosNomes = {  "Ana", "Bruno", "Carla", "Daniel", "Eduarda", "Fernando", "Gabriela", "Henrique", "Isabela", "João",
            "Karen", "Lucas", "Mariana", "Nathan", "Olivia", "Paulo", "Quésia", "Ricardo", "Sofia", "Thiago",
            "Ursula", "Vinícius", "Wesley", "Ximena", "Yago", "Zuleica", "Amanda", "Benício", "Camila", "Diego",
            "Elaine", "Fábio", "Giovana", "Heitor", "Ivana", "Jorge", "Kelly", "Leonardo", "Melissa", "Nelson",
            "Olga", "Pedro", "Quezia", "Rodrigo", "Simone", "Tiago", "Ubiratan", "Vanessa", "William", "Xavier",
            "Yasmin", "Zeca", "Alice", "Bernardo", "Cecília", "Davi", "Elisa", "Felipe", "Gustavo", "Heloísa",
            "Igor", "Juliana", "Kevin", "Larissa", "Matheus", "Natália", "Otávio", "Priscila", "Quintino", "Rafaela",
            "Samuel", "Tamara", "Ulisses", "Vitória", "Wallace", "Xander", "Yuri", "Zélia", "Antonella", "Brayan",
            "Clara", "Douglas", "Esther", "Frederico", "Giovanni", "Helena", "Iago", "Joana", "Kaio", "Lívia",
            "Maurício", "Nicole", "Orlando", "Patrícia", "Raul", "Sabrina", "Teodoro", "Ugo", "Verônica", "Wellington","Adriano", "Alberto", "Alexandre", "Anderson", "André", "Antônio", "Arthur", "Augusto", "Benjamin", "Bernardo",
            "Bruno", "Caio", "Carlos", "César", "Cristiano", "Daniel", "Davi", "Diego", "Douglas", "Edson",
            "Eduardo", "Elias", "Emanuel", "Emerson", "Enzo", "Erick", "Ernesto", "Estevão", "Everaldo", "Fábio",
            "Fabrício", "Felipe", "Fernando", "Flávio", "Francisco", "Gabriel", "George", "Gilberto", "Giovanni", "Gustavo",
            "Henrique", "Heitor", "Hélio", "Hugo", "Ian", "Igor", "Isaac", "Ismael", "Ivan", "João",
            "Joaquim", "Jonas", "Jorge", "José", "Juliano", "Júlio", "Kevin", "Klaus", "Leandro", "Leonardo",
            "Lucas", "Luís", "Marcelo", "Márcio", "Marcos", "Mateus", "Matheus", "Maurício", "Miguel", "Murilo",
            "Nathan", "Nelson", "Nicolas", "Otávio", "Paulo", "Pedro", "Rafael", "Raul", "Renan", "Renato",
            "Ricardo", "Roberto", "Rodrigo", "Samuel", "Sandro", "Sérgio", "Sidney", "Silvio", "Thiago", "Tobias",
            "Tomás", "Valter", "Vanderlei", "Vicente", "Vinícius", "Vitor", "Wagner", "Wallace", "Walter", "William",  "Adriana", "Aline", "Alícia", "Amanda", "Ana", "Andressa", "Angela", "Antônia", "Aparecida", "Beatriz",
            "Bianca", "Bruna", "Camila", "Carla", "Carolina", "Catarina", "Cecília", "Clara", "Cláudia", "Cristiane",
            "Daniela", "Daphne", "Débora", "Denise", "Diana", "Eduarda", "Elaine", "Eliana", "Eloá", "Emilly",
            "Estela", "Evelyn", "Fabiana", "Fernanda", "Flávia", "Francisca", "Gabriela", "Geovana", "Giovanna", "Gláucia",
            "Graziela", "Helena", "Isabel", "Isabela", "Ivone", "Janaína", "Jéssica", "Joana", "Júlia", "Juliana",
            "Karen", "Karina", "Larissa", "Laura", "Letícia", "Lívia", "Lorena", "Luana", "Luciana", "Lúcia",
            "Luiza", "Maitê", "Manuela", "Marcela", "Mariana", "Marisa", "Melissa", "Milena", "Mirella", "Mônica",
            "Nádia", "Natália", "Nicole", "Olívia", "Patrícia", "Paula", "Priscila", "Rafaela", "Rebeca", "Regina",
            "Renata", "Rita", "Roberta", "Rosa", "Sabrina", "Samara", "Sandra", "Sara", "Sheila", "Simone",
            "Sofia", "Stella", "Sueli", "Tatiane", "Taís", "Teresa", "Thais", "Valéria", "Vanessa", "Vitória","Sophia", "Alice", "Julia", "Isabella", "Manuela", "Laura", "Luiza", "Valentina", "Giovanna", "Maria",
            "Helena", "Beatriz", "Maria Eduarda", "Lara", "Mariana", "Nicole", "Rafaela", "Heloísa", "Isadora", "Lívia",
            "Gabriela", "Yasmin", "Isabelly", "Sarah", "Lorena", "Melissa", "Letícia", "Ana Clara", "Ana Luiza", "Clara",
            "Cecília", "Esther", "Emanuelly", "Rebeca", "Ana Júlia", "Lavínia", "Agatha", "Bianca", "Marina", "Maitê",
            "Vitória", "Olívia", "Catarina", "Larissa", "Maria Clara", "Ana Beatriz", "Eduarda", "Ana", "Stella", "Gabrielly",
            "Milena", "Carolina", "Maria Fernanda", "Amanda", "Aurora", "Maria Julia", "Pietra", "Clarice", "Ana Laura", "Antonella",
            "Isis", "Ayla", "Eloá", "Ana Lívia", "Mirella", "Ana Sophia", "Fernanda", "Alícia", "Nina", "Maya",
            "Bárbara", "Luna", "Allana", "Bruna", "Ester", "Malu", "Júlia", "Maria Alice", "Maria Cecília", "Maria Vitória",
            "Mariane", "Marcela", "Cléo", "Diana", "Elisa", "Fabiana", "Geovanna", "Joana", "Laís", "Lilian",
            "Márcia", "Natália", "Raquel", "Sandra", "Tatiane", "Vanessa", "Verônica", "Wanessa", "Zélia", "Adriana",
    
            // Nomes masculinos (101)
            "Miguel", "Arthur", "Davi", "Gabriel", "Bernardo", "Lucas", "Matheus", "Rafael", "Heitor", "Enzo",
            "Guilherme", "Nicolas", "Lorenzo", "Pedro", "Gustavo", "Felipe", "Samuel", "João Pedro", "Daniel", "Vitor",
            "Leonardo", "Henrique", "Theo", "Murilo", "Eduardo", "Pedro Henrique", "Pietro", "Caio", "Isaac", "Lucca",
            "Francisco", "João", "Antônio", "Benício", "Davi Lucca", "Anthony", "Thomas", "Henry", "Enzo Gabriel", "Noah",
            "João Miguel", "Bryan", "Joaquim", "Vicente", "Cauã", "Levi", "Emanuel", "Ryan", "Ian", "Davi Lucas",
            "Nathan", "Luiz Miguel", "Carlos Eduardo", "Raul", "Otávio", "Kaique", "Augusto", "Bruno", "Fernando", "Thiago",
            "André", "Danilo", "Ruan", "Marcelo", "Alexandre", "Fábio", "Roberto", "Sérgio", "César", "Marcos",
            "Rodrigo", "Diego", "Erick", "Vinícius", "Igor", "José", "Renato", "Márcio", "Paulo", "Ricardo",
            "Adriano", "Cristiano", "Douglas", "Evandro", "Gilberto", "Hélio", "Jorge", "Kleber", "Luciano", "Maurício",
            "Orlando", "Patrício", "Quirino", "Rogério", "Silas", "Ubirajara", "Wagner", "Xavier", "Yago", "Zacarias",
            "Amarildo", "Baltazar" };

        private static string[] sobrenomes = { "Abreu", "Aguiar", "Albuquerque", "Almeida", "Alves", "Amaral", "Amorim", "Andrade", "Antunes", "Araujo",
            "Arruda", "Assis", "Azevedo", "Barbosa", "Barros", "Batista", "Borges", "Brandão", "Brito", "Bueno",
            "Cabral", "Campos", "Cardoso", "Carneiro", "Carvalho", "Castro", "Chaves", "Coelho", "Conceição", "Cordeiro",
            "Correia", "Coutinho", "Cruz", "Dantas", "Dias", "Diniz", "Domingues", "Duarte", "Esteves", "Evangelista",
            "Farias", "Ferraz", "Ferreira", "Figueiredo", "Figueiró", "Fonseca", "Freitas", "Frota", "Furtado", "Garcia",
            "Gomes", "Gonçalves", "Gouveia", "Guedes", "Guimarães", "Henrique", "Hernandes", "Lacerda", "Lemos", "Leão",
            "Lima", "Lins", "Lopes", "Loureiro", "Machado", "Maciel", "Macedo", "Magalhães", "Maia", "Maldonado",
            "Marques", "Martins", "Medeiros", "Melo", "Mendes", "Menezes", "Miranda", "Monteiro", "Moraes", "Morais",
            "Moreira", "Muniz", "Nascimento", "Neves", "Nogueira", "Novaes", "Novais", "Nunes", "Oliveira", "Pacheco",
            "Padilha", "Paiva", "Pereira", "Pimentel", "Pinto", "Portela", "Porto", "Prado", "Quaresma", "Queiroz",
            "Ramos", "Rezende", "Ribeiro", "Rocha", "Rodrigues", "Sampaio", "Santana", "Santos", "Silva", "Souza", "Silva", "Santos", "Oliveira", "Souza", "Rodrigues", "Ferreira", "Alves", "Pereira", "Lima", "Gomes",
            "Costa", "Ribeiro", "Martins", "Carvalho", "Araújo", "Almeida", "Pinto", "Monteiro", "Mendes", "Barros",
            "Freitas", "Barbosa", "Vieira", "Rocha", "Nascimento", "Moreira", "Cardoso", "Fernandes", "Correia", "Melo",
            "Cavalcanti", "Dias", "Cunha", "Teixeira", "Nunes", "Marques", "Machado", "Bezerra", "Andrade", "Fonseca",
            "Guimarães", "Magalhães", "Azevedo", "Borges", "Tavares", "Siqueira", "Queiroz", "Reis", "Campos", "Brito",
            "Vasconcelos", "Morais", "Dantas", "Peixoto", "Leal", "Farias", "Maia", "Xavier", "Aguiar", "Figueiredo",
            "Lopes", "Guedes", "Mota", "Sales", };

        private static string[] sobrenomesSecundarios = { "Neto", "Medeiros", "Galvão", "Amaral", "Pimentel", "Castro",
            "Miranda", "Rios", "Veloso", "Soares", "Diniz", "Franco", "Bueno", "Valente", "Garcia", "Otero",
            "Paiva", "Cabral", "Cordeiro", "Bastos", "Sampaio", "Santana", "Faria", "Viana", "Assis", "Matos",
            "Bispo", "Caetano", "Donato", "Esteves", "Fontes", "Goulart", "Hernandes", "Inácio", "Junqueira", "Klein",

            // Sobrenomes de origem italiana (comuns no Sul/Sudeste)
            "Rossi", "Bianchi", "Ferrari", "Romano", "Colombo", "Ricci", "Marino", "Greco", "Bruno", "Rizzo",
            "Conti", "De Luca", "Mancini", "Costa", "Giordano", "Rosa", "Lombardi", "Moretti", "Galli", "Martini",
            "Leone", "D'Angelo", "Longo", "Gentile", "Martinelli", "Serra", "Coelho", "Vitali", "Pereira", "Rinaldi"};

        private static string RemoverAcentos(string texto)
        {
            var normalized = texto.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (var c in normalized)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }
            return sb.ToString().Normalize(NormalizationForm.FormC);
        }
        private static List<string> GerarSugestoesEmail(string nomeCompleto)
        {
            // Normaliza o nome (remove acentos, caracteres especiais e converte para minúsculas)
            string nomeNormalizado = RemoverAcentos(nomeCompleto).ToLower().Trim();

            // Remove caracteres inválidos e divide em partes
            string[] partes = Regex.Replace(nomeNormalizado, @"[^a-z0-9_\s-]", "")
                                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (partes.Length < 2)
                return new List<string>();

            string primeiroNome = partes[0];
            string sobrenome = partes[^1]; // Último elemento
            var meio = partes.Skip(1).Take(partes.Length - 2).ToArray();

            List<string> sugestoes = new List<string>();

            // Combinações básicas
            sugestoes.Add($"{primeiroNome}.{sobrenome}");
            sugestoes.Add($"{sobrenome}.{primeiroNome}");
            sugestoes.Add($"{primeiroNome}_{sobrenome}");
            sugestoes.Add($"{sobrenome}_{primeiroNome}");
            sugestoes.Add($"{primeiroNome}{sobrenome}");
            sugestoes.Add($"{sobrenome}{primeiroNome}");

            // Combinações com iniciais do meio
            if (meio.Length > 0)
            {
                string iniciais = string.Concat(meio.Select(m => m[0]));
                sugestoes.Add($"{primeiroNome}.{iniciais}.{sobrenome}");
                sugestoes.Add($"{iniciais}.{primeiroNome}.{sobrenome}");
                sugestoes.Add($"{primeiroNome}{iniciais}{sobrenome}");
            }

            // Combinações com números
            for (int i = 1; i <= 3; i++)
            {
                sugestoes.Add($"{primeiroNome}.{sobrenome}{i}");
                sugestoes.Add($"{sobrenome}.{primeiroNome}{i}");
                sugestoes.Add($"{primeiroNome}{i}{sobrenome}");
                sugestoes.Add($"{sobrenome}{i}{primeiroNome}");
                sugestoes.Add($"{primeiroNome}{sobrenome}.{i}");
            }

            // Domínios populares
            string[] dominios = { "gmail.com", "outlook.com", "yahoo.com", "hotmail.com" };

            // Gera todas as combinações e remove duplicatas
            return sugestoes.SelectMany(s => dominios.Select(d => $"{s}@{d}"))
                            .Distinct()
                            .ToList();
        }

       
        private static string[] Pessoa = [
            "B",//Nome               0
            "",//Sobrenome          1
            "",//Email              2
            "",//cpf                3
            "",//cpf pontuado       4
            "",//rg                 5
            "",//idade              6
            ];

        
        public static void obter_idade_pessoa()
        {
            if (auto._pararMouseZerado()) { return; }
            auto.wait(auto.tempoDelay);
            //-----------------------
            Clipboard.SetText(Pessoa[6]);
        } 
        public static void obter_rg_pessoa()
        {
            if (auto._pararMouseZerado()) { return; }
            auto.wait(auto.tempoDelay);
            //-----------------------
            Clipboard.SetText(Pessoa[5]);
        } 
        public static void obter_cpf_pontuado_pessoa()
        {
            if (auto._pararMouseZerado()) { return; }
            auto.wait(auto.tempoDelay);
            //-----------------------
            Clipboard.SetText(Pessoa[4]);
        } 
        public static void obter_Email_pessoa()
        {
            if (auto._pararMouseZerado()) { return; }
            auto.wait(auto.tempoDelay);
            //-----------------------
            Clipboard.SetText(Pessoa[2]);
        } 
        public static void obter_nome_completo_pessoa()
        {
            if (auto._pararMouseZerado()) { return; }
            auto.wait(auto.tempoDelay);
            //-----------------------
            Clipboard.SetText(Pessoa[0]+" "+Pessoa[1]);
        } 
        
        public static void obter_sobrenome_pessoa()
        {
            if (auto._pararMouseZerado()) { return; }
            auto.wait(auto.tempoDelay);
            //-----------------------
            Clipboard.SetText(Pessoa[1]);
        }
        public static void obter_nome_pessoa()
        {
            if (auto._pararMouseZerado()) { return; }
            auto.wait(auto.tempoDelay);
            //-----------------------
            Clipboard.SetText(Pessoa[0]);
        }
        public static void criar_pessoa()
        {
            if (auto._pararMouseZerado()) { return; }
            auto.wait(auto.tempoDelay);
            //-----------------------
            Random rand = new Random();
            string nome = primeirosNomes[rand.Next(primeirosNomes.Length)];
            string sobrenome1 = sobrenomes[rand.Next(sobrenomes.Length)];
            string sobrenome2 = sobrenomesSecundarios[rand.Next(sobrenomesSecundarios.Length)];

            // Condição para decidir se o segundo sobrenome será incluído ou não
            bool incluirSegundoSobrenome = rand.Next(2) == 0; // 50% de chance

            // Montar os resultados
           
            List<string> gg = new List<string>();

            if (incluirSegundoSobrenome)
            {
                gg = GerarSugestoesEmail(nome + " " + sobrenome1 + " " + sobrenome2);
            }
            else
            {
                gg = GerarSugestoesEmail(nome + " " + sobrenome1);
            }

            Pessoa[0] = nome;
            Pessoa[1] = incluirSegundoSobrenome ? sobrenome1 + " " + sobrenome2 : sobrenome1;
            
            //Gera email
            Pessoa[2] = gg[rand.Next(0, gg.Count)];


            //gera cpf
            string cpf = "";
            for (int i = 0; i < 11; i++)
            {
                cpf += rand.Next(0, 9);

            }
            Pessoa[3] = cpf;

            //gera cpf pontuado
            cpf = "";
            for (int i = 0; i < 14; i++)
            {
                switch (i)
                {
                    case 3: cpf += "."; break;
                    case 7: cpf += "."; break;
                    case 11: cpf += "-"; break;
                    default: cpf += rand.Next(0, 9); break;
                }

            }
            Pessoa[4] = cpf;


            //gerar rg
            string rg = "";
            for (int i = 0; i < 12; i++)
            {
                rg += rand.Next(0, 9);

            }
            Pessoa[5] = rg;

            //gerar idade 
            Pessoa[6] = rand.Next(18, 69).ToString();

        }
         
        public static string obter_pessoa_completa()
        {
            string rg = "";
            foreach (var item in Pessoa)
            {
                rg += "("+ item+"),";
            }
            //Clipboard.SetText(rg);
            return rg;
        }


        

         
    }
    internal class lexica
    {
        public static bool linhas_terminam_com_ponto_e_virgula(RichTextBox textBox)
        {
            string[] linhas = textBox.Lines;
            for (int i = 0; i < linhas.Length; i++)
            {
                string l = linhas[i].TrimEnd();
                if (!string.IsNullOrWhiteSpace(l) && !l.EndsWith(";"))
                {
                    MessageBox.Show($"Erro: Linha {i}\nComandos devem terminar com ';'");
                    return false;
                }

            }

            return true;
        }
        public static bool linhas_nativos_corretos(RichTextBox textBox)
        {
            string[] linhas = textBox.Lines;
            string[] nativos = [
                        "##",
                        "repetir", 
                        "pararMouseZerado;",//richTextBox1.Text += "pararMouseZerado;"; break;
                        "alerta_msg",//richTextBox1.Text += "alerta_msg Hello World;"; break;
                        "digitar_teclado",//richTextBox1.Text += "digitar_teclado Hello World;"; break;
                        "add_arquivo_area_de_transferencia",//richTextBox1.Text += "add_arquivo_area_de_transferencia c:/Foto.png;"; break;
                        "definir_delay",//richTextBox1.Text += "definir_delay 1000;"; break;
                        "mover_mouse",//richTextBox1.Text += "mover_mouse X Y;"; break;
                        "mover_mouse_relativo",//richTextBox1.Text += "mover_mouse_relativo X Y;"; break;
                        "mover_mouse_e_clicar_esquerdo",//richTextBox1.Text += "mover_mouse_e_clicar_esquerdo X Y;"; break;
                        "mover_mouse_e_clicar_direito",//richTextBox1.Text += "mover_mouse_e_clicar_direito X Y;"; break;
                        "mover_mouse_e_duplo_click",//richTextBox1.Text += "mover_mouse_e_duplo_click X Y;"; break;
                        "scroll_baixo",//richTextBox1.Text += "scroll_baixo 10;"; break;
                        "scroll_cima",//richTextBox1.Text += "scroll_cima 10;"; break;
                        "trigger_clicks",//richTextBox1.Text += "trigger_clicks 10;"; break;
                        "soltar_click_mouse_direito;",//richTextBox1.Text += "soltar_click_mouse_direito;"; break;
                        "soltar_click_mouse_esquerdo;",//richTextBox1.Text += "soltar_click_mouse_esquerdo;"; break;
                        "click_mouse_direito_sem_soltar;",//richTextBox1.Text += "click_mouse_direito_sem_soltar;"; break;
                        "click_mouse_esquerdo_sem_soltar;",//richTextBox1.Text += "click_mouse_esquerdo_sem_soltar;"; break;
                        "click_mouse_direito_padrao;",//richTextBox1.Text += "click_mouse_direito_padrao;"; break;
                        "click_mouse_esquerdo_padrao;",//richTextBox1.Text += "click_mouse_esquerdo_padrao;"; break;
                        "ctrlC;",//richTextBox1.Text += "ctrlC;"; break;
                        "ctrlV;",//richTextBox1.Text += "ctrlV;"; break;
                        "duplo_click_mouse;",//richTextBox1.Text += "duplo_click_mouse;"; break;
                        "AltTab;",//richTextBox1.Text += "AltTab;"; break;
                        "Enter;",//richTextBox1.Text += "Enter;"; break;
                        "SegurarCTRL;",//richTextBox1.Text += "SegurarCTRL;"; break;
                        "SoltarCTRL;",//richTextBox1.Text += "SoltarCTRL;"; break;
                        "SegurarALT",//richTextBox1.Text += "SegurarALT;"; break;
                        "SoltarALT;",//richTextBox1.Text += "SoltarALT;"; break;
                        "SegurarSHIFT;",//richTextBox1.Text += "SegurarSHIFT;"; break;
                        "SoltarSHIFT;",//richTextBox1.Text += "SoltarSHIFT;"; break;
                        "soltar_todas_teclas;",//richTextBox1.Text += "soltar_todas_teclas;"; break;
                        "obter_idade_pessoa;",//richTextBox1.Text += "obter_idade_pessoa;"; break;
                        "obter_rg_pessoa;",//richTextBox1.Text += "obter_rg_pessoa;"; break;
                        "obter_cpf_pontuado_pessoa;",//richTextBox1.Text += "obter_cpf_pontuado_pessoa;"; break;
                        "obter_Email_pessoa;",//richTextBox1.Text += "obter_Email_pessoa;"; break;
                        "obter_nome_completo_pessoa;",//richTextBox1.Text += "obter_nome_completo_pessoa;"; break;
                        "obter_sobrenome_pessoa;",//richTextBox1.Text += "obter_sobrenome_pessoa;"; break;
                        "obter_nome_pessoa;",//richTextBox1.Text += "obter_nome_pessoa;"; break;
                        "criar_pessoa;",//richTextBox1.Text += "criar_pessoa;"; break;
                        "obter_pessoa_completa;",//richTextBox1.Text += "obter_pessoa_completa;"; break;
                        "alerta_msg_transferencia;",//richTextBox1.Text += "alerta_msg_transferencia;"; break;
                        "digitar_teclado_area_de_transferencia;",//richTextBox1.Text += "digitar_teclado_area_de_transferencia;"; break;
                ];

            int numLinhas = linhas.Length;
            int ct = 0;

            for (int i = 0; i < linhas.Length; i++)
            {
                foreach (var item in nativos)
                {
                    if (linhas[i].Contains(item))
                    {
                        ct++;
                    } 
                }
                if (ct == i)
                {
                    MessageBox.Show($"Erro: Linha {i+1}\nComando invalido ou a linha está vazia");
                    return false;
                }
            }
            return true;
        }
    }


    internal class auto_log
    {
        public static void gravar_log(string texto)
        {
            DateTime h = DateTime.Now; 
            File.AppendAllText(h.ToString("dd-MM-y") + ".txt", "\n[" + h.ToString() + "] = "+ texto);
        }
    }


    internal class auto
    {
        public static string extensaoScript = ".breso";
        public static int tempoDelay = 1000;
        private static int repeats = 0;
        private static bool pararMouseZerado = true;




        public static string enc(string b)
        {
            string kh = b;
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    kh = Convert.ToBase64String(Encoding.UTF8.GetBytes(kh));
                }
            }
            catch { }
            return kh;

        }
        public static string dec(string b)
        {
            string kh = b;
            try
            {

                for (int i = 0; i < 10; i++)
                {
                    kh = Encoding.UTF8.GetString(Convert.FromBase64String(kh));
                }

            }
            catch { }
            return kh;

        }

        public static void interpretarArquivo(string arquivo)
        {
            if (File.Exists(arquivo))
            {
                interpretarCodigoCriptografado(File.ReadAllText(arquivo));
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado");
            }
        }

        public static void interpretarCodigoCriptografado(string codigo)
        {
            interpretarCodigo(dec(codigo));
        }
        public static void interpretarCodigo(string codigo)
        {
            try
            {
                string[] linhas = codigo.Split(';');
                foreach (string linee in linhas)
                {
                    string line = linee.Replace("\n", "");

                    if (line.Contains("##"))
                    {
                        continue;
                    }
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
                    if (line.Contains("add_arquivo_area_de_transferencia "))
                    {
                        string b = line.Replace("add_arquivo_area_de_transferencia ", "");
                        b = b.Replace(";", "");
                        add_arquivo_area_de_transferencia(b);
                    }
                    if (line.Contains("definir_delay "))
                    {
                        string b = line.Replace("definir_delay ", "");
                        b = b.Replace(";", "");
                        definir_delay(Convert.ToInt32(b));
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
                    if (line.Contains("digitar_teclado_area_de_transferencia;"))
                    {
                        digitar_teclado_area_de_transferencia();
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
                    if (line.Contains("soltar_click_mouse_direito"))
                    {
                        soltar_click_mouse_direito();
                    }
                    if (line.Contains("soltar_click_mouse_esquerdo"))
                    {
                        soltar_click_mouse_esquerdo();
                    }
                    if (line.Contains("click_mouse_direito_sem_soltar"))
                    {
                        click_mouse_direito_sem_soltar();
                    }
                    if (line.Contains("click_mouse_esquerdo_sem_soltar"))
                    {
                        click_mouse_esquerdo_sem_soltar();
                    }
                    if (line.Contains("click_mouse_direito_padrao"))
                    {
                        click_mouse_direito_padrao();
                    }
                    if (line.Contains("click_mouse_esquerdo_padrao"))
                    {
                        click_mouse_esquerdo_padrao();
                    }
                    if (line.Contains("ctrlC"))
                    {
                        ctrlC();
                    }
                    if (line.Contains("ctrlV"))
                    {
                        ctrlV();
                    }
                    if (line.Contains("duplo_click_mouse"))
                    {
                        duplo_click_mouse();
                    }
                    if (line.Contains("AltTab"))
                    {
                        AltTab();
                    }
                    if (line.Contains("Enter"))
                    {
                        Enter();
                    }
                    if (line.Contains("SegurarCTRL"))
                    {
                        SegurarCTRL();
                    }
                    if (line.Contains("SoltarCTRL"))
                    {
                        SoltarCTRL();
                    }
                    if (line.Contains("SegurarALT"))
                    {
                        SegurarALT();
                    }
                    if (line.Contains("SoltarALT"))
                    {
                        SoltarALT();
                    }
                    if (line.Contains("SegurarSHIFT"))
                    {
                        SegurarSHIFT();
                    }
                    if (line.Contains("SoltarSHIFT"))
                    {
                        SoltarSHIFT();
                    }
                    if (line.Contains("soltar_todas_teclas"))
                    {
                        soltar_todas_teclas();
                    }

                    //Funcoes da classe FAKER
                    if (line.Contains("obter_idade_pessoa"))
                    {
                        faker.obter_idade_pessoa();
                    }
                    if (line.Contains("obter_rg_pessoa"))
                    {
                        faker.obter_rg_pessoa();
                    }
                    if (line.Contains("obter_cpf_pontuado_pessoa"))
                    {
                        faker.obter_cpf_pontuado_pessoa();
                    }
                    if (line.Contains("obter_Email_pessoa"))
                    {
                        faker.obter_Email_pessoa();
                    }
                    if (line.Contains("obter_nome_completo_pessoa"))
                    {
                        faker.obter_nome_completo_pessoa();
                    }
                    if (line.Contains("obter_sobrenome_pessoa"))
                    {
                        faker.obter_sobrenome_pessoa();
                    }
                    if (line.Contains("obter_nome_pessoa"))
                    {
                        faker.obter_nome_pessoa();
                    }
                    if (line.Contains("criar_pessoa"))
                    {
                        faker.criar_pessoa();
                    }
                    if (line.Contains("obter_pessoa_completa"))
                    {
                        faker.obter_pessoa_completa();
                    } 
                    if (line.Contains("obter_pessoa_completa"))
                    {
                        faker.obter_pessoa_completa();
                    } 
                    if (line.Contains("alerta_msg_transferencia"))
                    {
                        alerta_msg_transferencia();
                    } 
                    //if (line.Contains(";"))
                    //{
                    //    faker.();
                    //}
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
                            interpretarCodigo(codigo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void definir_delay(int ms)
        {
            if (_pararMouseZerado()) { return; }
            tempoDelay = ms;
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
                auto.wait(1);
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
            auto.wait(tempoDelay);
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
            auto.wait(tempoDelay);
            mover_mouse_devagar(x, y);
        }
        public static void mover_mouse_e_clicar_esquerdo(int x, int y)
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            mover_mouse_devagar(x, y);
            auto.wait(500);
            click_mouse_esquerdo_padrao();
        }
        public static void mover_mouse_e_duplo_click(int x, int y)
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            mover_mouse_devagar(x, y);
            auto.wait(500);
            duplo_click_mouse();
        }
        public static void mover_mouse_e_clicar_direito(int x, int y)
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            mover_mouse_devagar(x, y);
            auto.wait(500);
            click_mouse_direito_padrao();
        }
        public static void digitar_teclado(string texto)
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            SendKeys.SendWait(texto);
        }
        public static void digitar_teclado_area_de_transferencia()
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            SendKeys.SendWait(Clipboard.GetText());
        }
        public static void click_mouse_esquerdo_padrao()
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            INPUT[] inputs = new INPUT[2];
            // Pressiona
            inputs[0].type = INPUT_MOUSE;
            inputs[0].mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            // Solta
            inputs[1].type = INPUT_MOUSE;
            inputs[1].mi.dwFlags = MOUSEEVENTF_LEFTUP;
            //----------------
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
        }
        public static void click_mouse_direito_padrao()
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            INPUT[] inputs = new INPUT[2];
            // Pressiona
            inputs[0].type = INPUT_MOUSE;
            inputs[0].mi.dwFlags = MOUSEEVENTF_RIGHTDOWN;
            // Solta
            inputs[1].type = INPUT_MOUSE;
            inputs[1].mi.dwFlags = MOUSEEVENTF_RIGHTUP;
            //----------------
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
        }
        public static void click_mouse_esquerdo_sem_soltar()
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            INPUT[] inputs = new INPUT[1];
            // Pressiona
            inputs[0].type = INPUT_MOUSE;
            inputs[0].mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            //--------
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
        }
        public static void click_mouse_direito_sem_soltar()
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            INPUT[] inputs = new INPUT[1];
            // Pressiona
            inputs[0].type = INPUT_MOUSE;
            inputs[0].mi.dwFlags = MOUSEEVENTF_RIGHTDOWN;
            //----------
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
        }
        public static void soltar_click_mouse_esquerdo()
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            INPUT[] inputs = new INPUT[1];
            // Solta
            inputs[0].type = INPUT_MOUSE;
            inputs[0].mi.dwFlags = MOUSEEVENTF_LEFTUP;
            //---------
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
        }
        public static void soltar_click_mouse_direito()
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            INPUT[] inputs = new INPUT[1];
            inputs[0].type = INPUT_MOUSE;
            inputs[0].mi.dwFlags = MOUSEEVENTF_RIGHTUP;
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
        }
        public static void ctrlC()
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            // Pressionar Ctrl
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
            auto.wait(tempoDelay);
            // Pressionar Ctrl
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
            auto.wait(tempoDelay);
            mouse_event(0x0800, 0, 0, -40 * linhas, 0);
        }
        public static void scroll_cima(int linhas)
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            mouse_event(0x0800, 0, 0, 40 * linhas, 0);
        }
        public static void mover_mouse_relativo(int x, int y)
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            mover_mouse_devagar(Cursor.Position.X + x, Cursor.Position.Y + y);
        }
        public static void alerta_msg(string m)
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            MessageBox.Show(m);
        }
        public static void alerta_msg_transferencia()
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            MessageBox.Show(Clipboard.GetText());
        }
        public static void AltTab()
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            //Pressionar Alt
            keybd_event((byte)teclas.VK_MENU, 0, KEYEVENTF_KEYDOWN, 0);
            // Pressionar Tab
            keybd_event((byte)teclas.VK_TAB, 0, KEYEVENTF_KEYDOWN, 0);
            // Soltar Tab
            keybd_event((byte)teclas.VK_TAB, 0, KEYEVENTF_KEYUP, 0);
            // Soltar Alt
            keybd_event((byte)teclas.VK_MENU, 0, KEYEVENTF_KEYUP, 0);
        }
        public static void Enter()
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            keybd_event((byte)teclas.VK_RETURN, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event((byte)teclas.VK_RETURN, 0, KEYEVENTF_KEYUP, 0);
        }
        public static void SegurarCTRL()
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            keybd_event((byte)teclas.VK_CONTROL, 0, KEYEVENTF_KEYDOWN, 0);
        }
        public static void SoltarCTRL()
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            keybd_event((byte)teclas.VK_CONTROL, 0, KEYEVENTF_KEYUP, 0);
        }
        public static void SegurarALT()
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            keybd_event((byte)teclas.VK_MENU, 0, KEYEVENTF_KEYDOWN, 0);
        }
        public static void SoltarALT()
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            keybd_event((byte)teclas.VK_MENU, 0, KEYEVENTF_KEYUP, 0);
        }
        public static void SegurarSHIFT()
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            keybd_event((byte)teclas.VK_SHIFT, 0, KEYEVENTF_KEYDOWN, 0);
        }
        public static void SoltarSHIFT()
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            keybd_event((byte)teclas.VK_SHIFT, 0, KEYEVENTF_KEYUP, 0);
        }
        public static void soltar_todas_teclas()
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
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
            auto.wait(tempoDelay);
            int _ = 0;
            while (_ < quantos_clicks)
            {
                click_mouse_esquerdo_padrao();
                _++;
            }
        }
        public static void add_arquivo_area_de_transferencia(string arq)
        {
            if (_pararMouseZerado()) { return; }
            auto.wait(tempoDelay);
            if (File.Exists(arq))
            {
                string filePath = arq;
                var fileList = new System.Collections.Specialized.StringCollection();
                fileList.Add(filePath);
                Clipboard.SetFileDropList(fileList);
            }
        }










        //---------------------------------------------
        //---------------------------------------------
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
        //----------------------
        private const int INPUT_MOUSE = 0;
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        //----------------------------
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        //----------------------
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

