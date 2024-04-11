using System;

// Definición de la clase de argumentos del evento
public class NotificacionEventArgs : EventArgs
{
    public string Mensaje { get; } // Propiedad para almacenar el mensaje de la notificación

    // Constructor que inicializa la propiedad Mensaje
    public NotificacionEventArgs(string mensaje)
    {
        Mensaje = mensaje;
    }
}

// Definición de la clase del notificador
public class Notificador
{
    // Declaración del evento NotificacionEnviada, que utiliza la clase de argumentos NotificacionEventArgs
    public event EventHandler<NotificacionEventArgs> NotificacionEnviada;

    // Método para enviar una notificación
    public void EnviarNotificacion(string mensaje)
    {
        Console.WriteLine($"Enviando notificación: {mensaje}");

        // Invocación del método protegido que desencadena el evento
        OnNotificacionEnviada(new NotificacionEventArgs(mensaje));
    }

    // Método protegido que desencadena el evento
    protected virtual void OnNotificacionEnviada(NotificacionEventArgs e)
    {
        // Verificación de que hay suscriptores al evento antes de invocarlo
        NotificacionEnviada?.Invoke(this, e);
    }
}

// Clase de ejemplo que se suscribe al evento
public class Cliente
{
    // Constructor de la clase Cliente que recibe un objeto Notificador y se suscribe al evento NotificacionEnviada
    public Cliente(Notificador notificador)
    {
        // Suscripción al evento NotificacionEnviada
        notificador.NotificacionEnviada += RecibirNotificacion;
    }

    // Método manejador del evento NotificacionEnviada
    private void RecibirNotificacion(object sender, NotificacionEventArgs e)
    {
        // Método que maneja la notificación recibida
        Console.WriteLine($"Cliente recibió notificación: {e.Mensaje}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Notificador notificador = new Notificador(); // Creación de una instancia de la clase Notificador
        Cliente cliente1 = new Cliente(notificador); // Creación de un Cliente que se suscribe al Notificador
        Cliente cliente2 = new Cliente(notificador); // Creación de otro Cliente que también se suscribe al Notificador

        // Enviar una notificación a través del Notificador
        notificador.EnviarNotificacion("¡Hola a todos!");
    }
}
