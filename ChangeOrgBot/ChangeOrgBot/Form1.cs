using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace ChangeOrgBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Cursor.Position.ToString();
            this.TopMost = true;
        }

        public static int ct = 1;
        public void log()
        {
            this.Text = ct.ToString();
            ct++;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Focus();
            textBox1.SelectAll();

            // auto.wait(1000);
            auto.digitar_teclado("^c");
            auto.wait(5000);

            ///Minimizar ao iniciar
            if (checkBox1.Checked)
            {
                this.WindowState = FormWindowState.Minimized;
            }

            //auto.pararMouseZerado = true;

            bool a = true;
            int ct = 0;
            List<string> linkReferencia = new List<string>();

            //portaria
            if (radioButton1.Checked)
            {
                while (a)
                {


                    Random rand = new Random();
                    auto.wait(rand.Next(2000, 60000));


                    if (Cursor.Position.X == 0)
                    {
                        if (Cursor.Position.Y == 0)
                        {
                            a = false;
                            return;
                        }
                    }



                    string[] nome = gerar();
                    label2.Text = nome[0] + Environment.NewLine + nome[1] + Environment.NewLine + nome[2];


                    log(); auto.definir_delay(2000);
                    //auto.digitar_teclado("{F5}");
                    //log(); auto.definir_delay(5000;
                    //------------------------------------------
                    log(); auto.mover_mouse(1301, 78);
                    log(); auto.definir_delay(1000);
                    log(); auto.click_mouse_esquerdo_padrao();//abrir nova guia
                    log(); auto.definir_delay(2000);
                    log(); auto.mover_mouse(1090, 182);
                    log(); auto.click_mouse_esquerdo_padrao();
                    log(); auto.digitar_teclado("^v");
                    log();  // auto.digitar_teclado("https://www.change.org/p/nomear-os-aprovados-na-funda%C3%A7%C3%A3o-de-assist%C3%AAncia-social-de-caxias-do-sul?source_location=search");
                    log(); auto.digitar_teclado("{ENTER}");
                    log(); auto.definir_delay(10000);
                    log(); auto.mover_mouse(931, 565);
                    log(); auto.definir_delay(1000);
                    log(); auto.click_mouse_esquerdo_padrao();

                    log(); auto.scroll_baixo(480);
                    log(); auto.scroll_baixo(480);

                    log(); auto.definir_delay(2000);
                    log(); auto.mover_mouse(937, 175);
                    log(); auto.click_mouse_esquerdo_padrao();
                    log(); auto.digitar_teclado(nome[0]);


                    log(); auto.mover_mouse(937, 248);
                    log(); auto.click_mouse_esquerdo_padrao();
                    log(); auto.digitar_teclado(nome[1]);


                    log(); auto.mover_mouse(937, 315);
                    log(); auto.click_mouse_esquerdo_padrao();
                    log(); auto.digitar_teclado(nome[2]);


                    log(); auto.mover_mouse(934, 484);
                    log(); auto.click_mouse_esquerdo_padrao();
                    log(); auto.mover_mouse(937, 641);
                    log(); auto.click_mouse_esquerdo_padrao();

                    log(); auto.definir_delay(1000);
                    log(); auto.click_mouse_esquerdo_padrao();

                    auto.scroll_baixo(10000);
                    auto.scroll_baixo(10000);
                    auto.scroll_baixo(10000);

                    log(); auto.mover_mouse(667, 636);
                    log(); auto.click_mouse_esquerdo_padrao();
                    log(); auto.definir_delay(2000);

                    auto.scroll_baixo(10000);
                    auto.scroll_baixo(10000);
                    auto.scroll_baixo(10000);



                    log(); auto.mover_mouse(667, 636);
                    log(); auto.click_mouse_esquerdo_padrao();
                    //------------------------------------------
                    log(); auto.definir_delay(1000);
                    auto.mover_mouse(667, 636);
                    auto.click_mouse_esquerdo_padrao();
                    auto.wait(5000);

                    int loop = 0;
                    while (loop < 50)
                    {
                        auto.definir_delay(300);
                        auto.scroll_baixo(10000);
                        auto.scroll_baixo(10000);
                        auto.mover_mouse(395, 483);
                        auto.click_mouse_esquerdo_padrao();
                        loop++;
                    }
                    auto.definir_delay(2000);
                    auto.mover_mouse(669, 611);
                    auto.click_mouse_esquerdo_padrao();
                    auto.definir_delay(6000);
                    auto.digitar_teclado("%{F4}");

                    ct++;
                    if (ct == (int)numericUpDown1.Value)
                    {

                        a = false;

                    }
                    //obter um link de referencia aleatorio
                    //linkReferencia.Add(Clipboard.GetText());
                    //Random random = new Random();
                    //Clipboard.SetText(linkReferencia[random.Next(linkReferencia.Count)]);
                    //------------------------------------

                    this.Text = ct.ToString();
                }
            }

            //pc de casa
            if (radioButton2.Checked)
            {
                while (a)
                {



                    Random rand = new Random();
                    //auto.wait(rand.Next(2000, 50000));
                    auto.wait(rand.Next(2000, 5000));

                    if (Cursor.Position.X == 0)
                    {
                        if (Cursor.Position.Y == 0)
                        {
                            a = false;
                            return;
                        }
                    }

                    string[] nome = gerar();
                    label2.Text = nome[0] + Environment.NewLine + nome[1] + Environment.NewLine + nome[2];


                    auto.definir_delay(2000);
                    //------------------------------------------
                    auto.mover_mouse(1534, 51);
                    auto.click_mouse_esquerdo_padrao();
                    auto.mover_mouse(1317, 151);
                    auto.click_mouse_esquerdo_padrao();
                    auto.mover_mouse(731, 53);
                    auto.click_mouse_esquerdo_padrao();
                    auto.digitar_teclado("^v");
                    // auto.digitar_teclado("https://www.change.org/p/nomear-os-aprovados-na-funda%C3%A7%C3%A3o-de-assist%C3%AAncia-social-de-caxias-do-sul?source_location=search");
                    auto.digitar_teclado("{ENTER}");
                    auto.definir_delay(7000);


                    //aceitar cookies
                    auto.mover_mouse(1097, 674);
                    auto.definir_delay(1000);
                    auto.click_mouse_esquerdo_padrao();
                    //---------------------------

                    auto.scroll_baixo(12);

                    auto.definir_delay(5000);
                    auto.mover_mouse(1087, 167);//seleciona o campo do nome
                    auto.click_mouse_esquerdo_padrao();
                    auto.digitar_teclado(nome[0]);


                    auto.definir_delay(1000);
                    auto.mover_mouse(1088, 252);//seleciona o campo do ssobrenome
                    auto.click_mouse_esquerdo_padrao();
                    auto.digitar_teclado(nome[1]);

                    auto.definir_delay(1000);
                    auto.mover_mouse(1114, 334);//seleciona o campo d o email
                    auto.click_mouse_esquerdo_padrao();
                    auto.digitar_teclado(nome[2]);
                    //----------------------------------
                    auto.definir_delay(1000);
                    auto.mover_mouse(1066, 502);// Não, prefiro não acompanhar as novidades desta petição ou de outras petições relevantes.
                    auto.click_mouse_esquerdo_padrao();

                    auto.definir_delay(1000);
                    auto.mover_mouse(1122, 671);//clica em ASSINAR
                    auto.click_mouse_esquerdo_padrao();

                    //----------------------

                    auto.definir_delay(6000);
                    //auto.click_mouse_esquerdo_padrao();
                    auto.scroll_baixo(10000);
                    auto.mover_mouse(797, 809); //quer doar dinehiro?
                    auto.click_mouse_esquerdo_padrao();


                    auto.scroll_baixo(10000);
                    auto.mover_mouse(786, 786);//adicione uma mensagem para aumentar o impacto da sua assinatura!
                    auto.click_mouse_esquerdo_padrao();

                    // auto.wait(5000);
                    // auto.mover_mouse(797, 806);
                    // auto.click_mouse_esquerdo_padrao();
                    //------------------------------------------
                    auto.definir_delay(1000);
                    auto.wait(5000);//pra evitar clicar no icone do facebook

                    int loop = 0;
                    while (loop < 50)
                    {
                        auto.definir_delay(200);
                        auto.scroll_baixo(10000);
                        auto.mover_mouse(561, 655);
                        auto.click_mouse_esquerdo_padrao();
                        loop++;
                    }
                    auto.definir_delay(1000);
                    auto.mover_mouse(793, 786);
                    auto.click_mouse_esquerdo_padrao();



                    //like no comentario

                    auto.mover_mouse(731, 53);
                    auto.definir_delay(3000);
                    auto.click_mouse_esquerdo_padrao();
                    auto.digitar_teclado("^v");
                    // auto.digitar_teclado("https://www.change.org/p/nomear-os-aprovados-na-funda%C3%A7%C3%A3o-de-assist%C3%AAncia-social-de-caxias-do-sul?source_location=search");
                    auto.digitar_teclado("{ENTER}");
                    auto.definir_delay(7000);

                    auto.mover_mouse(467, 199);
                    auto.click_mouse_esquerdo_padrao();
                    auto.definir_delay(2000);
                    auto.scroll_baixo(10000);
                    auto.mover_mouse(427, 343);
                    auto.click_mouse_esquerdo_padrao();
                    //------------------------


                    auto.definir_delay(4000);
                    auto.digitar_teclado("%{F4}");

                    ct++;
                    if (ct == (int)numericUpDown1.Value)
                    {
                        a = false;
                    }

                    //obter um link de referencia aleatorio
                    linkReferencia.Add(Clipboard.GetText());
                    Random random = new Random();
                    Clipboard.SetText(linkReferencia[random.Next(linkReferencia.Count)]);
                    //------------------------------------



                    this.Text = ct.ToString();
                }
            }






        }


        public static string[] gerar()
        {
            string[] final = new string[10];

            string[] primeirosNomes = {  "Ana", "Bruno", "Carla", "Daniel", "Eduarda", "Fernando", "Gabriela", "Henrique", "Isabela", "João",
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

            string[] sobrenomes = { "Abreu", "Aguiar", "Albuquerque", "Almeida", "Alves", "Amaral", "Amorim", "Andrade", "Antunes", "Araujo",
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

            string[] sobrenomesSecundarios = { "Neto", "Medeiros", "Galvão", "Amaral", "Pimentel", "Castro",
    "Miranda", "Rios", "Veloso", "Soares", "Diniz", "Franco", "Bueno", "Valente", "Garcia", "Otero",
    "Paiva", "Cabral", "Cordeiro", "Bastos", "Sampaio", "Santana", "Faria", "Viana", "Assis", "Matos",
    "Bispo", "Caetano", "Donato", "Esteves", "Fontes", "Goulart", "Hernandes", "Inácio", "Junqueira", "Klein",

    // Sobrenomes de origem italiana (comuns no Sul/Sudeste)
    "Rossi", "Bianchi", "Ferrari", "Romano", "Colombo", "Ricci", "Marino", "Greco", "Bruno", "Rizzo",
    "Conti", "De Luca", "Mancini", "Costa", "Giordano", "Rosa", "Lombardi", "Moretti", "Galli", "Martini",
    "Leone", "D'Angelo", "Longo", "Gentile", "Martinelli", "Serra", "Coelho", "Vitali", "Pereira", "Rinaldi"};

            Random rand = new Random();
            string nome = primeirosNomes[rand.Next(primeirosNomes.Length)];
            string sobrenome1 = sobrenomes[rand.Next(sobrenomes.Length)];
            string sobrenome2 = sobrenomesSecundarios[rand.Next(sobrenomesSecundarios.Length)];

            // Condição para decidir se o segundo sobrenome será incluído ou não
            bool incluirSegundoSobrenome = rand.Next(2) == 0; // 50% de chance

            // Montar os resultados
            string[] resultado = new string[3];


            Random randssss = new Random();
            List<string> gg = new List<string>();

            if (incluirSegundoSobrenome)
            {
                gg = GerarSugestoesEmail(nome + " " + sobrenome1 + " " + sobrenome2);
            }
            else
            {
                gg = GerarSugestoesEmail(nome + " " + sobrenome1);
            }



            resultado[0] = nome;
            resultado[1] = incluirSegundoSobrenome ? sobrenome1 + " " + sobrenome2 : sobrenome1;
            resultado[2] = gg[rand.Next(0, gg.Count)];

            return resultado;


        }

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

        public static List<string> GerarSugestoesEmail(string nomeCompleto)
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



        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            auto.wait(3000);
            auto.scroll_baixo((int)numericUpDown2.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] nome = gerar();
            File.AppendAllText("log.txt", "Nome: "+nome[0] + "\nSobrenome: " + nome[1] + "\nNome Completo:: "+ nome[0] + " " + nome[1] + "\nEmail: " + nome[2] +"\n-----------\n");
        }
    }
}
