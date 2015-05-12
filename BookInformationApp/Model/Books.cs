using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInformationApp.Model
{
    class Books
    {
        private int serial_No;
        private string name;
        private string iSBN;
        private string author;
        private string author_Id;
        private string address;

        public int SerialNo
        {
            get { return serial_No; }
            set { serial_No = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ISbn
        {
            get { return iSBN; }
            set { iSBN = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string AuthorId
        {
            get { return author_Id; }
            set { author_Id = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        //public string Show()
        //{
        //    return ; 
        //}
    }
}
