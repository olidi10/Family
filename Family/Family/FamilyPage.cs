using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Family
{
     public class FamilyPage : ContentPage
    {
        public FamilyPage()
        {
            Content = new Label()


            {
                Text = "Greetings, Meet my family Members\n\nFather's name\n\nMicheal\n\nBrother's name\n\nPaul\n\n Mother's Name Sannah!",
                 HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                 FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontAttributes =FontAttributes.Bold,
                BackgroundColor = Color.Yellow,
                TextColor = Color.Blue
               
                
            };
            
        }
    }
}
