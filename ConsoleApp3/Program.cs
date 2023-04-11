using ConsoleApp3.School;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Murad", "Mecidov", 21,true) ;
            Student student2 = new Student("Al", "Novruzov", 22,false);
            Student student3 = new Student("Elsad", "Yaqubov", 19,true);
            Group group = new Group();
            group.Add(student3);
            group.GetAll();
            group.GetOnlineStudents();
            group.GetOfflineStudents();

        }
    }
}