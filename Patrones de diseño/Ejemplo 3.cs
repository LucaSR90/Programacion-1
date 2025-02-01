using System;
using System.Collections.Generic;

// Definimos la interfaz que usarán los observadores (suscriptores)
public interface IObserver
{
    void Update(string message);
}

// Clase que gestiona las notificaciones
public class Notificador
{
    private List<IObserver> _subscribers = new List<IObserver>();

    public void Suscribir(IObserver observer)
    {
        _subscribers.Add(observer);
    }

    public void Desuscribir(IObserver observer)
    {
        _subscribers.Remove(observer);
    }

    public void EnviarNotificacion(string message)
    {
        foreach (var observer in _subscribers)
        {
            observer.Update(message);
        }
    }
}

// Observador concreto (suscriptor)
public class Usuario : IObserver
{
    private string _nombre;

    public Usuario(string nombre)
    {
        _nombre = nombre;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{_nombre} recibió una notificación: {message}");
    }
}

class Program
{
    static void Main()
    {
        // Creamos el notificador
        Notificador notificador = new Notificador();

        // Creamos usuarios (suscriptores)
        Usuario usuario1 = new Usuario("Alice");
        Usuario usuario2 = new Usuario("Bob");

        // Los usuarios se suscriben a las notificaciones
        notificador.Suscribir(usuario1);
        notificador.Suscribir(usuario2);

        // Enviar una notificación
        notificador.EnviarNotificacion("¡Nuevo mensaje disponible!");

        // Bob se desuscribe
        notificador.Desuscribir(usuario2);

        // Enviar otra notificación
        notificador.EnviarNotificacion("¡Segunda notificación!");
    }
}
