using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_2
{
    public class Car
    {
        // Atributos del carro
        string color;
        int cilindraje;
        int modelo;

        // Motodo
        public string stop() {
            string msj = "El carro esta detenido";
            return msj;
        }
    }
}