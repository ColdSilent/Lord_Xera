using Examen_Gainete.Models;
using Microsoft.AspNetCore.Mvc;

namespace Examen_Gainete.Controllers
{
    [HttpGet]
    public IEnumerable<Persona> GetAll()
    {

    }

    [HttpGet("{id}")]
    public Persona GetById(int id)
    {

    }

    [HttpPost]
    public void Post(Persona persona)
    {

    }

    [HttpPut("{id}")]
    public void Put(int id, Persona persona)
    {

    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {

    }
}
