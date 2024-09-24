using DB_lez03_dal_refactor.classes;

namespace DB_lez03_dal_refactor
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(DipendenteDAO.GetInstance().FindById(1));
            Console.WriteLine(DipendenteDAO.GetInstance().FindById(2));
            Console.WriteLine(DipendenteDAO.GetInstance().FindById(3));

            Console.WriteLine(AssetDAO.GetInstance().FindById(4));  
        }
    }
}
