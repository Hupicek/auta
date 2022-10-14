vehicle auto = new vehicle();

Console.WriteLine(vehicle.vykon + " koní");
auto.info();

class vehicle
{
    public int Kola;
    public int Písty;
    public int Sedacky;
    public int Velpístů;

    public int hp()
    {
        double vykon = Písty * this.Velpístů;
        double vysledek = Math.Abs(vykon);
        return (int)vykon;

    }

    public vehicle()
    {
        Console.WriteLine("zadej pocet kol");
        Kola = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("zadej pocet pístů");
        Písty = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("zadej pocet sedacek");
        Sedacky = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("zadej velikost pístu/ů (cm)");
        Velpístů = Convert.ToInt32(Console.ReadLine());


    }
    public void info()
    {
        Console.WriteLine("tvoje auto má tyto parametry:");
        Console.WriteLine(this.Kola + " Kola");
        Console.WriteLine(this.Písty + " Pístů");
        Console.WriteLine(this.Sedacky + " Sedacky");
        Console.WriteLine(this.Velpístů + " cm");
        

    }
}