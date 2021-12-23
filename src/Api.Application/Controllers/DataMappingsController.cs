using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.DTOs.DataMapping;
using Api.Domain.Interfaces.Services;
using Api.Domain.Interfaces.Services.UsuarioService;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class DataMappingsController : ControllerBase
    {
        private IDataMappingService _service;

        public DataMappingsController(IDataMappingService service)
        {
            _service = service;
        }

        // [Authorize("Bearer")]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // [Authorize("Bearer")]
        [HttpGet]
        [Route("{id}", Name = "GetDataMappingById")]
        public async Task<ActionResult> Get(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }

        // [Authorize("Bearer")]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DataMappingDTOWrite dataMapping)
        {
            if (!ModelState.IsValid)
            {
                BadRequest(ModelState);
            }

            try
            {
                var result = await _service.Post(dataMapping);
                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetDataMappingById", new { id = result.Id })), result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // [Authorize("Bearer")]
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] DataMappingDTOWrite dataMapping)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _service.Put(id, dataMapping);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // [Authorize("Bearer")]
        [HttpPut("inativar/{id}")]
        public async Task<ActionResult> Inactivate(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _service.Inactivate(id);
                if (result)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest("Não foi possível inativar o DataMapping!");
                }
            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // [Authorize("Bearer")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException e)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
