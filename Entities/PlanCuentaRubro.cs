using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlIDMvc.Entities
{
    public class PlanCuentaRubro
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string NombreCuenta { get; set; }
        public decimal Moneda { get; set; }
        public decimal Valor { get; set; }
        public string Nivel { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
        public int PlanCuentaGrupoId { get; set; }
        public PlanCuentaGrupo PlanCuentaGrupo { get; set; }
        public List<PlanCuentaTitulo> PlanCuentaTitulo { get; set; }
    }
}