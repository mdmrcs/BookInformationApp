using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookInformationApp.Model;

namespace BookInformationApp.DAL
{
    class BookGateway
    {
        public int Insert(Books book)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["BookInfoCOnString"].ConnectionString;

            
            string query = "Insert into Book_details values('" + aBook.Name + "', '" + aBook.ISbn + "','" + aBook.Author + "')";

            SqlConnection aSqlConnection = new SqlConnection(connectionstring);

            SqlCommand aSqlCommand = new SqlCommand(query, aSqlConnection);


            aSqlConnection.Open();
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();


        }

    }
}
