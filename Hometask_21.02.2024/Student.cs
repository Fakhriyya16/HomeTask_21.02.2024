
namespace Hometask_21._02._2024
{
    class Student
    {
        public string name;
        public string surname = "XXX";
        public int age;
        public string adress;
        public string phone = "123456789";

        public string GetFullName()
        {
            return name + " " + surname;
        }

        public string GetFullDatas()
        {
            string fullData = $"Name: {name}, Surname: {surname}, Age: {age}, Adress: {adress}, Phone: {phone}";
            return fullData;
        }
    }
}
