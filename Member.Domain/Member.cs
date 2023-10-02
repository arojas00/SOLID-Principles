namespace Member.Domain
{
    //En esta capa se encuentran todos los dominios o entidades necesarias para ejectura el API.
    //Esta capa no referencia a ninguna de las capas externas.
    public interface IPlayer
    {
        string Name { get; set; }
        int Matches { get; set; }
        string Achievement { get; }

    }

    public interface IDeffensive
    {
        int CleanSheets { get; set; }

    }

    public interface IOffensive
    {
        int Goals { get; set; }

    }
    /*
    Single-responsibility: cada clase tiene unicamente un trabajo (Ej: calculo de los logros)
    otras responsabilidades, como el traslado de datos a otras capas del API se delegan a otras clases

    Open-Closed: el calculo de los logros se realiza en cada una de las clases, asi estas estan abiertas a extensiones
    y se pueden agregar mas tipos de jugadores, pero no es necesario modificar una clase existente para que realice el
    cambio del calculo para una nueva posicion.
    Esto tambien se logra gracias a la interfaces, ya que de esta forma se sabe que todos son IPlayer

    Liskov Substitution: Una sub clase puede sustituir a la clase base, como el caso de la clase Winger, la cual
    extiende el comportamiento de Striker, pero no genera ningun comportamiento inesperado en el programa.

    Interface-segregation: se realiza la separación de jugadores en ofensivos y defensivos por medio de interfaces.
    de esta forma los jugadores no se ven obligados a implementar una interfaz que no es relevante para su posicion.

    Dependency Inversion: del clean architecture tenemos un proyecto cuyos modulos de alto nivel n dependen de los
    modulos de bajo nivel. El nivel de abstraccion aumenta conforme se acerca mas a las capas internas.
    */
    public class Goalkeeper: IPlayer, IDeffensive
    {
        public string Name { get; set; }
        public int Matches { get; set; }
        public int CleanSheets { get; set; }
        public string Achievement => CleanSheets+" clean sheets in " + Matches + " matches";
    }

    public class Striker : IPlayer, IOffensive
    {
        public string Name { get; set; }
        public int Matches { get; set; }
        public int Goals { get; set; }
        public string Achievement => "Goal per match ratio: " + (double)Goals / Matches;
    }

    public class Winger : Striker, IPlayer, IOffensive
    {
        public int SuccesfulDribbles { get; set; }
    }
}