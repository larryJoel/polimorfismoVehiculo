class Avion:Vehiculo{
    public void calefaccionarCarburador(){
        Console.WriteLine("Carburador listo");
    }
    public void regularMezclaDeCombustible(){
        Console.WriteLine("mezcla regulada");
    }
    public void inyeccionDeCombustible(){
        Console.WriteLine("Combustible inyectado");
    }
    public void MasPasos(){
        Console.WriteLine("Muchos pasos mas....");
    }

    public override void encender(){
        Console.WriteLine("************************");
        Console.WriteLine("Encendiendo un Avión");
        regularMezclaDeCombustible();
        inyeccionDeCombustible();
        MasPasos();
    }
}