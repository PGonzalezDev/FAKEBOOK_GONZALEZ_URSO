using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAKEMODELS
{
    public class Comentario
    {
        private User user;
        private Publicaciones publicacion;
        private int id;
        private string coment;
        private string fecha;

        public User User
        {
            get { return user; }
            set { user = value; }
        }
       

        public Publicaciones Publicacion
        {
            get { return publicacion; }
            set { publicacion = value; }
        }
        

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
       

        public string Coment
        {
            get { return coment; }
            set { coment = value; }
        }
        

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Comentario(User user, Publicaciones publicacion, string coment, string fecha, int id)
        {

            User = user;
            Publicacion = publicacion;
            Coment = coment;
            Fecha = fecha;
            Id = id;        
        }

        public Comentario()
        {
            User = null;
            Publicacion = null;
            Coment = "";
            Id = -1;
            Fecha = "";
        }


    }
}