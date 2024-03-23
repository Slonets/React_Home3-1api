using DatePicture.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Emit;

namespace DatePicture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PictureController : ControllerBase
    {
        public static List<PictureNewModel> _model=new List<PictureNewModel>()
        {
            new PictureNewModel
            {
             Id=1,
             Title="Мадонна велика (Sistine Madonna)", 
             Description="Ця картина, створена в 1512 році, є однією з найвідоміших ікон Мадонни Рафаеля. Вона зображує Мадонну з дитям, ангелів із характерним виразом та композицією."
            },
            new PictureNewModel
            {Id=2,
            Title="Мадонна з трояндами (La Madonna delle Rose)",
            Description="Це ще одна картина з образом Мадонни з дитям. Робота характеризується вишуканим стилем та ніжністю образу."
            },
            new PictureNewModel
        {Id=3,
        Title="Портрет юнака з лаурою (Portrait of a Young Man with a Laurel Wreath)",
        Description="Цей портрет представляє собою зображення молодого чоловіка, який тримає в руках лавровий вінок. Робота вражає своєю реалістичністю і майстерністю виконання."},

        new PictureNewModel
        {Id=4,
        Title="Сикстинська Мадонна (Sistine Madonna)",
        Description="Це ще одна відома картина Мадонни, яка відзначається тим, що ангели підтримують її високо над землею. Ця картина знаходиться в Галереї Старого Майстерства у Дрездені, Німеччина."}
        };

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_model);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _model.FirstOrDefault(x => x.Id == id);

        return Ok(value);
        }

        //[FromBody] означає, що туди буде щось приходити
        [HttpPost]
        public IActionResult Post([FromBody]CreatePictureViewModel model)
        {
            _model.Add(new PictureNewModel
            {
                Title = model.Title,
                Description = model.Description,
                Id = _model.Count + 1
            });

            return Ok();
        }
    }  
}
