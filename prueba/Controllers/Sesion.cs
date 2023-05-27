using Microsoft.AspNetCore.Mvc;
using TuProyecto.Models;

namespace TuProyecto.Controllers
{
    public class CuentaController : Controller
    {
        // Acción para mostrar el formulario de inicio de sesión
        public ActionResult IniciarSesion()
        {
            return View();
        }

        // Acción para procesar el inicio de sesión
        [HttpPost]
        public ActionResult IniciarSesion(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Aquí puedes realizar la lógica de validación del inicio de sesión
                // Por ejemplo, verificar las credenciales y redirigir al usuario a la página de inicio si son válidas
                // Si las credenciales son inválidas, puedes agregar un mensaje de error al modelo y volver a mostrar el formulario de inicio de sesión

                // Ejemplo básico de validación de inicio de sesión
                if (model.Usuario == "usuario" && model.Contrasena == "contrasena")
                {
                    // Las credenciales son válidas, redirigir al usuario a la página de inicio
                    return RedirectToAction("Inicio", "Home");
                }
                else
                {
                    // Las credenciales son inválidas, agregar un mensaje de error
                    ModelState.AddModelError("", "Credenciales inválidas");
                }
            }

            // Si llegamos hasta aquí, significa que ocurrió un error, volvemos a mostrar el formulario de inicio de sesión
            return View(model);
        }
    }
}
