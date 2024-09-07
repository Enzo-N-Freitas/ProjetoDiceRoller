namespace DiceRoller;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        
    }
    private void RollerButton_Clicked(object sender, EventArgs e)
    {
        if (DicePicker.SelectedItem != null)
        {
            int NumberOfSides = 0;
            int Result = 0;
            NumberOfSides = int.Parse(DicePicker.SelectedItem.ToString());
            Random random = new Random();
            Result = random.Next(1, NumberOfSides + 1);
            DiceResult.Text = Result.ToString();
        }

        }


        //Sortear um número aleatório através do clique do botão
        //Devolver o número sorteado para a interface
        //Conseguir selecionar a quantidade de lados a partir do Picker

    }

