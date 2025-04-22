namespace MyCommonLib
{
    public class TestMethod
    {
        public int Add(int a, int b) => a + b;
        public string GetString(string str) => $"Hello {str}";
        public string GetAddress(string address) => $"Address: {address}";
        public string GetAgeByYear(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            // 若生日還沒過，要減一歲
            if (birthDate.Date > today.AddYears(-age)) age--;

            return $"You are {age} years old.";
        }
    }
}

