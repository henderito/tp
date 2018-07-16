using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominio
{
    public class ReportGen
    {
        private string defaultPrinter;

        public ReportGen()
            { PrinterSettings pw = new PrinterSettings();
            defaultPrinter = pw.PrinterName;
        }

        public void reporte(List<Incidencia> r)
            { string path = createFile("Incidencias");
            TextWriter tw = new StreamWriter(path, true);
            tw.WriteLine("---- Reporte de Incidencias ----");
            tw.Close();
            List<string> l = listToString(r);
            escribirReporte(path, l);
          /*  int costoTotal = costoIncidencias(r);
            tw.WriteLine(" MONTO TOTAL DE LA OPERACION: $" + costoTotal.ToString());
            tw.Close();*/
            Printer.Print(path, defaultPrinter);
            MessageBox.Show("Reporte generado con exito!");
        }

        public void reporte(List<Venta> r)
            { string path = createFile("Ventas");
            TextWriter tw = new StreamWriter(path, true);
            tw.WriteLine("---- Reporte de Ventas ----");
            tw.Close();
            List<string> l = listToString(r);
            escribirReporte(path, l);
          /*  int costoTotal = costoVentas(r);
            tw.WriteLine(" MONTO TOTAL DE LA OPERACION: $" + costoTotal.ToString());
            tw.Close();*/
            Printer.Print(path, defaultPrinter);
            MessageBox.Show("Reporte generado con exito!");
        }

        public void reporteVentaFecha(List<Venta> r, DateTime d)
            {
            string path = createFile("Ventas del dia: " + d.ToShortDateString());
            TextWriter tw = new StreamWriter(path, true);
            tw.WriteLine("---- Reporte de Ventas ----");
            tw.Close();
            List<string> l = listToString(r);
            escribirReporte(path, l);
            int costoTotal = costoVentas(r);
            tw.WriteLine(" MONTO TOTAL DE LA OPERACION: $" + costoTotal.ToString());
            tw.Close();
            Printer.Print(path, defaultPrinter);
            MessageBox.Show("Reporte generado con exito!");
        }

        public void reporteIncidenciaFecha(List<Incidencia> r, DateTime d)
            {
            string path = createFile("Incidencias del dia: " + d.ToShortDateString());
            TextWriter tw = new StreamWriter(path);
            tw.WriteLine("---- Reporte de Incidencias ----");
            tw.Close();
            List<string> l = listToString(r);
            escribirReporte(path, l);
            int costoTotal = costoIncidencias(r);
            tw.WriteLine(" MONTO TOTAL DE LA OPERACION: $" + costoTotal.ToString());
            tw.Close();
            Printer.Print(path, defaultPrinter);
            MessageBox.Show("Reporte generado con exito!");
        }

        private string createFile(string name)
            {//Var path --> Obtiene el path del root del proyecto
            //string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filename = "Reporte de " + name + ".txt";
            if (File.Exists(filename))
                { File.Delete(filename); }
            return filename;
        }

        private void escribirReporte(string path, List<string> reporte)
            {for (int i = 0; i < reporte.Count(); i++)
                {
                TextWriter tw = new StreamWriter(path, true);
                tw.WriteLine(reporte[i]);
                tw.Close();
            } }

        private List<string> listToString(List<Incidencia> r)
            {
            List<string> l = new List<string>();
            for (int i = 0; i < r.Count(); i++)
                { l.Add(r[i].ToString()); }
            return l;
        }

        private List<string> listToString(List<Venta> r)
        {
            List<string> l = new List<string>();
            for (int i = 0; i < r.Count(); i++)
            { l.Add(r[i].ToString()); }
            return l;
        }

        private int calcularCostoTotal(Venta v)
            {int costo = 0;
            for (int i = 0; i < v.ArticulosVendidos.Count(); i++)
                { costo += (v.ArticulosVendidos[i].CantVendida * v.ArticulosVendidos[i].Precio); }
            costo = (costo * v.Int.Porcentaje);
            return costo;
        }

        private int costoIncidencias(List<Incidencia> r)
        {
            int costo = 0;
            for (int i = 0; i < r.Count(); i++)
            { costo += calcularCostoTotal(r[i].ventaRelacionada); }
            return costo;
        }

        private int costoVentas(List<Venta> v)
        {
            int costo = 0;
            for (int i = 0; i < v.Count(); i++)
            { costo += calcularCostoTotal(v[i]); }
            return costo;
        }
    }
}
