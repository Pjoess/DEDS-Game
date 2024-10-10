namespace BordModel{

class Program{

    public static void Main(){
        SpeelBord bord = new SpeelBord(7);
        Spel spel = new Spel(bord);
        spel.start();
    }


}


}
