using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MsgPraTu
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        Random random = new Random();

        void Clicada(object sender, EventArgs args){
            string[] content = {
                "A persistência é o caminho do êxito.",

                "O sucesso nasce do querer, da determinação e persistência em se " +
                "chegar a um objetivo. Mesmo não atingindo o alvo, quem busca e vence " +
                "obstáculos, no mínimo fará coisas admiráveis.",

                "Só existe um êxito: a capacidade de levar a vida que se quer.",

                "A coragem não é ausência do medo; é a persistência apesar do medo.",

                "Nenhum mentiroso tem uma memória suficientemente boa para ser um " +
                "mentiroso de êxito."
            };

            label_content.Text = content[random.Next(0, (content.Length-1))];

        }
    }
}
