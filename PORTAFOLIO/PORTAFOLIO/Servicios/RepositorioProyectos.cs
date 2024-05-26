using PORTAFOLIO.Models;

namespace PORTAFOLIO.Servicios
{
    public class RepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto> {
                new Proyecto
            {
                Titulo = "Amazon",
                Descripcion = "E-commerce realizado en ASP.NET Core",
                Link = "https://amazon.com/",
                ImagenURL = "/imagenes/Amazon.png"
            },
                 new Proyecto
            {
                Titulo = "NewYork Times",
                Descripcion = "Pagina de noticias en React",
                Link = "https://nytimes.com/",
                ImagenURL = "/imagenes/nytimes.png"
            },
                  new Proyecto
            {
                Titulo = "Reddit",
                Descripcion = "Red social para compartir en comunidades ",
                Link = "https://reddit.com/",
                ImagenURL = "/imagenes/Reddit.png"
            },
                   new Proyecto
            {
                Titulo = "Steam",
                Descripcion = "Tienda en linea para comprar videojuegos",
                Link = "https://store.steampowered.com/",
                ImagenURL = "/imagenes/steam.png"
            },
            };
        }

    }
}
