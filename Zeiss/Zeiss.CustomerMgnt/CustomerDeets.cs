using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeiss.BL;

namespace Zeiss.CustomerMgnt
{
    internal class CustomerDeets
    {
        string CustID;
        string FirstName;
        string LastName;
        DateTime DOB;
        string Mobile;


        public void GetCustomerByMobileNum(string mobileNo)
        {
            Console.WriteLine("Fetching details for Phone number: " + mobileNo.ToString() + ":");
            CustBL CBL = new CustBL();
            CBL = CBL.GetCustomerDetails(mobileNo);
            Console.WriteLine(CBL.custID + " " + CBL.FirstName + " " + CBL.LastName);
            Console.WriteLine("Date of Birth : " + CBL.DOB);

        }
    }
}
