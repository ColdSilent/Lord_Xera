using Examen_Gainete.Models;
using Microsoft.AspNetCore.Mvc;

namespace Examen_Gainete.Controllers
{
    [HttpGet]
    public IEnumerable<Movimientos> GetAll()
    {

    }

    [HttpGet("{id}")]
    public Movimientos GetById(int id)
    {

    }

    [HttpPost]
    public void Post(Movimientos movimientos)
    {

    }

    [HttpPut("{id}")]
    public void Put(int id, Movimientos movimientosas)
    {

    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {

    }
}
