namespace Zeiss.DL
{
    public class CustDL
    {
        public string custID;
        public string Mobile;
        public string FirstName;
        public string LastName;
        public string DOB;

        public CustDL GetCustomer(string mobileNo)
        {
            CustDL endUser = new CustDL();
            endUser.custID = "C100001";
            endUser.FirstName = "Maccy";
            endUser.LastName = "testval";
            endUser.DOB = "05-07-2002";
            endUser.Mobile = "1111111111";

            CustDL endUser2 = new CustDL();
            endUser2.custID = "C100002";
            endUser2.FirstName = "Ram";
            endUser2.LastName = "Singh";
            endUser2.DOB = "09-09-2001";
            endUser2.Mobile = "2222222222";

            return (endUser.Mobile==mobileNo)?endUser:endUser2;
        }
    }
}