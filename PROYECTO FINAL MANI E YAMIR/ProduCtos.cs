using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller_Mecanico
{
    //Nombre de la Clase
    internal class ProduCtos
    {
        //Variables a Utilizar
        public string cliente, empleado, Servicio, MARCASAUTO,placas;
        public double PrecioDelServicio, PagoFinal;
       public double sumapagos = 0;
        //Metodo para asignar precios de servicios
        public string casos()
        {
            //Switch para asignar precios a cada uno de los servicios
            switch (Servicio)
            {
                case "Cambio de Aceite y Filtro":
                    PrecioDelServicio = 250;
                    break;
                case "Limpieza de Aire, Gasolina y Bujias":
                    PrecioDelServicio = 700;
                    break;
                case "Revicion de Luces":
                    PrecioDelServicio = 500;
                    break;
                case "Ajuste del Tiempo de Encendido":
                    PrecioDelServicio = 400;
                    break;
                case "Revicion de Clutch":
                    PrecioDelServicio = 1400;
                    break;
                case "Borner":
                    PrecioDelServicio = 2500;
                    break;
                case "Nivelar la Bateria":
                    PrecioDelServicio = 800;
                    break;
                case "Revision de Frenos":
                    PrecioDelServicio = 1500;
                    break;
                case "Aire Acondicionado y Calefaccion":
                    PrecioDelServicio = 10000;
                    break;
                case "Cambio de Bujias":
                    PrecioDelServicio = 750;
                    break;
                default:
                    break;
                   
            }
            //Acumulador para sumar segun que servicios aplicaron
            sumapagos += PrecioDelServicio;

            return PrecioDelServicio.ToString("c");
        }  
    }
}