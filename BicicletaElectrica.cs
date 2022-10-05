class BicicletaElectrica: Vehiculo{
    public void prenderPantalla(){
        Console.WriteLine("Pantalla encendida");
    }
    public  void energizador(){
        Console.WriteLine("Motor listo");
    }
    public override void encender(){
        Console.WriteLine("************************");
        Console.WriteLine("Encender una bicicletaE.");
        prenderPantalla();
        energizador();
    }
}