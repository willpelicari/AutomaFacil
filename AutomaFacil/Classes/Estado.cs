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
    class Estado
    {
        private bool finalAtivado = false;
        private bool selfAtivado = false;
        private string corAtiva = "azul";

        #region Propriedades
            private Image imagem { get; set; }
            private bool ativo { get; set; }
            private bool self {
                get {
                    return selfAtivado;
                }
                set {
                    if (value == true)
                    {
                        if (corAtiva == "azul")
                            if (final)
                                imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/azul_seta_self_final.png"));
                            else
                                imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/azul_seta_self.png"));
                        else
                            if (final)
                            imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/verm_seta_self_final.png"));
                        else
                            imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/verm_seta_self.png"));
                    }
                    else
                    {
                        if (corAtiva == "azul")
                            if (final)
                                imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/azul_vazio_final.png"));
                            else
                                imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/azul_vazio.png"));
                        else
                            if (final)
                            imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/verm_vazio_final.png"));
                        else
                            imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/verm_vazio.png"));
                    }
                selfAtivado = value;
                }
            }
            private string txtSelf
                {
                    get
                    {
                        var objeto = (TextBlock)Application.Current.MainWindow.FindName(string.Format("{0}_texto_self", imagem.Name));
                        return objeto.Text;
                    }
                    set
                    {
                        var objeto = (TextBlock) Application.Current.MainWindow.FindName(string.Format("{0}_texto_self", imagem.Name));
                        if(value == "")
                            objeto.Visibility = Visibility.Hidden;
                        else
                        {
                            objeto.Visibility = Visibility.Visible;
                            objeto.Text = value;
                        }
                    }
                }
            private bool final {
                get
                {
                    return finalAtivado;
                }
                set {
                    if(value == true)
                        if(cor == "azul")
                            if(self)
                                imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/azul_seta_self_final.png"));
                            else
                                imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/azul_vazio_final.png"));
                        else
                            if (self)
                                imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/verm_seta_self_final.png"));
                            else
                                imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/verm_vazio_final.png"));
                    else
                        if (cor == "azul")
                            if (self)
                                imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/azul_seta_self.png"));
                            else
                                imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/azul_vazio.png"));
                        else
                            if (self)
                                imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/verm_seta_self.png"));
                            else
                                imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/verm_vazio.png"));
                    finalAtivado = value;
                }
            }
            private string valor
                {
                    get
                    {
                        var objeto = (TextBlock)Application.Current.MainWindow.FindName(string.Format("{0}_texto", imagem.Name));
                        return objeto.Text;
                    }
                    set
                    {
                        var objeto = (TextBlock)Application.Current.MainWindow.FindName(string.Format("{0}_texto", imagem.Name));
                        if (value == "")
                            objeto.Visibility = Visibility.Hidden;
                        else
                        {
                            objeto.Visibility = Visibility.Visible;
                            objeto.Text = value;
                        }
                    }
                }
            private string cor
                {
                    get
                    {
                        return corAtiva;
                    }
                    set
                    {
                        if(value == "azul")
                        {
                            if (self)
                                if(final)
                                    imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/azul_seta_self_final.png"));
                                else
                                    imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/azul_seta_self.png"));
                            else
                                if (final)
                                    imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/azul_vazio_final.png"));
                                else
                                    imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/azul_vazio.png"));
                        }
                        else if(value == "vermelho")
                        {
                            if (self)
                                if (final)
                                    imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/verm_seta_self_final.png"));
                                else
                                    imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/verm_seta_self.png"));
                            else
                                if (final)
                                imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/verm_vazio_final.png"));
                            else
                                imagem.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/verm_vazio.png"));
                        }
                        corAtiva = value;
                    }
                }
        #endregion

        #region Construtor
        public Estado(Image novaImagem, string nome)
        {
            imagem = novaImagem;
            valor = nome;
            tornarAzul();
            ocultar();
        }
        #endregion

        #region Métodos Públicos
        public void tornarVermelho(){ this.cor = "vermelho"; }
            public void tornarAzul() { this.cor = "azul"; }
            public void ativarSelf(string texto){ this.self = true; this.txtSelf = texto; }
            public void desativarSelf() { this.self = false; this.txtSelf = ""; }
            public void tornarFinal() { this.final = true; }
            public void tornarNormal() { this.final = false; }
            public void ocultar()
            {
                this.ativo = false;
                imagem.Visibility = Visibility.Hidden;
                valor = "";
                desativarSelf();
            }
            public void ativar(string nome)
            {
                this.ativo = true;
                imagem.Visibility = Visibility.Visible;
                valor = nome;
            }
            public string obterNome()
            {
                return imagem.Name;
            }
        #endregion
    }
}
