using CsvHelper;
using Microsoft.VisualBasic.FileIO;
using System.Collections;
using System.IO;

namespace HT_6.Framework.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }




        public static User User1()
        {
            TextFieldParser tfp = new TextFieldParser("table.csv");
            string x;
            tfp.TextFieldType = FieldType.Delimited;
            tfp.SetDelimiters(",");
            string[] fields;
            fields = tfp.ReadFields();

            return new User { Username = fields[0], Password = fields[1], FirstName = fields[2], LastName = fields[3] };
        }
       
    }
}