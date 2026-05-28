using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/posts")]
public class PostController
{
    private readonly PostService _service;

    public PostController(PostService service)
    {
        _service = service;
    }

    [HttpGet]
    public List<PostDTO> GetAll()
    {
        return _service.GetAll();
    }

    [HttpGet("{id}")]
    public ActionResult<PostDTO?> GetById(int id)
    {
        PostDTO? p = _service.GetById(id);

        return p;
    }

}