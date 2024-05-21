﻿using CU_24_GenerarReporte.Controlador;
using CU_24_GenerarReporte.Entidades;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CU_24_GenerarReporte.Boundary
{
    public partial class PantallaPrincipal : Form
    { 

        // Crear instancias de TipoUva
        static TipoUva cabernetSauvignon = new TipoUva("Cabernet Sauvignon", "Una de las variedades de uva más conocidas en el mundo.");
        static TipoUva merlot = new TipoUva("Merlot", "Una variedad de uva tinta utilizada para elaborar vino.");
        static TipoUva blanca = new TipoUva("Cabernet Sauvignon", "Una de las variedades de uva más conocidas en el mundo.");


        // Crear instancias de Varietal 
        static Varietal varietal1 = new Varietal("Vino Tinto", 75.5, cabernetSauvignon);
        static Varietal varietal2 = new Varietal("Vino Blanco", 24.5, merlot);
        static List<Varietal> listaVarietales = new List<Varietal> { varietal1,varietal2 };

         
        // Crear instancias de RegionVitivinicola
        static RegionVitivinicola region1 = new RegionVitivinicola("Valle de Napa", "Famosa por sus vinos tintos de alta calidad.");
        static RegionVitivinicola region2 = new RegionVitivinicola("Valle de Casablanca", "Conocida por sus vinos blancos frescos y aromáticos.");

        // Crear instancias de Provincias
        static Provincia provincia1 = new Provincia("Mendoza");
        static Provincia provincia2 = new Provincia("Santiago del Estero");
        static Provincia provincia3 = new Provincia("San Juan");
        static Provincia provincia4 = new Provincia("La Rioja");

        // Crear una instancia de País
        static Pais pais = new Pais("Argentina");

         
        // Creación de dos objetos de la clase Reseña
        static Reseña reseñaSommelier = new Reseña("Excelente vino, muy recomendado.", true, DateTime.Now, 5);
        static Reseña reseñaEnofilo = new Reseña("Buen vino, pero esperaba más.", false, DateTime.Now, 3);

        //Creación de Bodega:
        static Bodega bodega1 = new Bodega("36.7783° N, 119.4179° W", "Bodega en el Valle de Napa", "Fundada en 1900", "Napa Valley Vineyards", DateTime.Now, region1 );

        static Vino vino1 = new Vino(2020, DateTime.Now, "etiqueta1.jpg", "Vino Tinto Reserva",      "Notas de roble y frutas rojas", 1000.0m,         bodega1, new List<Varietal> { varietal1 });
        static Vino vino2 = new Vino(2019, DateTime.Now, "etiqueta2.jpg", "Vino Blanco Chardonnay",  "Notas de manzana y melón",      850.0m,         bodega1, new List<Varietal> { varietal2 });
        static Vino vino3 = new Vino(2018, DateTime.Now, "etiqueta3.jpg", "Vino Rosado",             "Notas frescas y afrutadas",     750.0m,       bodega1, new List<Varietal> { varietal1 });
        static Vino vino4 = new Vino(2017, DateTime.Now, "etiqueta4.jpg", "Vino Espumante Brut",     "Notas de pan tostado y almendras", 1200.0m,     bodega1, new List<Varietal> { varietal2 });
        static Vino vino5 = new Vino(2021, DateTime.Now, "etiqueta5.jpg", "Vino Tinto Gran Reserva", "Intenso y estructurado",        1500.0m,       bodega1, new List<Varietal> { varietal1 });
        static Vino vino6 = new Vino(2022, DateTime.Now, "etiqueta6.jpg", "Vino Blanco Sauvignon Blanc", "Cítrico y refrescante", 900.0m,            bodega1, new List<Varietal> { varietal2 });
        static Vino vino7 = new Vino(2023, DateTime.Now, "etiqueta7.jpg", "Vino Naranja",             "Complejo y distintivo", 1100.0m,               bodega1, new List<Varietal> { varietal1 });
        static Vino vino8 = new Vino(2016, DateTime.Now, "etiqueta8.jpg", "Vino Tinto de Guarda",     "Envejecido en barrica", 2000.0m,              bodega1, new List<Varietal> { varietal2 });
        static Vino vino9 = new Vino(2015, DateTime.Now, "etiqueta9.jpg", "Vino Blanco Dulce",        "Notas de miel y frutas tropicales", 950.0m,     bodega1, new List<Varietal> { varietal1 });
        static Vino vino10 =new Vino(2014, DateTime.Now, "etiqueta10.jpg","Vino Tinto Syrah",         "Potente y especiado", 1300.0m,            bodega1, new List<Varietal> { varietal2 });

        // Creación de objetos de la clase Vino (se reutilizan los objetos creados previamente)
        static List<Vino> listaVinos = new List<Vino>
        {
            vino1, vino2, vino3, vino4, vino5, vino6, vino7, vino8, vino9, vino10
        };

        // Creación del objeto Gestor
        //static Gestor gestor = new Gestor(listaVinos, DateTime.Now.AddMonths(-1), DateTime.Now, "Premium", "Pantalla");
         

        private Gestor gestorAtributo;

        public PantallaPrincipal()
        {
            InitializeComponent();

            gestorAtributo = new Gestor(listaVinos, DateTime.Now.AddMonths(-1), DateTime.Now, "Premium", "Pantalla",this);

            panelGenerarRanking.Visible = false;
            rbExcel.Checked = true;

            // Mostrar información de varietal1
            Console.WriteLine("Varietal 1:");
            varietal1.TipoUva.MostrarInformacion();
            varietal1.MostrarPorcentaje();
            Console.WriteLine();

            // Mostrar información de varietal2
            Console.WriteLine("Varietal 2:");
            varietal2.TipoUva.MostrarInformacion();
            varietal2.MostrarPorcentaje();
             

            // Mostrar información de las regiones vitivinícolas
            Console.WriteLine("Región 1:");
            region1.MostrarInformacion();
            Console.WriteLine();

            Console.WriteLine("Región 2:");
            region2.MostrarInformacion();

            Console.WriteLine("Agrego las regiones a la provincias:");
            provincia1.Regiones.Add(region1);
            provincia1.Regiones.Add(region2);

            // Agregar provincias al país
            pais.Provincias.Add(provincia1);
            pais.Provincias.Add(provincia2);
            pais.Provincias.Add(provincia3);
            pais.Provincias.Add(provincia4);

            pais.MostrarInformacion();
            pais.MostrarProvincias();
             
        }
         
        private void btnGenerarRankingDeVinos_Click(object sender, EventArgs e)
        {
            OpcionGenerarRankingDeVinos();
        }
        
        private void btnGenerarRanking_Click(object sender, EventArgs e)
        {
            //Cuando hace click para generar el reporte:
            gestorAtributo.OpcionGenerarRankingVinos(); //este método no sé que función cumple.

            //Solicita las fechas
            //(DateTime desde, DateTime hasta) fechasDyH = SolicitarSelFechaDesdeYHasta();
            //Valida el período
            

            //Solicitamos el tipo de reseña.
            //string tipoReseña = SolicitarSelTipoReseña();

            //gestorAtributo.TomarSeleccionTipoReseña(tipoReseña);

             
        }

        private void OpcionGenerarRankingDeVinos()
        {
            HabilitarPantalla();
        }
        private void HabilitarPantalla()
        {
            panelGenerarRanking.Visible = true;
            // Configurar los botones para usar el estilo Flat
              
             
        }
        public void SolicitarSelFechaDesdeYHasta()
        {
            DateTime desde = TomarFechaDesde();
            DateTime hasta = TomarFechaHasta();

             
            if (ValidarPeriodo(desde,hasta))
            {
                MessageBox.Show("El periodo es válido.", "Validación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //si es válido..
                gestorAtributo.TomarSelFechaDesdeYHasta(desde,hasta);
            }
            else
            {
                MessageBox.Show("El periodo no es válido. La fecha 'Desde' debe ser menor o igual a la fecha 'Hasta'.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            
        }
        public DateTime TomarFechaDesde()
        {
            return dtpDesde.Value;
        }
        public DateTime TomarFechaHasta()
        {
            return dtpHasta.Value;
        }
        public bool ValidarPeriodo(DateTime desde, DateTime hasta)
        {
             
            if (desde <= hasta)
            {
                return true;
            }
            return false ;
        }

        public void SolicitarSelTipoReseña()
        {
            string tipoReseña =  TomarSelTipoReseña();
            //return tipoReseña;

            gestorAtributo.TomarSelTipoVisualizacion(tipoReseña);
        }
     
        public string TomarSelTipoReseña()
        {
            return cmbTipoReseña.SelectedItem.ToString();

        }
        public void SolicitarSelTipoVisualizacion()
        {
            string tipoVisualizacion = TomarSelTipoVisualizacion();

            gestorAtributo.TomarSelTipoVisualizacion(tipoVisualizacion);
        }
        private string TomarSelTipoVisualizacion()
        {
            if (rbPDF.Checked)
            {
                return "PDF";
            }
            else if (rbExcel.Checked)
            {
                return "Excel";
            }
            else if (rbPantalla.Checked)
            {
                return "Pantalla";
            }
            else
            {
                return null; // Ningún RadioButton está seleccionado
            }
        }

        public void SolicitarConfirmacionGenReporte()
        {

            if (TomarConfirmacionGenReporte())
            {
                // Código para generar el reporte
                MessageBox.Show("Generando el reporte...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gestorAtributo.TomarConfirmacionGenReporte();
            }
            else
            {
                // Código si el usuario cancela la generación del reporte
                MessageBox.Show("Operación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private bool TomarConfirmacionGenReporte()
        {
            DialogResult result = MessageBox.Show("¿Desea Generar el Reporte con estos datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
        private void btnPDF_Click(object sender, EventArgs e)
        {

        }

        private void rbExcel_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
