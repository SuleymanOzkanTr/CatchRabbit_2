using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;

namespace CatchRabbit_2
{
    internal class Sqlbaglantisi
    {
        public SqlConnection baglanti()
            {
            SqlConnection baglan = new SqlConnection("Data Source=SOLOMON;Initial Catalog=RabbitGameData;Integrated Security=True");
            baglan.Open();
            return baglan;
    }
}
}
