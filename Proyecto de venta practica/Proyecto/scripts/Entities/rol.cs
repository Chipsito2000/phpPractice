using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 
namespace Entities
{
    public class rol
    {
        [Key] public int Id_Rol{get; set;}
        public string Descripcion{get; set;}

        public virtual ICollection<Rgistro> Registros { get; set; }
    }
}