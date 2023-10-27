using Examen_Gainete.Models;
using Microsoft.AspNetCore.Mvc;

namespace Examen_Gainete.Controllers

{
    [HttpGet]
    public IEnumerable<Ciudad> GetAll()
    {

    }

    [HttpGet("{id}")]
    public Ciudad GetById(int id)
    {

    }

    [HttpPost]
    public void Post(Ciudad ciudad)
    {

    }

    [HttpPut("{id}")]
    public void Put(int id, Ciudad ciudad)
    {

    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {

    }
}