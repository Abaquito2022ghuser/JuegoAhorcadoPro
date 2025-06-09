using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace AhorcadoBetaC01
{
    class Conexion
    {
        private static SQLiteConnection conexion;
        public static SQLiteConnection ObtenerConexion()
        {
            if (conexion == null)
            {
                conexion = new SQLiteConnection(" Data Source=AhorcadoBeta.db3;Version=3;");
                conexion.Open();

            }
            return conexion;

        }
    }
}
