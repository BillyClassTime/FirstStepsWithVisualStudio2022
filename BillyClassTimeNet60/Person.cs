//record struct Person

namespace Model
{
    struct Person
    {
        //public Person()
        //{
        //FirstName = "Miguel";
        //LastName = "";
        //}
        public string FirstName { get; init; } = "Miguel";
        public string LastName { get; init; } = "Vanegas";

        public void WriteToFile(string filePath) => File.WriteAllText(filePath, ToString());
    }
}
