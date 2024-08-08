namespace Coffe_Shop.Classes.Profile
{
    public static class CoffeProfileValues
    {
        private static int profileId;
        private static string profileName;
        private static string profileAddress;
        private static string email;
        private static string phone;
        private static byte[] logo;

        public static void SetValues(int id, string name, string address, string emailAddress, string phoneNumber, byte[] lg)
        {
            profileId = id;
            profileName = name;
            profileAddress = address;
            email = emailAddress;
            phone = phoneNumber;
            logo = lg;
        }

        public static int GetId { get => profileId; }
        public static string Name { get => profileName; }
        public static string Address { get => profileAddress; }
        public static string Email { get => email; }
        public static string Phone { get => phone; }
        public static byte[] Logo { get => logo; }
    }
}
