using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using Newtonsoft.Json;

namespace MVCClienteJsonEmpleados.Models
{
    public class ModeloEmpleados
    {

        public List<Empleado> GetEmpleados()
        {
            WebClient cliente = new WebClient();
            String url = "https://webapiempleadosroutejgd.azurewebsites.net/api/Empleados";
            cliente.Headers["content-type"] = "application/json";
            String contenido = cliente.DownloadString(url);
           List<Empleado> lista = JsonConvert.DeserializeObject<List<Empleado>>(contenido);
            return lista;
        }
        public Empleado GetEmpleado(int id)
        {
            WebClient cliente = new WebClient();
            String url = "https://webapiempleadosroutejgd.azurewebsites.net/api/Empleados/"+id;
            cliente.Headers["content-type"] = "application/json";
            String contenido = cliente.DownloadString(url);
            Empleado emp = JsonConvert.DeserializeObject<Empleado>(contenido);
            return emp;
        }
        public List<Empleado> GetEmpleadosSalario(int salario)
        {
            WebClient cliente = new WebClient();
            String url = "https://webapiempleadosroutejgd.azurewebsites.net/api/EmpleadosSalario/"+salario;
            cliente.Headers["content-type"] = "application/json";
            String contenido = cliente.DownloadString(url);
            List<Empleado> lista = JsonConvert.DeserializeObject<List<Empleado>>(contenido);
            return lista;
        }

    }
}





/*List<Empleado> lista;
            WebClient cliente = new WebClient();
            String url = "https://webapiempleadosroutejgd.azurewebsites.net/api/Empleados";
            cliente.Headers["content-type"] = "application/json";
            String contenido = cliente.DownloadString(url);

            //Empleado emp = JsonConvert.DeserializeObject(contenido) as Empleado; enviar empleado simple
            lista = JsonConvert.DeserializeObject <List<Empleado>>(contenido);*/
