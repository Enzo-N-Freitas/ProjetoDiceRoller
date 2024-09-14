using System.Text;

namespace DiceRoller;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void RollerButton_Clicked(object sender, EventArgs e)
    {
        Dado dado = new Dado(int.Parse(DicePicker.SelectedItem.ToString()), int.Parse(DiceModifier.SelectedIndex.ToString()) + 1);

        if (DicePicker.SelectedItem != null)
        {
            var String = new StringBuilder();
            int soma = 0;
            if (DiceAmount.Text != null)
            {
                for (int i = 1; i <= int.Parse(DiceAmount.Text); i++)
                {
                    int resultado = dado.RolarDado();
                    String.AppendLine($"{resultado}");
                    soma += resultado;
                }
            }
            DiceSum.Text = soma.ToString();
        }
    }

    //Sortear um número aleatório através do clique do botão
    //Devolver o número sorteado para a interface
    //Conseguir selecionar a quantidade de lados a partir do Picker

}

