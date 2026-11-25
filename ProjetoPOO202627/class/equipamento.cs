public class Equipamento
{
    public int IdEquipamento {get; set; }
    public string NomeEquipamento {get; set; }
    public string TipoEquipamento {get; set; }
    public int QuantidadeDisponivel {get; set; }

    // ------ Construtor ------
     public Equipamento (int Id, string Nome, string Tipo, int Quantidade)
    {
        IdEquipamento = Id;
        NomeEquipamento = Nome;
        TipoEquipamento = Tipo;
        QuantidadeDisponivel = Quantidade;
    }

    // ------ Métodos ------
    public bool VerificarDisponibilidade()
    {
        if (QuantidadeDisponivel > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

/*
    Id: int
    Nome: string
    Tipo: string
    QuantidadeTotal: int   <----------- sugiro eliminar, não é requisito do projeto
    QuantidadeDisponivel: int

    Métodos:
    verificarDisponibilidade
    atualizarStock   <---------------------- a classe sistema acaba por fazer isso
*/