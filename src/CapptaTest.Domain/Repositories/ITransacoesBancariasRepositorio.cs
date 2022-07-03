using CapptaTest.Domain.Entities;

namespace CapptaTest.Domain.Repositories;

public interface ITransacoesBancariasRepositorio
{
    void Inserir(TransacaoBancaria transacaoBancaria);
    void Atualizar(TransacaoBancaria transacaoBancariaAtual, TransacaoBancaria transacaoBancariaNova);
    void Excluir(TransacaoBancaria transacaoBancaria);
    IEnumerable<TransacaoBancaria> Todos();
    TransacaoBancaria BuscarPorId(int id);

}
