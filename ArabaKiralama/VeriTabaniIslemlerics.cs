using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaKiralama
{
    class VeriTabaniIslemleri
    {
        string arabaBaglantiCumlesi = ConfigurationManager.ConnectionStrings["arabaBaglantiCumlesi"].ConnectionString;

        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection(arabaBaglantiCumlesi);
            SqlConnection.ClearPool(baglanti);
            baglanti.Open();
            return baglanti;
        }

    }
}
