using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;

namespace zad7777777.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }
    int i = 0;

    public void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        string rnaseq;
        string temprna;
        if (rna.Text != null)
        {
            rnaseq = rna.Text;
            List<string> list = new List<string>(); 
            for (i = 0; i < rnaseq.Length-4; i++)
            {
                temprna = rnaseq.Substring(i, 4);
                //list.Find(temprna);
                list.Add(temprna);
                
            }
        }
       
        wynik.Text = i++.ToString();    
      
       
    }
}
