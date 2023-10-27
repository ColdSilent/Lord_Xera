using Examen_Gainete.Models;
using Microsoft.AspNetCore.Mvc;

namespace Examen_Gainete.Controllers
{
    [HttpGet]
    public IEnumerable<Cuentas> GetAll()
    {

    }

    [HttpGet("{id}")]
    public Cuentas GetById(int id)
    {

    }

    [HttpPost]
    public void Post(Cuentas cuentas)
    {

    }

    [HttpPut("{id}")]
    public void Put(int id, Cuentas cuentas)
    {

    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {

    }

}
