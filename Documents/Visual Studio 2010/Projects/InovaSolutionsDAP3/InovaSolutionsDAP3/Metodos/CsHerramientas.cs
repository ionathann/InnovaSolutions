using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace InovaSolutionsDAP3.Metodos
{
    public class CsHerramientas
    {

        public static int gridvg(DataGridView dgv)
        {
            int valorsito;
            int i;
            i = dgv.SelectedCells[0].RowIndex;
            valorsito = Convert.ToInt32(dgv.Rows[i].Cells[0].Value);

            return valorsito;

        }


        public static List<string> getEstudios()
        {

            var listEstudios = new List<string>();
             listEstudios.Add("Kinder-preescolar");
             listEstudios.Add("Primaria");
             listEstudios.Add("Secundaria");
             listEstudios.Add("Bachillerato");
             listEstudios.Add("Carrera");
             listEstudios.Add("Maestría");
             listEstudios.Add("Doctorado");
            

            return listEstudios;
        }
    }
}
