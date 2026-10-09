using System.ComponentModel.DataAnnotations;
using Week3_Practical;

class Program
{
    public static void Main(string[] args)
    { 
        Student student2 = new Student("John Doe", 18, 0);

        student2.GetOlder();
        student2.Display();

    }
}
