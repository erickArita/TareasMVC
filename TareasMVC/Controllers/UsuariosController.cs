using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TareasMVC.Models;

namespace TareasMVC.Controllers;

public class UsuariosController : Controller
{
    public UsuariosController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
    {
        UserManager = userManager;
        SignInManager = signInManager;
    }

    public UserManager<IdentityUser> UserManager { get; }
    public SignInManager<IdentityUser> SignInManager { get; }

    public IActionResult Index()
    {
        return Redirect("/Tareas/Index");
    }

    [AllowAnonymous]
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [AllowAnonymous]
    [HttpGet]
    public IActionResult Registro()
    {
        return View();
    }

    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> Registro(RegistroViewModel model)
    {
        if (!ModelState.IsValid) return View(model);

        var usuario = new IdentityUser
        {
            UserName = model.Email,
            Email = model.Email
        };

        var res = await UserManager.CreateAsync(usuario);
        if (res.Succeeded)
        {
            await SignInManager.SignInAsync(usuario, false);
            return RedirectToAction("Index");
        }

        foreach (var error in res.Errors) ModelState.AddModelError("", error.Description);

        return View(model);
    }
}