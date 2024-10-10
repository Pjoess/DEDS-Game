
namespace BordModel{
abstract class Speler{

    public abstract string naam{get;set;}
    public abstract string team{get;set;}

    public abstract string type{get;set;}

    public abstract void maakZet(int x, int y, int nx, int ny, SpeelBord bord, int manier);
}
}