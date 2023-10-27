using Examen_Gainete.Models;
using Microsoft.AspNetCore.Mvc;

namespace Examen_Gainete.Controllers
{
    [HttpGet]
    public IEnumerable<Cliente> GetAll()
    {

}

    [HttpGet("{id}")]
    public Cliente GetById(int id)
    {

}

    [HttpPost]
    public void Post(Cliente cliente)
    {

    }

    [HttpPut("{id}")]
    public void Put(int id, Cliente cliente)
    {

    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {

    }
}
