using CapptaTest.Domain.Enums;

namespace CapptaTest.Domain.Entities;

public class TransacaoBancaria
{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public PessoaConta PessoaContaOrigem { get; set; }
    public PessoaConta PessoaContaDestino { get; set; }
    public TiposPagamento TipoPagamento { get; set; }    
    public decimal Valor { get; set; }

    public void AtualizarDados(TransacaoBancaria transacaoBancariaNovosDados)
    {
        Data = transacaoBancariaNovosDados.Data;
        Valor = transacaoBancariaNovosDados.Valor;

        TipoPagamento = transacaoBancariaNovosDados.TipoPagamento;

        PessoaContaOrigem.AtualizarDados(transacaoBancariaNovosDados.PessoaContaOrigem);
        PessoaContaDestino.AtualizarDados(transacaoBancariaNovosDados.PessoaContaDestino);


    }
}
