public class Sistema
{
 //Atributos
    public List<Utilizador> Utilizadores { get; set; } = new List<Utilizador>();
    public List<EspacoDesportivo> Espacos { get; set; } = new List<EspacoDesportivo>();
    public List<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();
    public List<Reserva> Reservas { get; set; } = new List<Reserva>();

    // Guardar novo utilizador
    public void GuardarUtilizador(Utilizador utilizador)
    {
        Utilizadores.Add(utilizador);
    }


    // Procurar por email
    public Utilizador ObterPorEmail(string email)
    {
        foreach (Utilizador u in Utilizadores)
        {
            if (string.Equals(u.Email, email, StringComparison.OrdinalIgnoreCase))
            {
                return u;
            }
        }

        return null;
    }


    // Procurar por ID
    public Utilizador ObterPorId(int id)
    {
        foreach (Utilizador u in Utilizadores)
        {
            if (u.Id == id)
            {
                return u;
            }
        }

        return null;
    }


    // Reservas de um utilizador
    public List<Reserva> ObterReservasPorUtilizador(int idUtilizador)
    {
        List<Reserva> resultado = new List<Reserva>();

        foreach (Reserva r in Reservas)
        {
            if (r.Cliente.Id == idUtilizador)
            {
                resultado.Add(r);
            }
        }

        return resultado;
    }


    // Atualizar dados de um utilizador
    public void AtualizarUtilizador(Utilizador utilizador)
    {
        for (int i = 0; i < Utilizadores.Count; i++)
        {
            if (Utilizadores[i].Id == utilizador.Id)
            {
                Utilizadores[i] = utilizador;
                return;
            }
        }
    }


    // Guardar reserva
    public void GuardarReserva(Reserva reserva)
    {
        Reservas.Add(reserva);
    }


    // Atribuir ID à reserva
    public int AtribuirIdReserva()
    {
        return Reservas.Count + 1;
    }


    // Obter todos os utilizadores
    public List<Utilizador> ObterTodos()
    {
        return Utilizadores;
    }


    // Métodos do Espaço
    public void CriarEspaco() { }
    public void EliminarEspaco() { }
    public void AlterarEspaco() { }


    // Métodos Equipamentos
    public void CriarEquipamento() { }
    public void EliminarEquipamento() { }
    public void AlterarEquipamento() { }


    // Métodos Admin - Utilizadores
    public void ConsultarUtilizadores() { }
    public void EliminarUtilizador() { }
}


/*

    // Guardar novo utilizador
    public void GuardarUtilizador(Utilizador utilizador)
    {
        utilizadores.Add(utilizador);
    }

    // Procurar por email (devolve null se não existir)
    public Utilizador ObterPorEmail(string email)
    {
        foreach (Utilizador u in utilizadores)
        {
            if (string.Equals(u.Email, email, StringComparison.OrdinalIgnoreCase))
            {
                return u;
            }
        }
        return null;
    }

    public Utilizador ObterPorId(int id)
    {
        foreach (Utilizador u in utilizadores)
        {
            if (u.Id == id)
            {
                return u;
            }
        }
        return null;
    }
    
    // Reservas de um utilizador
    public List<Reserva> ObterReservasPorUtilizador(int idUtilizador)
    {
        List<Reserva> resultado = new List<Reserva>();

        foreach (Reserva r in reservas)
        {
            if (r.IdUtilizador == idUtilizador)
            {
                    resultado.Add(r);
            }
        }
        return resultado;
    }

    // Atualizar dados de um utilizador existente
    public void AtualizarUtilizador(Utilizador utilizador)
    {
        for (int i = 0; i < utilizadores.Count; i++)
        {
            if (utilizadores[i].Id == utilizador.Id)
            {
                utilizadores[i] = utilizador;
                return;
            }
        }
    }

    // Só para testes
    public void GuardarReserva(Reserva reserva)
    {
        reservas.Add(reserva);
    }

    public int AtribuirIdReserva()
    {
        return reservas.Count + 1;
    }

    public List<Utilizador> ObterTodos()
    {
        return utilizadores;
    }

    //Metodos do Espaco
        public void CriarEspaco() {}
        public void EliminarEspaco() {}
        public void AlterarEspaco() {}

        //Metodos Equipamentos
        public void CriarEquipamento() {}
        public void EliminarEquipamento() {}
        public void AlterarEquipamento() {}
        
        //Metodos Admin-Utilizadores
        public void ConsultarUtilizadores() {}
        public void EliminarUtilizador() {}
}


*/