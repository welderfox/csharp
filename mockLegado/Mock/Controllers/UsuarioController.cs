using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Mock.Models;
using Newtonsoft.Json;

namespace Mock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private const string PATH = "App_Data/usuarios.json";

        [HttpGet, DisableCors]
        public async Task<IActionResult> GetAsync()
        {
            var usuarios = await GetUsuariosAsync();
            return Json(usuarios);
        }

        //[HttpGet("{id}", Name = "Get")]
        //public IActionResult Get(int id) => Json(Usuarios.Where(w => w.Matricula == id).SingleOrDefault());

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody]UsuarioModel body)
        {
            var usuarios = await GetUsuariosAsync();

            if (body != null)
                usuarios.Add(body);

            var texto = JsonConvert.SerializeObject(usuarios);
            var file = Encoding.UTF8.GetBytes(texto);
            await System.IO.File.WriteAllBytesAsync(PATH, file);
            Wait();
            return Json(new ResponseModel { IsValid = true });
        }

        //[HttpPut("{id}")]
        //public IActionResult Put(UsuarioModel model)
        //{
        //    var entity = Usuarios.Where(w => w.Matricula == model.Matricula).SingleOrDefault();
        //    if (entity == null)
        //        return Json(new ResponseModel() { IsValid = false, Message = "Não existe" });

        //    entity.Nome = model.Nome;
        //    entity.Email = model.Email;

        //    Wait();
        //    return Json(new ResponseModel { IsValid = true });
        //}

        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    var entity = Usuarios.Where(w => w.Matricula == id).SingleOrDefault();

        //    if (entity == null)
        //        return Json(new ResponseModel() { IsValid = false, Message = "Não existe" });

        //    Usuarios.Remove(entity);

        //    Wait();
        //    return Json(new ResponseModel { IsValid = true });
        //}

        private void Wait()
        {
            Thread.Sleep(2000);
        }

        private async Task<List<UsuarioModel>> GetUsuariosAsync()
        {
            var file = await System.IO.File.ReadAllBytesAsync(PATH);
            var texto = Encoding.UTF8.GetString(file);
            var usuarios = JsonConvert.DeserializeObject<List<UsuarioModel>>(texto);
            return usuarios;
        }
    }
}
