public class Cliente : Utilizador
{
    //tem q ir buscar o construtor da classe mãe, que é a classe Utilizador, para poder criar um cliente com os mesmos atributos de um utilizador
    public Cliente(int id, string nomeUtilizador, string email, string palavraPasse) : base(id, nomeUtilizador, email, palavraPasse)
    {
    }

    //Metodos Reservas
    public void ConsultarMinhasReservas()
    {
            
    }
    public void CriarReserva()
    {
            
    }
    public void AlterarReserva()
    {
            
    }
    public void CancelarReserva()
    {
            
    }
}