using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03MVC.MVC.Model;
using Task03MVC.MVC.View;

namespace Task03MVC.MVC.Controller
{
    internal class JarController //Controller/Controlador
    {
        //Propriedades
        private JarModel _model;
        private JarView _view;
        //Construtor
        public JarController(JarModel model, JarView view)
        {
            _model = model;
            _view = view;
        }
        //Métodos
        public void MostrarDetalhes(int details)
        {
            JarModel jar = _model.ObterDetalhes(details);
            _view.EscreverDetalhesJar(jar.Name, jar.BirthDate, jar.Nationality, jar.Gender);
        }
    }
}
