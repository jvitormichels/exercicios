using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Pensionato
{
    class Quarto
    {
        public int NumeroQuarto;
        public string OcupanteNome;
        public string OcupanteEmail;

        public Quarto(string ocupanteNome, string ocupanteEmail, int numero)
        {
            NumeroQuarto = numero;
            OcupanteNome = ocupanteNome;
            OcupanteEmail = ocupanteEmail;
        }

        public override string ToString()
        {
            return $"--- Quarto n°{NumeroQuarto} ---\n" +
                $"Ocupante: {OcupanteNome}, {OcupanteEmail}";
        }
    }
}
