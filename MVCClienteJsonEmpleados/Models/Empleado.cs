using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace MVCClienteJsonEmpleados.Models
{
    public class Empleado
    {
        //public String APELLIDO { get; set; } QUIERO USAR MINUSCULAS....using Newtonsoft.Json;
        //public String OFICIO { get; set; }    Y [JsonProperty("APELLIDO")]
        //public int SALARIO { get; set; }

        [JsonProperty("APELLIDO")]
        public String Apellido { get; set; }
        [JsonProperty("OFICIO")]
        public String Oficio { get; set; }
        [JsonProperty("SALARIO")]
        public int Salario { get; set; }

    }
}

/*"EMP_NO": 7322,
    "APELLIDO": "FORD",
    "OFICIO": "VENDEDOR",
    "DIR": 7919,
    "FECHA_ALT": "1982-04-04T00:00:00",
    "SALARIO": 129000,
    "COMISION": 0,
    "DEPT_NO": 20*/
