using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datalayer;

namespace applicationLayer1
{
    public class Class1
    {
    }
    public class applayer1
    {
        datalayer1 d = new datalayer1();
        
        public void insertrecord(int bookid, string bookname , string bookdomain , int bookprice)
        {
            d.add(bookid, bookname, bookdomain, bookprice);
        }
        public void deleterecord(int bookid) {  d.delete(bookid); }

        public DataTable getrecords()
        {
            return d.getall();
        }

        public void updaterecord(int bookid, string bookname ,string bookdomain , int bookprice)
        {
            d.update(bookid, bookname, bookdomain, bookprice);
        }
    }
}
