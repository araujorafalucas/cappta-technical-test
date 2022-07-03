using CapptaTest.Domain.Entities;

namespace CapptaTest.Domain.Repositories;

public class TransacoesBancariasRepositorio : ITransacoesBancariasRepositorio
{
    private List<TransacaoBancaria> TransacoesBancarias;
    public TransacoesBancariasRepositorio()
    {
        TransacoesBancarias = new List<TransacaoBancaria>();
    }

    public void Inserir(TransacaoBancaria transacaoBancaria)
    {
        transacaoBancaria.Id = ProximoId();

        TransacoesBancarias.Add(transacaoBancaria);
    }

    public void Atualizar(TransacaoBancaria transacaoBancariaAtual, TransacaoBancaria transacaoBancariaNova)
    {
        transacaoBancariaAtual.AtualizarDados(transacaoBancariaNova);
    }

    public void Excluir(TransacaoBancaria transacaoBancaria)
    {
        TransacoesBancarias.Remove(transacaoBancaria);
    }

    public IEnumerable<TransacaoBancaria> Todos()
    {
        return TransacoesBancarias.AsEnumerable();
    }

    public TransacaoBancaria BuscarPorId(int id)
    {
        return TransacoesBancarias.FirstOrDefault(transacao => transacao.Id == id);
    }

    private int ProximoId()
    {
        return TransacoesBancarias.Count == 0 ? 1 : TransacoesBancarias.Max(x => x.Id) + 1;
    }
}
