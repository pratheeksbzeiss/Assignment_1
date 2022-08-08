using Zeiss.DL;

namespace Zeiss.BL
{
    public class CustBL
    {
        public string custID;
        public string FirstName;
        public string LastName;
        public string DOB;

        public CustBL GetCustomerDetails(string MobileNo)
        {
            CustDL CD1 = new CustDL();
            CD1 = CD1.GetCustomer(MobileNo);
            CustBL CB1 = new CustBL();
            CB1.custID = CD1.custID;
            CB1.FirstName = CD1.FirstName;
            CB1.LastName = CD1.LastName;
            CB1.DOB = CD1.DOB;

            return CB1;

        }
    }
}