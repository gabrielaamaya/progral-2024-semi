using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academica_tarea
{
    public partial class Docente : Form
    {
        public Docente()
        {
            InitializeComponent();
        }
        private void materias_Load(object sender, EventArgs e)
        {
            actualizarDs(); // Cargar los datos de la base de datos al abrir el formulario
        }
        private void actualizarDs()
        {
            ds.Clear();                         // Limpiar el DataSet
            ds = objConexion.obtenerDatos();    // Obtener los datos desde la base de datos
            miTabla = ds.Tables["materias"];     // Asignar la tabla de materias al DataTable
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idMateria"] }; // Clave primaria
            grdDatosMaterias.DataSource = miTabla; // Mostrar los datos en el DataGridView
            mostrarDatosMaterias();              // Llenar los campos con los datos del registro actual
        }
        private void mostrarDatosMaterias()
        {
            if (miTabla.Rows.Count > 0)
            {
                txtCodigoMaterias.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtNombreMaterias.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtUvMaterias.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                lblRegistrosMaterias.Text = (posicion + 1) + " de " + miTabla.Rows.Count; // Mostrar la posición actual
            }
        }
        private void btnSiguienteMaterias_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosMaterias(); // Actualizar los campos con el nuevo registro
            }
            else
            {
                MessageBox.Show("Esta en el último registro", "Navegación de materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorMaterias_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosMaterias(); // Actualizar los campos con el nuevo registro
            }
            else
            {
                MessageBox.Show("Esta en el primer registro", "Navegación de materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrimeroMaterias_Click(object sender, EventArgs e)
        {
            posicion = 0; // Primer registro
            mostrarDatosMaterias();
        }

        private void btnUltimoMaterias_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1; // Último registro
            mostrarDatosMaterias();
        }
        private void btnNuevoMaterias_Click(object sender, EventArgs e)
        {
            if (btnNuevoMaterias.Text == "Nuevo")
            {
                btnNuevoMaterias.Text = "Guardar";
                btnModificarMaterias.Text = "Cancelar";
                accion = "nuevo";             // Establecer la acción a "nuevo"
                estadoControles(true);        // Habilitar los controles de edición
                limpiarCajas();               // Limpiar las cajas de texto
            }
            else
            {
                // Guardar el nuevo registro o modificar el existente
                String[] materias = {
            accion, miTabla.Rows[posicion].ItemArray[0].ToString(),
            txtCodigoMaterias.Text, txtNombreMaterias.Text, txtUvMaterias.Text
        };
                String respuesta = objConexion.administrarMaterias(materias);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de materias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnNuevoMaterias.Text = "Nuevo";
                    btnModificarMaterias.Text = "Modificar";
                    estadoControles(false);    // Deshabilitar los controles de edición
                    actualizarDs();            // Refrescar los datos
                }
            }
        }
        private void btnEliminarMaterias_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreMaterias.Text.Trim() + "?", "Eliminar materias", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] materias = { "eliminar", miTabla.Rows[posicion].ItemArray[0].ToString() };
                String respuesta = objConexion.administrarMaterias(materias);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de materias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();            // Refrescar los datos
                    mostrarDatosMaterias();
                }
            }
        }
        private void txtBuscarMaterias_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscarMaterias.Text); // Filtrar los datos según el texto ingresado
            seleccionarMateria();                 // Seleccionar el registro actual basado en la búsqueda
        }

        private void filtrarDatos(String filtro)
        {
            DataView dv = miTabla.DefaultView;
            dv.RowFilter = "codigo like '%" + filtro + "%' OR nombre like '%" + filtro + "%'";
            grdDatosMaterias.DataSource = dv;     // Actualizar el DataGridView con los resultados filtrados
        }

    }
}
