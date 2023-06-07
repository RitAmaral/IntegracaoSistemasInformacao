using Task03MVC.MVC.Controller;
using Task03MVC.MVC.Model;
using Task03MVC.MVC.View;

namespace Task03MVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------------Padrão de Arquitetura MVC----------------------------*/

            /*1º criar 3 pastas, uma para controller, outra para model e outra para view. Depois criar, em cada pasta criada, uma classe
            model, view e controller, respetivamente.
            */

            //Criar model
            MedicoModel model = new MedicoModel();
            //Criar view
            MedicoView view = new MedicoView();
            //Criar controller
            MedicoController med22 = new MedicoController(model, view);

            //Exibição dos detalhes do Médico através do método criado no controller
            med22.MostrarDetalhes(1);
            Console.WriteLine();

            //Exibição das mensagens de login e logout:
            med22.Login(1);
            Console.WriteLine();

            med22.Logout(1);
        }
    }
}