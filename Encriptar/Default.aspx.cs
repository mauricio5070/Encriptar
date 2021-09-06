using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Encriptar
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void btnEncriptar_Click(object sender, EventArgs e)
        {
            txtencriptado.Text = encriptar(txtOriginal.Text,"41@dgHa6yxsHafa4");
        }


        public string encriptar(string dato, string llave)
        {
            byte[] keyArray = Encoding.UTF8.GetBytes(llave);
            byte[] encriptar = Encoding.UTF8.GetBytes(dato);

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] result = cTransform.TransformFinalBlock(encriptar,0,encriptar.Length);
            tdes.Clear();

            return Convert.ToBase64String(result, 0, result.Length);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
   
        }
    }
}