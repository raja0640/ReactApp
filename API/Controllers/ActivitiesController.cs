using Jnr.Technologies.Persistence;
using Jnr.Technologies.Persistence.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Jnr.Technologies.Api.Controllers;

public class ActivitiesController : BaseApiController
{
    private readonly DataContext _context;

    public ActivitiesController(DataContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<ActivityModel>>> GetActivities()
    {
        return await _context.Activities.ToListAsync();
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<ActivityModel>> GetActivity(Guid id)
    {
        return await _context.Activities.FindAsync(id);
    }   
}