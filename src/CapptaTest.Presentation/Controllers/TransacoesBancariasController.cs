using CapptaTest.Domain.Entities;
using CapptaTest.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CapptaTest.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransacoesBancariasController : ControllerBase
{
    private readonly ITransacoesBancariasRepositorio TransacoesBancariasRepositorio;
    public TransacoesBancariasController(ITransacoesBancariasRepositorio transacoesBancariasRepositorio)
    {
        TransacoesBancariasRepositorio = transacoesBancariasRepositorio;
    }

    [HttpGet]
    public ActionResult<IEnumerable<TransacaoBancaria>> Todos()
    {
        return Ok(TransacoesBancariasRepositorio.Todos());
    }


    [HttpGet]
    [Route("{id}")]
    public ActionResult<TransacaoBancaria> BuscarPorId(int id)
    {
        var transacaoBancaria = TransacoesBancariasRepositorio.BuscarPorId(id);

        if (transacaoBancaria is null)
        {
            return NoContent();
        }

        return transacaoBancaria;
    }

    [HttpPost]
    public ActionResult<TransacaoBancaria> Inserir([FromBody] TransacaoBancaria transacaoBancaria)
    {
        TransacoesBancariasRepositorio.Inserir(transacaoBancaria);

        return Ok(transacaoBancaria);
    }

    [HttpPut("{id}")]    
    public ActionResult<TransacaoBancaria> Atualizar(int id, [FromBody] TransacaoBancaria transacaoBancaria)
    {

        var transacaoBancariaAtual = TransacoesBancariasRepositorio.BuscarPorId(id);

        if (transacaoBancariaAtual is null)
        {
            return NotFound();
        }

        TransacoesBancariasRepositorio.Atualizar(transacaoBancariaAtual, transacaoBancaria);

        return Ok(transacaoBancariaAtual);
    }

    [HttpDelete]
    [Route("{id}")]
    public ActionResult<TransacaoBancaria> Excluir(int id)
    {
        var transacaoBancaria = TransacoesBancariasRepositorio.BuscarPorId(id);

        if (transacaoBancaria is null)
        {
            return NotFound();
        }

        TransacoesBancariasRepositorio.Excluir(transacaoBancaria);

        return Ok(transacaoBancaria);
    }

}
