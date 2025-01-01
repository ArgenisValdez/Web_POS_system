using Microsoft.AspNetCore.Mvc;

using AutoMapper;
using Newtonsoft.Json;
using SistemaVenta.AplicacionWeb.Models.ViewModels;
using SistemaVenta.AplicacionWeb.Utilidades.Response;
using SistemaVenta.BLL.Interfaces;
using SistemaVenta.Entity;

namespace SistemaVenta.AplicacionWeb.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IRolService _rolServicio;
        private readonly IMapper _mapper;

        public UsuarioController(IUsuarioService usuarioService,
            IRolService rolServicio,
            IMapper mapper)
        {
            _usuarioService = usuarioService;
            _rolServicio = rolServicio;
            _mapper = mapper;
        }


        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> ListaRoles()
        {
            List<VMRol> vmListaRoles = _mapper.Map<List<VMRol>>(await _rolServicio.Lista());
            return StatusCode(StatusCodes.Status200OK, vmListaRoles);
        }

        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            List<VMUsuario> vmUsuarioLista = _mapper.Map<List<VMUsuario>>(await _usuarioService.Lista());
            return StatusCode(StatusCodes.Status200OK, new { data = vmUsuarioLista });
        }

        [HttpPost]
        public async Task<IActionResult> Crear([FromForm] IFormFile foto,[FromForm] string modelo)
        {
            GenericResponse<VMUsuario> gResponse = new GenericResponse<VMUsuario>();

            try
            {

                



            }
            catch (Exception ex)
            {

                
            }

        }


            

    }
}
