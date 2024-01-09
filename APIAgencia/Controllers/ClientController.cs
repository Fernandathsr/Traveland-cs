using APIAgencia.Data;
using APIAgencia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIAgencia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly DataContext _context;

        public ClientController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<Client>>> GetAllClientes()
        {
            var clients = await _context.Clients.ToListAsync();
            return Ok(clients);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Client>> GetClient(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client is null)
                return NotFound("Client not found");
            return Ok(client);
        }

        [HttpPost]

        public async Task<ActionResult<List<Client>>> AddCliente(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
            return Ok(await _context.Clients.ToListAsync());
        }

        [HttpPut]

        public async Task<ActionResult<List<Client>>> UpdateClient(Client updateClient)
        {
            var dbClient = await _context.Clients.FindAsync(updateClient.Id);
            if (dbClient is null)
                return NotFound("Client not found");
            dbClient.Name = updateClient.Name;
            dbClient.Cpf = updateClient.Cpf;
            dbClient.Email = updateClient.Email;
            dbClient.Email = updateClient.Phone;
            dbClient.City = updateClient.City;

            await _context.SaveChangesAsync();
            return Ok(await _context.Clients.ToListAsync());

        }

        [HttpDelete]

        public async Task<ActionResult<List<Client>>> DeleteClient(int id)
        {
            var dbClient = await _context.Clients.FindAsync(id);
            if (dbClient is null)
                return NotFound("Client not found");
            _context.Clients.Remove(dbClient);

            await _context.SaveChangesAsync();
            return Ok(await _context.Clients.ToListAsync());
        }
    }
}

