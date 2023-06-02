
using Microsoft.Extensions.Logging.Abstractions;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace MauiApp6;

public partial class VucutKitleİndeksi : ContentPage
{
    public VucutKitleİndeksi()
    {
        InitializeComponent();
    }

    
    private void CounterBtn_Clicked(object sender, EventArgs e)
    {
        double kilo, boyCm, boyM;
        if (!double.TryParse(kiloEntry.Text, out kilo) || !double.TryParse(boyEntry.Text, out boyCm))
        {
            sonucLabel.Text = "Lütfen geçerli bir kilo ve boy değeri girin.";
            return;
        }

        boyM = boyCm / 100.0;
        double vki = kilo / (boyM * boyM);

        string sonuc = "";

        if (vki < 16)
        {
            sonuc = "İleri Düzeyde Zayıf";
        }
        else if (vki >= 16 && vki <= 16.99)
        {
            sonuc = "Orta Düzeyde Zayıf";
        }
        else if (vki >= 17 && vki <= 18.49)
        {
            sonuc = "Hafif Düzeyde Zayıf";
        }
        else if (vki >= 18.5 && vki <= 24.9)
        {
            sonuc = "Normal Kilolu";
        }
        else if (vki >= 25 && vki <= 29.99)
        {
            sonuc = "Hafif Şişman / Fazla Kilolu";
        }
        else if (vki >= 30 && vki <= 34.99)
        {
            sonuc = "1. Derecede Obez";
        }
        else if (vki >= 35 && vki <= 39.99)
        {
            sonuc = "2. Derecede Obez";
        }
        else if (vki >= 40)
        {
            sonuc = "3. Derecede Obez / Morbid Obez";
        }

        sonucLabel.Text = string.Format("VKI: {0:f2} - {1}", vki, sonuc);
    }
    private void Stepper_ValueChanged_1(object sender, ValueChangedEventArgs e)
    {
        var stepper1 = sender as Stepper;
        kiloEntry.Text = stepper1.Value.ToString("F2");

    }
    private void Stepper_ValueChanged_2(object sender, ValueChangedEventArgs e)
    {
        var stepper2 = sender as Stepper;
        boyEntry.Text = stepper2.Value.ToString("F2");
    }
}
    public static VucutKitleİndeksi Page
    { get; private set; }

    public object TextBox { get; private set; }
    public float VKI { get; private set; }

    private void CounterBtn_Clicked(object sender, EventArgs e)
    {
        var s = sender as Microsoft.Maui.Controls.Button;
        
         
        int kilo = int.Parse((string)TextBox);
        int boy = int.Parse((string)TextBox);

        VKI = kilo / (boy * boy);
        if (VKI <= 16)
        {
            Console.WriteLine("İleri Düzeyde zayıf");
        }

        
        elif(VKI>= 16 & VKI < 16,99);
        {
            Console.WriteLine("Orta Düzeyde zayıf");
        }
        elif(VKI <18,49 );
        {
            Console.WriteLine("Hafif Düzeyde zayıf");
        }
        elif(VKI < 24,99);
        {
            Console.WriteLine("Normal Kilolu");
        }
        elif(VKI < 29,99);
        {
            Console.WriteLine("Hafif Kilolu");
        }
        elif(VKI < 34, 99);
        {
            Console.WriteLine("1.dereceObez");
        }
        elif(VKI < 39, 99);
        {
            Console.WriteLine("2.derece Obez");
        }
        elif(VKI > 40,00);
        {
            Console.WriteLine("3.derece Obez");
        }
        


    }

    private void elif(bool v, int v1)
    {
        throw new NotImplementedException();
    }

    private void Stepper_ValueChanged_1(object sender, ValueChangedEventArgs e)
    {
        var stepper1 = sender as Stepper;
        kilo.Text = stepper1.Value.ToString("F2");

    }
    private void Stepper_ValueChanged_2(object sender, ValueChangedEventArgs e)
    {
        var stepper2 = sender as Stepper;
        boy.Text = stepper2.Value.ToString("F2");
    }
}
