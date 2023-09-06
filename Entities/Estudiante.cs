namespace Clases.Estudiante
{
    public class Entities
    {
        public string id;
        private string nombre;
        private string email;
        private int edad;        
        
        public string Id{
            get{return id;}
            set{id = value;}
        }
        public int Edad{
            get{return edad;}
            set{edad = value;}
        }
        
        public string Nombre{
            get{return nombre;}
            set{nombre = value;}
        }
        public string Email{
            get{return email;}
            set{email = value;} 
        }
        public Estudiante(){

        };
        public Estudiante(string id,string nombre,string email,int edad){
            this.id = id;
            this.nombre=nombre;
            this.email=email;
            this.edad=edad;   
        }
    }
}