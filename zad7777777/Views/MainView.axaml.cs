using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using System;
using System.Collections.Generic;

namespace zad7777777.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }
    int i = 0;

    public event EventHandler<ScrollChangedEventArgs> ScrollHorizontalScroll;

    public void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        string rnaseq;
        string temprna;
        Dictionary<string, int> openWith = new Dictionary<string, int>();
        if (rna.Text != null)
        {
            
            rnaseq = rna.Text;
           // List<string> list = new List<string>(); 
            for (i = 0; i < rnaseq.Length-4; i++)
            {
                temprna = rnaseq.Substring(i, 4);
                //list.Find(temprna);
                try
                {
                    openWith.Add(temprna, 1);
                }
                catch (ArgumentException)
                {
                    openWith[temprna] = openWith[temprna]+1;
                }

                //list.Add(temprna);

            }
        }
        string tempo = "";
        foreach (KeyValuePair<string, int> item in openWith)
        {
            wynik.Text += item.Key + " " + item.Value + "\n";
        }
        


       // ScrollViewer.IsScrollChainingEnabled = [true | false]
       //wynik.Text = i++.ToString();    


    }
    public string text = "";

}
