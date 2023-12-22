namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    #region Variaveis
    SortedSet<int> sortedSet;

    #endregion

    private void btnGerarNumerosSorte_Clicked(object sender, EventArgs e)
    {
        gerarNumeros();

        lblLuckNumber01.Text = sortedSet.ElementAt(0).ToString("D2");
        lblLuckNumber02.Text = sortedSet.ElementAt(1).ToString("D2");
        lblLuckNumber03.Text = sortedSet.ElementAt(2).ToString("D2");
        lblLuckNumber04.Text = sortedSet.ElementAt(3).ToString("D2");
        lblLuckNumber05.Text = sortedSet.ElementAt(4).ToString("D2");
        lblLuckNumber06.Text = sortedSet.ElementAt(5).ToString("D2");


        btnGerarNumerosSorte.Text = "Não gostou do palpite? Clique aqui";
    }

    private void gerarNumeros()
    {
        sortedSet = new SortedSet<int>();
        Random random = new Random();

        while (sortedSet.Count < 6)
        {
            int numeroSorte = random.Next(1, 60);

            sortedSet.Add(numeroSorte);
        }

    }
}