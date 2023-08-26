using Microsoft.AspNetCore.Mvc;

namespace Backend;

[ApiController]
[Route("api/[controller]")]
public class SubjectsController : ControllerBase
{
    private readonly SchoolContext context;
    public SubjectsController(SchoolContext context)
    {
        this.context = context;

    }

    [HttpGet]
    public ActionResult<List<Subject>> GetSubjects(){
        var subjects = context.Subjects.ToList();

        return Ok(subjects);
    }

    [HttpGet("{id}")]
    public ActionResult<Subject> GetSubject(int id){
        return context.Subjects.Find(id);
    }
}
