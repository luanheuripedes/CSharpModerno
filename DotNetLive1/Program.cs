using DotNetLive1.Entities;

namespace DotNetLive1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Luan", "Heurípedes", new DateTime(1997, 02, 24), 7.5m,
                new Address("Rua Sebastião Martins Gomes", "MG", "36900-000", "Manhuaçu"), StudentStatus.Active);

            var student2 = new Student
            {
                FirstName = "Heurípedes",
                LastName = "Luan",
                DateOfBirth = new DateTime(1997, 02, 24),
                Score = 7.5m,
                Address = new Address
                {
                    Street = "Rua Sebastião Martins Gomes",
                    State = "MG",
                    ZipCode = "36900-000",
                    City = "Manhuaçu"
                },
            };

            var students = new List<Student> { student1, student2 };

            //Tuplas
            student1.Update((3, new Address("Centro", "Alegre", "ES", "7500")));

            var info = student1.GetInfo();
            var (Nome, Score, Address) = student1.GetInfo();
            (string name, decimal score, string address) = student1.GetInfo();
            var nonNamedTuple = student1.GetInfoNonNamed();

            Console.WriteLine($"Name: {info.Name} - Score: {info.Score} - Address: {info.Address}");
            Console.WriteLine($"Name: {Nome} - Score: {Score} - Address: {Address}");
            Console.WriteLine($"Name: {name} - Score: {score} - Address: {address}");
            Console.WriteLine($"Name: {nonNamedTuple.Item1} - Score: {nonNamedTuple.Item2}- Address: {nonNamedTuple.Item3}");

            List<(string firstName, decimal? score)> studentTuples = students.Select(s => (s.FirstName, s.Score)).ToList();

            foreach (var (firstname, nota) in studentTuples)
            {
                Console.WriteLine($"{firstname}, {nota}");
            }


            //Records


            //Null Reference Types
            student1.SetLastName(student1.LastName);
            student1.SetLastName(student2.LastName);

            var firstName1 = student1.FirstName.Length;
            var lastName1 = student1.FirstName.Length;
            var lastName2 = student2.FirstName.Length;

            Student? luan = students.SingleOrDefault(s => s.FirstName == "Luan");
            Console.WriteLine(value: luan.FirstName);

            student1.PrintInfo();
           
        }
    }
}