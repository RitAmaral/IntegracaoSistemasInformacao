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
            JarModel model = new JarModel();
            //Criar view
            JarView view = new JarView();
            //Criar controller
            JarController controller = new JarController(model, view);

            //Exibição dos detalhes do Jar através do método criado no controller
            controller.MostrarDetalhes(1);


        }
    }
}