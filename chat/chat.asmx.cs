using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace chat
{
    /// <summary>
    /// Descripción breve de chat
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class chat : System.Web.Services.WebService
    {

        [WebMethod]
        public string Chat(string msj)
        {
            switch (msj)
            {
                case "Hola": 
                    return "Hola como estas";
                case "De donde eres": 
                    return "De muzquiz";
                case "Como estas": 
                    return "Bien y tu";
                case "Como te llamas": 
                    return "Me llamo Julio";
                case "Tienes cel": 
                    return "Si porque?";
                case "Tienes web cam": 
                    return "Si, me quieres ver?";
                case "Quieres mostrarme": 
                    return "Que quieres que te muestre";
                case "Que buscas realmente": 
                    return "Amistad";
                case "Te gusta experimentar nuevas cosas": 
                    return "Si me gusta experimentar";
                case "Hasta donde quieres llegar": 
                    return "A mi casa";
                case "Cuantos años tienes": 
                    return "24 años";

                default: return "Que?";

                   
                
            }
        }
    }
}
