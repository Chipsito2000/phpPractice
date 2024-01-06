using System;
using System.ComponentModel.DataAnnotations; 

namespace Entities
{
    public class Registro 
    {
         [Key] public int IdRegistro {get; set;}
         public int Id_Rol {get; set;}
         public string Nombre {get; set;}
         public string Apellido {get; set;}
         public string correo {get;  set;}
         public string contraseña {get; set;}

        [ForeignKey("Id_RolRefId")] public virtual rol rol { get; set; }
    }
}








