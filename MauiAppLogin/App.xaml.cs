namespace MauiAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        protected override Window CreateWindow(IActivationState ActivationState) //Permite modificar o tamanho da janela
        {
            var window = base.CreateWindow(ActivationState);
            window.Width = 400; //Largura de Janela
            window.Height = 700; //Altura de Janela
            return window;
        }
    } //Fecha Classe


} //Fecha NameSpace 
