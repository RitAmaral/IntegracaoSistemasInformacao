using System;
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

            /* 1º criar 3 pastas, uma para controller, outra para model e outra para view. Depois criar, em cada pasta criada, uma classe
            model, view e controller, respetivamente.
            */
            //---------------------------------------Colaborador------------------------------------

            //Criar model
            ColaboradorModel colabmodel = new ColaboradorModel();
            //Criar view
            ColaboradorView colabview = new ColaboradorView();
            //Criar controller
            ColaboradorController colabcontroller = new ColaboradorController(colabmodel, colabview);

            //Exibição dos detalhes do colaborador adicionado através do método criado no ColaboradorModel (ObterDetalhesColab)
            colabcontroller.MostrarDetalhesColab(1);
            Console.WriteLine();

            //Adicionar colaboradores à lista de colaboradores
            colabcontroller.AddColaborador("Motorista", 20, "Tomás Rodrigues", "Masculino", "Braga", DateOnly.Parse("12/05/1980"), true, 1000, 13415625, 231562784, 966126621, "tomas@gmail.com");
            colabcontroller.AddColaborador("Enfermeira", 21, "Maria Santos", "Feminino", "Braga", DateOnly.Parse("22/08/1987"), false, 1500, 18423790, 225432790, 936125512, "maria@gmail.com");
            
            //Exibição dos detalhes dos colaboradores da lista, através do método criado no ColaboradorController
            colabcontroller.MostrarColaborador(0);
            Console.WriteLine();
            colabcontroller.MostrarColaborador(1);
            Console.WriteLine();

            //Se quiser remover alguém da lista de colaboradores:
            //colabcontroller.RemoveColaborador(1); 
            //Console.ReadLine();
            

            //---------------------------------------Médico------------------------------------

            //Criar model
            MedicoModel medmodel = new MedicoModel();
            //Criar view
            MedicoView medview = new MedicoView();
            //Criar controller
            MedicoController med22 = new MedicoController(medmodel, medview);

            //Exibição dos detalhes do Médico através do método criado no MedicoController
            med22.MostrarDetalhes(1); //inclui o nome de utilizador e password para poder fazer o login em baixo.
            Console.WriteLine();

            //Exibição das mensagens de login e logout:
            if (med22.Login(1) == true)
            {
                med22.GetPassword(1); //mostra a password do med22.
                if (med22.SetPassword(1) == true) //a password não está a ser alterada.
                {
                    med22.GetPassword(1); //isto foi usado para ver a nova password, no entanto diz sempre a password antiga, por isso o método SetPassword não está a funcionar.
                    med22.Login(1); //isto é usado para ver que realmente a nova password não funciona.
                    Console.WriteLine();
                    med22.Logout(1);
                }
                else
                {
                    Console.WriteLine("Password não foi alterada.");
                    Console.WriteLine();
                    med22.Logout(1);
                }

            }

        }
    }
}