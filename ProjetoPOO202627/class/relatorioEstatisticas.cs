

public class RelatorioEstatisticas
{
    private List<Reserva> ListaReservas = new List<Reserva>();
    private List<EspacoDesportivo> ListaEspacos = new List<EspacoDesportivo>();

    // --- Estatísticas ---
    public int ObterTotalReservas()
    {
        return ListaReservas.Count;
    }

  // Conta quantas reservas tem um espaço
  public int ObterReservasPorEspaco(EspacoDesportivo espaco)
    {
        int contador = 0;

        foreach (Reserva r in ListaReservas)
        {
            if (r.Espaco == espaco)
            {
                contador++;
            }
        }

        return contador;
    }

 // Devolve as reservas que estão entre duas datas
    public List<Reserva> ObterReservasPorPeriodoTempo(TimeSpan horaInicio, TimeSpan horaFim)
    {
        List<Reserva> resultado = new List<Reserva>();

        foreach (Reserva r in ListaReservas)
        {
            if (r.HoraInicio >= horaInicio && r.HoraFim <= horaFim)
            {
                resultado.Add(r);
            }
        }

        return resultado;
    }

    // Devolve o espaço com mais reservas
    public EspacoDesportivo? ObterEspacoMaisUtilizado()
    {
        EspacoDesportivo? maisUtilizado = null;
        int maiorContagem = -1;

        foreach (EspacoDesportivo e in ListaEspacos)
        {
            int contagem = ObterReservasPorEspaco(e);

            if (contagem > maiorContagem)
            {
                maiorContagem = contagem;
                maisUtilizado = e;
            }
        }

        return maisUtilizado;
    }





}
