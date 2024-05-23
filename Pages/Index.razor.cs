namespace _4iConsultoria.Pages
{
    public partial class Index
    {
        private List<string> listaItens = new List<string> { "dashboards", "feedback", "consultoria", "fidelidade" };
        private string itemSelecionado = string.Empty;
        private string textoSelecionado = string.Empty;
        private string imagemSelecionada = string.Empty;

        string date = string.Empty, time = string.Empty;
        Timer aTimer;

        protected override void OnInitialized()
        {
            itemSelecionado = listaItens.FirstOrDefault();

            textoSelecionado = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.";
            imagemSelecionada = "../Images/notebook.png";

            aTimer = new Timer(Tick, null, 0, 1000);
        }

        private void SelecionarItem(string item)
        {
            itemSelecionado = item;

            switch (itemSelecionado)
            {
                case "dashboards":
                    textoSelecionado = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.";
                    imagemSelecionada = "../Images/notebook.png";
                    break;
                case "feedback":
                    textoSelecionado = "When an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries.";
                    imagemSelecionada = "../Images/apple.png";
                    break;
                case "consultoria":
                    textoSelecionado = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.";
                    break;
                case "fidelidade":
                    textoSelecionado = "When an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries.";
                    break;
            }
        }

        private void Tick(object _)
        {
            date = DateTime.Now.Year.ToString();
            time = DateTime.Now.ToLongTimeString();
            InvokeAsync(StateHasChanged);
        }

        public void Dispose()
        {
            aTimer?.Dispose();
        }

        private void verifyDark()
        {
            Console.WriteLine(dark);
        }
    }
}