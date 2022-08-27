
using Microsoft.AspNetCore.Mvc;
using ControlIDMvc.Models.DatatableModel;
using Microsoft.EntityFrameworkCore;
using ControlIDMvc.Entities;
using Microsoft.AspNetCore.Cors;
using ControlIDMvc.Services;
using ControlIDMvc.Querys;
using ControlIDMvc.Services.QueryControlId;
using ControlIDMvc.Services.ControlId;

namespace ControlIDMvc.Controllers;

[Route("persona")]
public class PersonaController : Controller
{
    /* propiedades */
    public string controlador = "192.168.88.129";
    public string uri = "login.fcgi";
    public string user = "admin";
    public string password = "admin";
    private readonly ILogger<HomeController> _logger;
    private readonly HttpClientService _httpClientService;
    private PersonaQuery _personaQuery;
    private readonly LoginControlIdQuery _loginControlIdQuery;
    private readonly UsuarioControlIdQuery _usuarioControlIdQuery;

    public PersonaController(
        ILogger<HomeController> logger,
        HttpClientService httpClientService,
        PersonaQuery personaQuery,
        LoginControlIdQuery loginControlIdQuery,
        UsuarioControlIdQuery usuarioControlIdQuery
        )
    {
        this._httpClientService = httpClientService;
        this._personaQuery = personaQuery;
        this._usuarioControlIdQuery = usuarioControlIdQuery;
        this._logger = logger;

        this._loginControlIdQuery = loginControlIdQuery;
        this._loginControlIdQuery.ApiUrl = "login.fcgi";
        this._usuarioControlIdQuery.ApiUrl = "create_objects.fcgi";
    }

    [HttpGet]
    public async Task<ActionResult> Index()
    {
        var personas = await this._personaQuery.GetAll();
        return View("~/Views/Persona/Lista.cshtml");
    }

    [HttpGet("create")]
    public ActionResult Create()
    {
        return View("~/Views/Persona/Create.cshtml");
    }

    [HttpPost("store")]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Post(Persona PersonaCreate)
    {
        object cuerpo = _loginControlIdQuery.Login(this.user, this.password);
        string Token = await this._httpClientService.LoginRun(controlador, this._loginControlIdQuery.ApiUrl, cuerpo);
        this._httpClientService.session=Token;
        
        List<Persona> usuarios = new List<Persona>();
        Persona usuario = new Persona();
        usuarios.Add(PersonaCreate);
        var addUser = this._usuarioControlIdQuery.CreateUser(usuarios);
        string responseUsers = await this._httpClientService.Run(controlador, this._usuarioControlIdQuery.ApiUrl, addUser);

        var personas = await this._personaQuery.Store(PersonaCreate);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost("data-table")]
    public ActionResult DataTable()
    {
        var dataTable = this._personaQuery.DataTable(Request);
        return Json(dataTable);
    }

    [HttpGet("editar/{id:int}")]
    public async Task<ActionResult> Edit(int id)
    {
        var persona = await this._personaQuery.GetOne(id);
        if (persona == null)
        {
            return NotFound();
        }
        return View("~/Views/Persona/Edit.cshtml", persona);
    }

}

