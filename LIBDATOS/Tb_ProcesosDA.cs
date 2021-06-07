using LIBENTIDAD;
using System.Data.SqlClient;
using System.Data;
using System;

namespace LIBDATOS
{
    public class Tb_ProcesosDA
    {
        SqlConnection connection;

        public Tb_ProcesosDA()
        {
            connection = new SqlConnection(ConexionDA.GetConexion);
        }

        public bool Insert(Tb_ProcesosBE entidad)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Tb_Proceso_INSERT", connection);

                cmd.Parameters.Add("@ProcesoName", SqlDbType.VarChar, 30).Value = entidad.ProcesoName;
                cmd.Parameters.Add("@ProcesoDescription", SqlDbType.VarChar, 150).Value = entidad.ProcesoDescription;
                cmd.Parameters.Add("@FlagActivo", SqlDbType.Int).Value = entidad.FlagActivo;
                cmd.Parameters.Add("@TipoProcesoID", SqlDbType.Int).Value = entidad.TipoProcesoID;
                cmd.Parameters.Add("@DiasSemana", SqlDbType.VarChar, 100).Value = entidad.DiasSemana;
                cmd.Parameters.Add("@HoraEjecucion", SqlDbType.Timestamp).Value = entidad.HoraEjecucion;
                cmd.Parameters.Add("@FechaEjecucion", SqlDbType.DateTime).Value = entidad.FechaEjecucion;
                cmd.Parameters.Add("@NumDias", SqlDbType.Int).Value = entidad.NumDias;
                cmd.Parameters.Add("@NumMinutos", SqlDbType.Int).Value = entidad.NumMinutos;

                connection.Open();
                int exec = cmd.ExecuteNonQuery();

                return exec > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}