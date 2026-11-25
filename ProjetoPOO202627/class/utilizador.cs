// using System.ComponentModel.DataAnnotations; quem colocou isto?
public class Utilizador
{
        public int Id { get; set; }

        public string NomeUtilizador { get; set; }
        public string Email { get; set; }
        public string PalavraPasse { get; set; }

        //Metodos Utilizador
        public void EfetuarLogin() {}
        public void AtualizarPerfil() {}

        // Construtor 
        public Utilizador(int id, string nomeUtilizador, string email, string palavraPasse)
        {
            Id = id;
            NomeUtilizador = nomeUtilizador;
            Email = email;
            PalavraPasse = palavraPasse;
        }

        

        /*

        // ------ CRIAR CONTA ------
        static void CriarConta()
        {
            string email = PedirEmail();

            if (EmailExiste(email))
            {
                MostrarErro("Não pode criar conta com este email: já está associado a outra conta.");
                return;
            }

            string palavraPasse = PedirPalavraPasse();
            string nome = PedirNome();   // novo

            Utilizador novo = new Utilizador
            {
                Id = AtribuirId(),
                NomeUtilizador = nome,
                Email = email,
                PalavraPasse = palavraPasse
            };

            Utilizadores.Add(novo);
        }

        static string PedirEmail()
        {
            string email;
            Console.WriteLine("Insira o seu Email: ");
            email = Console.ReadLine();
            email = ValidarEmail(email);

            return email;
        }

        // Email válido: não vazio e com @
        static string ValidarEmail(string email)
        {
            while (email.Trim() == "" || !email.Contains("@"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Email Inválido");
                Console.ResetColor();
                Console.WriteLine("Insira o seu Email novamente: ");

                email = Console.ReadLine();
            }
        }

        // ------ Atribuir ID ------
        static int AtribuirId()
        {
            int maior = 0;

            foreach (Utilizador u in Utilizadores)
            {
                if (u.Id > maior)
                {
                    maior = u.Id;
                }
            }

            return maior + 1;
        }

        // ------ Pedir Palavra-passe ------
        static string PedirPalavraPasse()
        {
            Console.WriteLine("Insira a Palavra-passe: ");
            string pass = Console.ReadLine();

                while (pass.Trim() == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Palavra-passe inválida.");
                    Console.ResetColor();
                    Console.WriteLine("Insira a Palavra-passe novamente: ");
                    pass = Console.ReadLine();
                }

            return pass;
        }

        // ------ Pedir Nome ------
        static string PedirNome()
        {
            string nome;
            Console.WriteLine("Insira o seu Nome: ");
            nome = Console.ReadLine();
            nome = ValidarNome(nome);

            return nome;
        }

        static string ValidarNome(string nome)
        {
            while (nome.Trim() == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nome Inválido");
                Console.ResetColor();
                Console.WriteLine("Insira o Nome novamente: ");

                nome = Console.ReadLine();
            }

            return nome;
        }


        // ------ Adicionar à lista o utilizador ------
        static void ListarUtilizadores()
        {
            foreach (Utilizador u in Utilizadores)
            {
                Console.WriteLine("ID: " + u.Id + " ; Nome: " + u.NomeUtilizador + " ; Email: " + u.Email);
            }
        }


        */


}
 


