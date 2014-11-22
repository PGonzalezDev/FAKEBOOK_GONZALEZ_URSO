using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAKEMODELS
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private string correo;
        private string confirmarcorreo;
        private string contraseña;
        private string confirmarcontraseña;
        private List<Usuario> amigos;
        private List<Publicaciones> Publicaciones;

       

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        

        public string Confirmarcorreo
        {
            get { return confirmarcorreo; }
            set { confirmarcorreo = value; }
        }
       

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        

        public string Confirmarcontraseña
        {
            get { return confirmarcontraseña; }
            set { confirmarcontraseña = value; }
        }
    
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
       
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        

        public List<Usuario> Amigos
        {
            get { return amigos; }
            set { amigos = value; }
        }

        public List<Publicaciones> Publicaciones1
        {
            get { return Publicaciones; }
            set { Publicaciones = value; }
        }

        
        public Usuario()
        {
            id = 0;
            apellido = "";
            nombre = "";
            correo = "";
            confirmarcorreo = "";
            contraseña = "";
            confirmarcontraseña = "";           
            amigos = new List<Usuario>();
            Publicaciones = new List<Publicaciones>();
        
        }

        public Usuario(string nombre, string apellido, string correo, string confirmarcorreo, string contraseña, string confirmarcontraseña)
        {
            Nombre = nombre;
            Apellido= apellido;
            Correo= correo;
            Confirmarcorreo= confirmarcorreo;
            Contraseña = contraseña;
            Confirmarcontraseña = confirmarcontraseña;
            Amigos= new List<Usuario>();
            Publicaciones1 = new List<Publicaciones>();
        
        }

        public Usuario AgregarAmigo(Usuario Amigo)
        {
            amigos.Add(Amigo);
            return Amigo;
        
        }

        public List <Usuario> BorrarAmigo(Usuario Amigo)
        {

            amigos.Remove(Amigo);
            return amigos;
        
        }






    }
}