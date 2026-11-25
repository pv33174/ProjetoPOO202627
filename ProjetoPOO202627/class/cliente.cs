public class Cliente : Utilizador
{
    //tem q ir buscar o construtor da classe mãe, que é a classe Utilizador, para poder criar um cliente com os mesmos atributos de um utilizador
    public Cliente(int id, string nomeUtilizador, string email, string palavraPasse) : base(id, nomeUtilizador, email, palavraPasse)
    {
    }

    // Consultar reservas do cliente
    public List<Reserva> ConsultarMinhasReservas(Sistema sistema)
    {
        return sistema.ObterReservasPorUtilizador(Id);
    }

    // Criar uma nova reserva
    public void CriarReserva(Sistema sistema, EspacoDesportivo espaco,
                             DateTime dia, TimeSpan horaInicio,
                             TimeSpan horaFim)
    {
        Reserva novaReserva = new Reserva(
            sistema.AtribuirIdReserva(),
            this,
            espaco,
            dia,
            horaInicio,
            horaFim,
            "Pendente"
        );

        sistema.GuardarReserva(novaReserva);
    }

    // Cancelar uma reserva
    public void CancelarReserva(Sistema sistema, int idReserva)
    {
        foreach (Reserva r in sistema.Reservas)
        {
            if (r.Id == idReserva && r.Cliente.Id == Id)
            {
                r.CancelarReserva();
                return;
            }
        }
    }

    // Alterar reserva
    public void AlterarReserva()
    {

    }
}