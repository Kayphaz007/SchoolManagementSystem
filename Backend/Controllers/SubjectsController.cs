using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend;


public class SubjectsController : BaseApiController
{
    private readonly SchoolContext _context;

    public SubjectsController(SchoolContext context)
    {
        _context = context;


    }

    [HttpGet]
    public async Task<ActionResult<List<Subject>>> GetSubjects(){
        return await _context.Subjects.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Subject>> GetSubject(int id){
        var subject = await _context.Subjects.FindAsync(id);

        return subject == null ? NotFound(): subject;
    }
}
