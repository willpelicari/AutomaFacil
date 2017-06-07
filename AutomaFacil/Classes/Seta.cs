using AutomaFacil.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace AutomaFacil.Classes
{
    class Seta
    {
        private bool esquerdaAtivada = false;
        private bool direitaAtivada = false;

        #region Propriedades
            private Image imagem { get; set; }
            private bool ativo { get; set; }
            private bool esquerda {
                get { return esquerdaAtivada; }
                set {
                    esquerdaAtivada = value;
                    imagem.Visibility = Visibility.Visible;    

                    if (esquerdaAtivada && direitaAtivada)
                        imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/seta_vai_volta.png"));
                    else
                        if (esquerdaAtivada)
                        imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/seta_volta.png"));
                    else if (direitaAtivada)
                        imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/seta_vai.png"));
                    else
                        imagem.Visibility = Visibility.Hidden;
                }
            }
            private string txtEsquerda {
                get {
                    var objeto = (TextBlock)Application.Current.MainWindow.FindName(string.Format("{0}_esquerda", imagem.Name));
                    return objeto.Text;
                } set {
                    var objeto = (TextBlock)Application.Current.MainWindow.FindName(string.Format("{0}_esquerda", imagem.Name));
                    if (value == "")
                        objeto.Visibility = Visibility.Hidden;
                    else
                    {
                        objeto.Visibility = Visibility.Visible;
                        objeto.Text = value;
                    }
                }
            }
            private bool direita
            {
                get { return direitaAtivada; }
                set
                {
                    imagem.Visibility = Visibility.Visible;
                    direitaAtivada = value;

                    if (esquerdaAtivada && direitaAtivada)
                        imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/seta_vai_volta.png"));
                    else
                        if (esquerdaAtivada)
                        imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/seta_volta.png"));
                    else if (direitaAtivada)
                        imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/seta_vai.png"));
                    else
                        imagem.Visibility = Visibility.Hidden;
                }
            }
            private string txtDireita
            {
                get
                {
                    var objeto = (TextBlock)Application.Current.MainWindow.FindName(string.Format("{0}_direita", imagem.Name));
                    return objeto.Text;
                }
                set
                {
                    var objeto = (TextBlock)Application.Current.MainWindow.FindName(string.Format("{0}_direita", imagem.Name));
                    if (value == "")
                        objeto.Visibility = Visibility.Hidden;
                    else
                    {
                        objeto.Visibility = Visibility.Visible;
                        objeto.Text = value;
                    }
                }
            }
        #endregion

        #region Construtor
        public Seta(Estado estado1, Estado estado2)
        {
            imagem = (Image) Application.Current.MainWindow.FindName(string.Format("{0}_{1}", estado1.obterNome(), estado2.obterNome()));
            ocultar();
        }
        #endregion

        #region Métodos públicos
        public void ativarEsquerda(string texto) { this.esquerda = true; this.txtEsquerda = texto; }
            public void desativarEsquerda() { this.esquerda = false; this.txtEsquerda = ""; }
            public void ativarDireita(string texto) { this.direita = true; this.txtDireita = texto; }
            public void desativarDireita() { this.direita = false; this.txtDireita = ""; }
            public void ocultar()
            {
                this.ativo = false;
                imagem.Visibility = Visibility.Hidden;
                txtEsquerda = "";
                txtDireita = "";
            }
            public void ativar()
            {
                this.ativo = true;
                imagem.Visibility = Visibility.Visible;
            }
        #endregion
    }
}
