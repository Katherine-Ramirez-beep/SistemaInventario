using System;
using System.Drawing;
using System.Windows.Forms;
using SistemaInventario.AccesoDatos;
using SistemaInventario.Entidades;
using SistemaInventario.LogicaNegocio;

namespace SistemaInventario.Presentacion
{
    public partial class Form1 : Form
    {
        private readonly CategoriaServicio _categoriaServicio;
        private int _catSeleccionadaId = 0;

        public Form1()
        {
            InitializeComponent();

            // Inyección de servicios
            var catRepo = new CategoriaRepositorio();
            var prodRepo = new ProductoRepositorio();
            _categoriaServicio = new CategoriaServicio(catRepo, prodRepo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarPanel(pnlDashboard, btnNavDashboard, "Panel de Control");
        }

        // ==========================================
        // NAVEGACIÓN ENTRE PANELES VISTA
        // ==========================================
        private void MostrarPanel(Panel panelAMostrar, Button botonActivo, string titulo)
        {
            // Ocultar todos los paneles
            pnlDashboard.Visible = false;
            pnlCategorias.Visible = false;

            // Restablecer colores de botones de navegación
            ResetearBotonesNav();

            // Mostrar el panel activo
            panelAMostrar.Visible = true;
            panelAMostrar.BringToFront();

            // Resaltar botón activo
            botonActivo.BackColor = Color.FromArgb(30, 41, 59);
            botonActivo.ForeColor = Color.White;

            lblTituloModulo.Text = titulo;
        }

        private void ResetearBotonesNav()
        {
            Color textoNormal = Color.FromArgb(203, 213, 225);
            Color bgSidebar = Color.FromArgb(15, 23, 42);

            btnNavDashboard.BackColor = bgSidebar;
            btnNavDashboard.ForeColor = textoNormal;

            btnNavCategorias.BackColor = bgSidebar;
            btnNavCategorias.ForeColor = textoNormal;

            btnNavSuplidores.BackColor = bgSidebar;
            btnNavSuplidores.ForeColor = textoNormal;

            btnNavProductos.BackColor = bgSidebar;
            btnNavProductos.ForeColor = textoNormal;

            btnNavPapelera.BackColor = bgSidebar;
            btnNavPapelera.ForeColor = Color.FromArgb(248, 113, 113);

            btnNavReportes.BackColor = bgSidebar;
            btnNavReportes.ForeColor = textoNormal;
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            MostrarPanel(pnlDashboard, btnNavDashboard, "Panel de Control / Dashboard");
        }

        private void btnNavCategorias_Click(object sender, EventArgs e)
        {
            MostrarPanel(pnlCategorias, btnNavCategorias, "Gestión de Categorías");
            CargarGridCategorias();
        }

        private void btnNavSuplidores_Click(object sender, EventArgs e)
        {
            ResetearBotonesNav();
            btnNavSuplidores.BackColor = Color.FromArgb(30, 41, 59);
            lblTituloModulo.Text = "Gestión de Suplidores";
        }

        private void btnNavProductos_Click(object sender, EventArgs e)
        {
            ResetearBotonesNav();
            btnNavProductos.BackColor = Color.FromArgb(30, 41, 59);
            lblTituloModulo.Text = "Gestión de Productos";
        }

        private void btnNavPapelera_Click(object sender, EventArgs e)
        {
            ResetearBotonesNav();
            btnNavPapelera.BackColor = Color.FromArgb(30, 41, 59);
            lblTituloModulo.Text = "Papelera de Reciclaje";
        }

        private void btnNavReportes_Click(object sender, EventArgs e)
        {
            ResetearBotonesNav();
            btnNavReportes.BackColor = Color.FromArgb(30, 41, 59);
            lblTituloModulo.Text = "Consultas Avanzadas y LINQ";
        }

        // ==========================================
        // LÓGICA MÓDULO CATEGORÍAS
        // ==========================================
        private void CargarGridCategorias()
        {
            try
            {
                dgvCategorias.DataSource = null;
                dgvCategorias.DataSource = _categoriaServicio.ObtenerTodos();

                if (dgvCategorias.Columns["Activo"] != null)
                    dgvCategorias.Columns["Activo"].Visible = false;

                if (dgvCategorias.Columns["FechaCreacion"] != null)
                    dgvCategorias.Columns["FechaCreacion"].HeaderText = "Fecha Registro";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarCat_Click(object sender, EventArgs e)
        {
            var cat = new Categorias
            {
                Id = _catSeleccionadaId,
                Nombre = txtNombreCat.Text.Trim(),
                Descripcion = txtDescCat.Text.Trim()
            };

            if (_categoriaServicio.Guardar(cat, out string msj))
            {
                MessageBox.Show("Categoría guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormCat();
                CargarGridCategorias();
            }
            else
            {
                MessageBox.Show(msj, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            if (_catSeleccionadaId <= 0)
            {
                MessageBox.Show("Seleccione una categoría primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea enviar esta categoría a la papelera?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_categoriaServicio.EliminarLogico(_catSeleccionadaId, out string msj))
                {
                    MessageBox.Show("Categoría eliminada (Soft-Delete).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormCat();
                    CargarGridCategorias();
                }
                else
                {
                    MessageBox.Show(msj, "No se pudo eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null && dgvCategorias.CurrentRow.DataBoundItem is Categorias c)
            {
                _catSeleccionadaId = c.Id;
                txtNombreCat.Text = c.Nombre;
                txtDescCat.Text = c.Descripcion;
            }
        }

        private void btnLimpiarCat_Click(object sender, EventArgs e)
        {
            LimpiarFormCat();
        }

        private void LimpiarFormCat()
        {
            _catSeleccionadaId = 0;
            txtNombreCat.Clear();
            txtDescCat.Clear();
            txtNombreCat.Focus();
        }
    }
}