
class Principal{
    public static void Main(string[]args){
        probar(new Vehiculo());
        probar(new Avion());
        probar(new BicicletaElectrica());
    }
    public static void probar(Vehiculo v){
        v.encender();
    }
}