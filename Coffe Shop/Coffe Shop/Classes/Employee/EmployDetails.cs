namespace Coffe_Shop.Classes.Employee
{
    public class EmployDetails
    {
        public static Label lblNameEmployee;
        private static int employId;
        private static string employName;
        private static string employEmail;
        private static int employIdCard;
        private static int empRoli;
        private static bool isInSystem = false;

        public static void SetValues(int EmpId, string EmpName, string EmpEmail, int empIdCard, int Roli)
        {
            employId = EmpId;
            employName = EmpName;
            employEmail = EmpEmail;
            employIdCard = empIdCard;
            empRoli = Roli;

            lblNameEmployee.Text = "Puntori: " + EmpName;

            isInSystem = true;
        }
        public static void GetOut()
        {
            employId = -1;
            employName = "";
            employEmail = "";
            employIdCard = -1;

            lblNameEmployee.Text = "Puntori: ";

            isInSystem = false;
        }


        public static int GetId { get => employId; }
        public static int GetIdCard { get => employIdCard; }
        public static int GetRoli { get => empRoli; }
        public static string EmpName { get => employName; }
        public static string EmpEmail { get => employEmail; }
        public static bool inSystem { get => isInSystem; }

    }
}
