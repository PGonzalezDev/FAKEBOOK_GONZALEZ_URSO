using System;
using System.Collections.Generic;
using System.Linq;

namespace FAKEMODELS
{
    public class RegisterUser
    {
        private int id;
        private string firstName;
        private string lastName;
        private string mail;
        private string confirmMail;
        private string password;
        private string confirmPassword;
        //private List<RegisterUser> amigos;
        //private List<Publicaciones> Publicaciones;

       

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        

        public string ConfirmMail
        {
            get { return confirmMail; }
            set { confirmMail = value; }
        }
       

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set { confirmPassword = value; }
        }
    
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
       
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        
        /*
        public List<RegisterUser> Amigos
        {
            get { return amigos; }
            set { amigos = value; }
        }

        public List<Publicaciones> Publicaciones1
        {
            get { return Publicaciones; }
            set { Publicaciones = value; }
        }
        */
        
        public RegisterUser()
        {
            id = 0;
            lastName = "";
            firstName = "";
            mail = "";
            confirmMail = "";
            password = "";
            confirmPassword = "";           
            //amigos = new List<RegisterUser>();
            //Publicaciones = new List<Publicaciones>();
        
        }

        public RegisterUser(string nombre, string apellido, string correo, string confirmarcorreo, string contraseña, string confirmarcontraseña)
        {
            FirstName = nombre;
            LastName= apellido;
            Mail= correo;
            ConfirmMail= confirmarcorreo;
            Password = contraseña;
            ConfirmPassword = confirmarcontraseña;
            //Amigos= new List<RegisterUser>();
            //Publicaciones1 = new List<Publicaciones>();
        
        }
        /*
        public RegisterUser AgregarAmigo(RegisterUser Amigo)
        {
            amigos.Add(Amigo);
            return Amigo;
        
        }
        
        public List <RegisterUser> BorrarAmigo(RegisterUser Amigo)
        {

            amigos.Remove(Amigo);
            return amigos;
        
        }
        */

        public bool IsValid()
        {
            bool isValid = (string.Compare(this.mail, this.confirmMail) == 0);
            isValid = isValid && (string.Compare(this.password, this.confirmPassword) == 0);

            return isValid;
        }
    }
}