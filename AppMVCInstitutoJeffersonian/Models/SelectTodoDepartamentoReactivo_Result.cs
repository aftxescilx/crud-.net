//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppMVCInstitutoJeffersonian.Models
{
    using System;
    
    public partial class SelectTodoDepartamentoReactivo_Result
    {
        public int idDepartamentoReactivo { get; set; }
        public int idDepartamento { get; set; }
        public int idReactivo { get; set; }
        public string lote { get; set; }
        public string codigo { get; set; }
        public System.DateTime fechaEmpaque { get; set; }
        public System.DateTime fechaCaducidad { get; set; }
        public Nullable<bool> estatus { get; set; }
        public Nullable<int> idUsuarioCrea { get; set; }
        public Nullable<System.DateTime> fechaCrea { get; set; }
        public Nullable<int> idUsuarioModifica { get; set; }
        public Nullable<System.DateTime> fechaModifica { get; set; }
    }
}
