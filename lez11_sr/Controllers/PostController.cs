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

}