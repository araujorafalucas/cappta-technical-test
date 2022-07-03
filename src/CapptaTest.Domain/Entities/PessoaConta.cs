namespace CapptaTest.Domain.Entities;

public class PessoaConta
{
    public string Nome { get; set; }
    public string Documento { get; set; }
    public int NumeroConta { get; set; }

    public void AtualizarDados(PessoaConta pessoaContaNovosDados)
    {
        Nome = pessoaContaNovosDados.Nome;
        Documento = pessoaContaNovosDados.Documento;
        NumeroConta = pessoaContaNovosDados.NumeroConta;
    }
}
