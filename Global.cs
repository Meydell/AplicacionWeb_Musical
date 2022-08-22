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
            new Artista(6,"Hogson Luis Pérez Coloso","02/10/04"),
            new Artista(7,"Kathy Valeska Flores Mendieta","02/18/05"),
            new Artista(8,"Eveling Lileisi Ocampo Mendieta","23/08/03"),
            new Artista(9,"Luis Alfredo López Aburto","23/08/03"),
            new Artista(10,"Karen Isayana Ruíz Olivas","23/07/00"),
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

        public static List<Cancion> Canciones = new List<Cancion>()
        {
            new Cancion(1,"Un día nublado","3:46 Minutos","Romántica",1),
            new Cancion(2,"Respirando Seco","4:26 Minutos","Romántica",2),
            new Cancion(3,"Lluvia en Enero","2:56 Minutos","Romántica",3),
            new Cancion(4,"Suspiro","4:56 Minutos","Funk",4),
            new Cancion(5,"En el techo","3:56 Minutos","Pop",5),
            new Cancion(6,"A lo lejos","3:20 Minutos","Funk",6),
            new Cancion(7,"Tu canción","2:56 Minutos","Funk",7),
            new Cancion(8,"Del río","4:56 Minutos","Pop",8),
            new Cancion(9,"Azul","3:56 Minutos","Romántica",9),
            new Cancion(10,"Atardecer","2:45 Minutos","Romántica",10),

        };

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

        public static List<Album> Albunes = new List<Album>()
        {
            new Album(1,"Pasión y Dolor",1),
            new Album(2,"Ternura Apasionada",2),
            new Album(3,"En lo frío de tus besos",3),
            new Album(4,"Te amaré",4),
            new Album(5,"Costumbre de caricias",5),
            new Album(6,"Al borde de tu corazón",6),
            new Album(7,"Haciendo Pausas",7),
            new Album(8,"En tus Ojos",8),
            new Album(9,"Rompiendo la Discoteca",9),
            new Album(10,"Rompiendo la Discoteca",10),
            //new Album(11,"Mal de amores",1),
            //new Album(12,"En lo Divino",5),
            //new Album(13,"Respirando tu aroma",10),
            //new Album(14,"A flor de piel",8),
        };

        #endregion 
    }
}