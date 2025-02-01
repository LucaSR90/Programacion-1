using System;

// Sistema de pago antiguo
public class PagoAntiguo
{
    public void ProcesarPago(string cuenta, double monto)
    {
        Console.WriteLine("Pago procesado desde la cuenta " + cuenta + " por $" + monto);
    }
}

// Nueva API de pagos
public class NuevoSistemaPago
{
    public void RealizarPago(string tarjeta, double cantidad)
    {
        Console.WriteLine("Pago realizado con la tarjeta " + tarjeta + " por $" + cantidad);
    }
}

// Adaptador para conectar el sistema antiguo con la nueva API
public class AdaptadorPago : PagoAntiguo
{
    private NuevoSistemaPago _nuevoPago;

    public AdaptadorPago(NuevoSistemaPago nuevoPago)
    {
        _nuevoPago = nuevoPago;
    }

    public new void ProcesarPago(string cuenta, double monto)
    {
        string tarjeta = "Tarjeta-" + cuenta;
        _nuevoPago.RealizarPago(tarjeta, monto);
    }
}

// Programa principal
class Program
{
    static void Main()
    {
        NuevoSistemaPago nuevoPago = new NuevoSistemaPago();
        PagoAntiguo pagoAdaptado = new AdaptadorPago(nuevoPago);

        pagoAdaptado.ProcesarPago("12345678", 100.0);
    }
}
