using AutoMapper;
using Contracts;
using Entities.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace FavoritosTest.Controllers
{
  [Route("api/user")]
  [ApiController]
  public class UserController : ControllerBase
  {
    private IRepositoryWrapper _repository;
    private IMapper _mapper;

    public UserController(IRepositoryWrapper repository, IMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }

    [HttpGet]
    public IActionResult RecuperarTodosUsuarios()
    {
      try
      {
        var users = _repository._user.RecuperarTodosUsuarios();
        if (users == null)
        {
          return NotFound();
        }
        var userResult = _mapper.Map<IEnumerable<UserDTO>>(users);
        return Ok(userResult);
      }
      catch (Exception ex)
      {
        return StatusCode(500, $"Falla interna en el servidor: {ex.Message}");
      }
    }

    [HttpGet("{id}")]
    public IActionResult RecuperarUsuarioPorId(int id)
    {
      try
      {
        var user = _repository._user.RecuperarUsuarioPorId(id);
        if (user == null)
        {
          return NotFound();
        }
        var userResult = _mapper.Map<UserDTO>(user);
        return Ok(userResult);
      }
      catch (Exception ex)
      {
        return StatusCode(500, $"Falla interna en el servidor: {ex.Message}");
      }
    }

    [HttpGet("{id}/favoritos")]
    public IActionResult RecuperarUsuarioConDetalles(int id)
    {
      try
      {
        var user = _repository._user.RecuperarUsuarioConDetalles(id);
        if (user == null)
        {
          return NotFound();
        }
        var userResult = _mapper.Map<UserDTO>(user);
        return Ok(userResult);
      }
      catch (Exception ex)
      {
        return StatusCode(500, $"Falla interna del servidor: {ex.Message}");
      }
    }

    [HttpGet("test")]
    public async System.Threading.Tasks.Task<IActionResult> Test()
    {
      string page = "https://jsonplaceholder.typicode.com/albums/";
      using (HttpClient client = new HttpClient())
      {
        client.DefaultRequestHeaders.UserAgent.ParseAdd("Fiddler");
        using (HttpResponseMessage response = await client.GetAsync(page))
        using (HttpContent content = response.Content)
        {
          string result = await content.ReadAsStringAsync();
          if (result != null)
          {
            return Ok(result);
          }
        }
      }
      return StatusCode(500, $"Falla interna del servidor");
    }
  }
}
