using System;
using System.Windows.Forms;
using LIBENTIDAD;

namespace AdminBuhito
{
    public partial class Form1 : Form
    {
        private Tb_ProcesosBE objEntidad;
        private TipoProceso tipoProceso;
        enum TipoProceso
        {
            DIAS_SEMANA = 1,
            FECHA_ESPECIFICA = 2,
            NUM_DIAS = 3,
            NUM_MINUTOS = 4
        }
        public Form1()
        {
            InitializeComponent();
            CrearValoresPorDefecto();
        }

        private void rbtDiasSemana_CheckedChanged(object sender, EventArgs e)
        {
            tipoProceso = TipoProceso.DIAS_SEMANA;
            MostrarControles();
        }

        private void rbtFechaEspecifico_CheckedChanged(object sender, EventArgs e)
        {
            tipoProceso = TipoProceso.FECHA_ESPECIFICA;
            MostrarControles();
        }

        private void rbtNDias_CheckedChanged(object sender, EventArgs e)
        {
            tipoProceso = TipoProceso.NUM_DIAS;
            MostrarControles();
        }

        private void rbtNMinutos_CheckedChanged(object sender, EventArgs e)
        {
            tipoProceso = TipoProceso.NUM_MINUTOS;
            MostrarControles();
        }

        void MostrarControles()
        {
            foreach (Control ctrl in groupPropiedades.Controls)
            {
                ctrl.Visible = false;
                string tagBusqueda = "";
                switch (tipoProceso)
                {
                    case TipoProceso.DIAS_SEMANA:
                        //Cuando seleccionamos "días de semana"
                        tagBusqueda = "DIAS_SEMANA";
                        break;
                    case TipoProceso.FECHA_ESPECIFICA:
                        tagBusqueda = "FECHA_ESPECIFICA";
                        break;
                    case TipoProceso.NUM_DIAS:
                        tagBusqueda = "NUM_DIAS";
                        break;
                    case TipoProceso.NUM_MINUTOS:
                        tagBusqueda = "NUM_MINUTOS";
                        break;
                }
                
                if (ctrl.Tag.ToString().Contains(tagBusqueda))
                {
                    ctrl.Visible = true;
                }
            }
        }

        private void sbNuevo_Click(object sender, EventArgs e)
        {
            sbGuardar.Enabled = true; 
            sbCancelar.Enabled = true;

            sbNuevo.Enabled = false;
            sbEditar.Enabled = false;
            sbEliminar.Enabled = false;

            groupTipoProceso.Enabled = true;
            groupGenerales.Enabled = true;
            groupPropiedades.Enabled = true;
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea descartar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CrearValoresPorDefecto();
            }
        }

        void CrearValoresPorDefecto()
        {
            objEntidad = new Tb_ProcesosBE();
            tipoProceso = TipoProceso.DIAS_SEMANA;
            dtpHora.Value = Convert.ToDateTime("00:00:00");

            sbNuevo.Enabled = true;
            sbEditar.Enabled = false;
            sbEliminar.Enabled = false;
            sbCancelar.Enabled = false;
            sbGuardar.Enabled = false;

            rbtDiasSemana.Checked = true;

            groupTipoProceso.Enabled = false;
            groupGenerales.Enabled = false;
            groupPropiedades.Enabled = false;
        }

        private void sbGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarGuardar())
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Guardar();
                    CrearValoresPorDefecto();
                }
            }
        }

        private void chkTodosLosDias_CheckedChanged(object sender, EventArgs e)
        {
            bool valueCheck = (sender as CheckBox).Checked;
            chkLunes.Checked = valueCheck;
            chkLunes.Enabled = !valueCheck;

            chkMartes.Checked = valueCheck;
            chkMartes.Enabled = !valueCheck;

            chkMiercoles.Checked = valueCheck;
            chkMiercoles.Enabled = !valueCheck;

            chkJueves.Checked = valueCheck;
            chkJueves.Enabled = !valueCheck;

            chkViernes.Checked = valueCheck;
            chkViernes.Enabled = !valueCheck;

            chkSabado.Checked = valueCheck;
            chkSabado.Enabled = !valueCheck;

            chkDomingo.Checked = valueCheck;
            chkDomingo.Enabled = !valueCheck;
        }

        private bool ValidarGuardar()
        {
            return true;
        }

        private void Guardar()
        {
            //Llenamos el objeto de acorde a la opción

        }
    }
}
