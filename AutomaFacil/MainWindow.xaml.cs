using AutomaFacil.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutomaFacil
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Estado[] estados = new Estado[] {
                new Estado(estado_1, "q0"),
                new Estado(estado_2, "q1"),
                new Estado(estado_3, "q2"),
                new Estado(estado_4, "q3")
            };

            Seta[] setas = new Seta[]
            {
                new Seta(estados[0], estados[1]),
                new Seta(estados[1], estados[2]),
                new Seta(estados[2], estados[3])
            };

            estados[0].ativar("q1");
            estados[1].ativar("q2");
            setas[0].ativar();
            setas[0].ativarDireita("a");
            setas[0].ativarEsquerda("b");
            estados[0].ativarSelf("b");
            estados[1].ativarSelf("a");
            estados[1].tornarFinal();
            estados[1].tornarVermelho();
            estados[3].ativar("qf");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Estado[] estados = new Estado[] {
                new Estado(estado_1, "q0"),
                new Estado(estado_2, "q1"),
                new Estado(estado_3, "q2"),
                new Estado(estado_4, "q3")
            };

            Seta[] setas = new Seta[]
            {
                new Seta(estados[0], estados[1]),
                new Seta(estados[1], estados[2]),
                new Seta(estados[2], estados[3])
            };

            estados[0].ativar("q1");
            Thread.Sleep(1000);
            setas[0].ativarDireita("a");
            Thread.Sleep(1000);
            estados[0].ativarSelf("b");
            Thread.Sleep(1000);
            estados[1].ativar("qf");
            Thread.Sleep(1000);
            estados[1].tornarFinal();
            Thread.Sleep(1000);
        }
    }
}
