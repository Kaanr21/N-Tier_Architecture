using BeautyApp.Bussiness.Abstract;
using BeautyApp.Bussiness.Concrate;
using BeautyApp.Entity.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeautyApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DenemeController : ControllerBase
    {
        private readonly IGenericService<Deneme> _manager;
        public DenemeController(IGenericService<Deneme> manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var value = _manager.TGetList();
            return Ok(value);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _manager.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _manager.TDelete(id);
            return Ok("Hakkımızda Alanı Silindi");
        }

        [HttpPost]
        public IActionResult Create(Deneme Deneme)
        {
            //var newValue = _mapper.Map<About>(createAboutDto);
            _manager.TCreate(Deneme);
            return Ok("oluştu");
        }

        [HttpPut]
        public IActionResult Update(Deneme Deneme)
        {
            //var value = _mapper.Map<About>(updateAboutDto);
            _manager.TUpdate(Deneme);
            return Ok("Güncellendi");

        }
    }
}
