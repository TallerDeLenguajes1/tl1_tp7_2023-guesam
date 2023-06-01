namespace EspacioCalculadora;

public class Calculadora{
    private double valor;

    public Calculadora(){
        valor = 0;
    }

    public double Resultado { get => valor;}

    public void Suma(double sumando){
        valor += sumando;
    }

    public void Resta(double restando){
        valor -= restando;
    }

    public void Multiplicar(double multiplicando){
        valor *= multiplicando;
    }

    public void Dividir(double dividiendo){
        valor /= dividiendo;
    }

    public void Limpiar(){
        valor = 0;
    }
}