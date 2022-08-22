using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Artista: id, nombreCompleto, fechaNacimineto.
//Canción: id, nombreCancion, duracion, genero, idAlbum.
//Album:id, nombre, idArtista
//Lista: Artistas, Canciones y Albums.

//5. Agregar la funcionalidad correspondiente.

//6. Publicar en somee.com

//7. Agregar el enlace del proyecto publicado en somee.

namespace AplicacionWeb_Musical
{
    public class Global
    {
        //Declaramos la clase artista con su constructor,getters & setters
        #region Clase Artista

        public class Artista
        {
            //Artista: id, nombreCompleto, fechaNacimineto.
            int id;
            string nameCompleto;
            string fechaNacimiento;

            public Artista(int id, string nameCompleto, string fechaNacimiento)
            {
                this.Id = id;
                this.NameCompleto = nameCompleto;
                this.FechaNacimiento = fechaNacimiento;
            }

            public int Id { get => id; set => id = value; }
            public string NameCompleto { get => nameCompleto; set => nameCompleto = value; }
            public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        }
        //Declaramos la lista perteneciente a la clase artista

        public static List<Artista> Artistas = new List<Artista>()
        {
            new Artista(1,"Jaykel Javier González Ortíz","05/07/99"),
            new Artista(2,"Maicol Steven Juárez Rios","07/09/01"),
            new Artista(3,"Jaristhon José Siles Quiroz","18/04/03"),
            new Artista(4,"Ottoniel Alberto Morraz Cuadra","08/10/01"),
            new Artista(5,"Juan José López Aburto","02/10/03"),
        };

        #endregion

        //Declaramos la clase Canción con su constructor,getters & setters
        #region Clase Canción
        public class Cancion
        {
            //Canción: id, nombreCancion, duracion, genero, idAlbum.

            int id;
            string nombreCancion;
            string duracion;
            string genero;
            int idAlbum;

            public Cancion(int id, string nombreCancion, string duracion, string genero, int idAlbum)
            {
                this.Id = id;
                this.NombreCancion = nombreCancion;
                this.Duracion = duracion;
                this.Genero = genero;
                this.IdAlbum = idAlbum;
            }

            public int Id { get => id; set => id = value; }
            public string NombreCancion { get => nombreCancion; set => nombreCancion = value; }
            public string Duracion { get => duracion; set => duracion = value; }
            public string Genero { get => genero; set => genero = value; }
            public int IdAlbum { get => idAlbum; set => idAlbum = value; }
        }
        //Declaramos la lista perteneciente a la clase Canciones

        public static List<Cancion> Canciones = new List<Cancion>();

        #endregion

        //Declaramos la clase Album con su constructor,getters & setters
        #region Clase Album
        public class Album
        {
            //Album:id, nombre, idArtista

            int id;
            string nombreAlbum;
            int idArtista;

            public Album(int id, string nombreAlbum, int idArtista)
            {
                this.Id = id;
                this.NombreAlbum = nombreAlbum;
                this.IdArtista = idArtista;
            }

            public int Id { get => id; set => id = value; }
            public string NombreAlbum { get => nombreAlbum; set => nombreAlbum = value; }
            public int IdArtista { get => idArtista; set => idArtista = value; }
        }

        //Declaramos la lista perteneciente a la clase Album

        public static List<Album> Albunes = new List<Album>();

        #endregion 
    }
}