using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;


namespace Proyecto1
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();


            // Establece la cadena de conexión a tu base de datos
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Samsung\\Desktop\\Proyecto\\Proyecto1\\Proyecto1\\BasedeDatos.mdf;Integrated Security=True";

            // Crea una consulta SQL para obtener los datos de la tabla
            string query = "SELECT * FROM Mujeres";

                // Crea una conexión a la base de datos y ejecuta la consulta
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Asigna los resultados al control DataGrid
                    myDataGrid.ItemsSource = dataTable.DefaultView;
                }
            }
        }
    }

