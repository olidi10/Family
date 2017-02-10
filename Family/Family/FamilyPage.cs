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
                FormattedText = new FormattedString                {
                    Spans = {
                         new Span
                        {
                           Text = "\nPlease Welcome to my Mobile Application." +
                           "I will Like you to meet some important members of My Family."+
                           "First,I will like them to introduce themselves and tell you some of thier\n\n"+
                           "  'HOBBIES'",
                            FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                            ForegroundColor = Color.Black,
                           
                            FontSize =20,
                           
                            

                        },
                        new Span
                        {
                           Text = "\nGrandFather\n",
                           ForegroundColor = Color.Navy,
                            FontSize = 30,
                        },
                        new Span
                        {
                           Text = "GrandMother\n",
                            FontAttributes = FontAttributes.Bold,
                             ForegroundColor = Color.Maroon,
                            FontSize = 30,
                        },
                        new Span
                        {
                           Text = "Father\n",
                            FontAttributes = FontAttributes.Bold,
                             ForegroundColor = Color.Green,
                            FontSize = 30,
                        },
                        new Span
                        {
                           Text = "Mother\n",
                            FontAttributes = FontAttributes.Bold,
                             ForegroundColor = Color.Purple,
                            FontSize = 30,
                        },
                        new Span
                        {
                           Text = "Brother\n",
                            FontAttributes = FontAttributes.Italic,
                             ForegroundColor = Color.Maroon,
                            FontSize = 25,
                        },
                        new Span
                        {
                           Text = "Sister\n",
                            FontAttributes = FontAttributes.Italic,
                             ForegroundColor = Color.Olive,
                            FontSize = 20,
                           
                        },
                        new Span
                        {
                           Text = "Uncle\n",
                            FontAttributes = FontAttributes.Italic,
                             ForegroundColor = Color.Yellow,
                            FontSize = 26,
                        },new Span
                        {
                           Text = "Aunt\n",
                            FontAttributes = FontAttributes.None,
                            ForegroundColor = Color.Purple,
                            FontSize = 20,
                        },
                    }
                    },
              
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
               // FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
                BackgroundColor = Color.Gray,
                VerticalOptions = LayoutOptions.Center,
            };


        }


    }
          
            
 };
