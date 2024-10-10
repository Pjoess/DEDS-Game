

namespace BordModel{
class Spel{

    private Speler speler1 = new Persoon("Hoodie");
    private Speler speler2 = new AI("BaggySweater");

    public Stapel<SpeelBord> geschiedenis = new Stapel<SpeelBord>();
    private Speler aanDeBeurt;
    private SpeelBord bord;


    public Spel(SpeelBord bord){
        this.bord = bord;
        aanDeBeurt = speler1;
    }
    

    public Boolean start(){

        Boolean game = true;
        
        stapelOpslaan();



        while(game){
            Boolean probleem = false;
            
            Console.WriteLine(aanDeBeurt.type);
            if(aanDeBeurt.type.Equals("AI")){
                
                aanDeBeurt.maakZet(0,0,0,0,bord,0);
                stapelOpslaan();
                game = Logic.checkEnd(bord);
            }
            else{
                Console.WriteLine("Team dat aan de beurt is: " + aanDeBeurt.naam);
                showHuidigBord(bord.Grid);
                
                

                probleem = speel();
                stapelOpslaan();

                
                

                game = Logic.checkEnd(bord);
                

                    
            }
                
            if(game){
                showPunten();
            }
            if(!probleem && game){
                //geschiedenis.duw(bord);
                if(aanDeBeurt == speler1){
                    aanDeBeurt = speler2;
                }
                else{
                    aanDeBeurt = speler1;
                }
            }
            
        
            




            
            // game = Logic.checkWin();
            
            
        }


        return false;
    }
    

    private void showHuidigBord(Cel[,] bord){

        Console.Write("    ");
        for(int x = 0; x < bord.GetLength(0); x++)
        {
            Console.Write(x + "  ");
        }
        Console.WriteLine();
        Console.Write("   ");
        for(int x = 0; x < bord.GetLength(0); x++)
        {
            Console.Write("___");
        }
        Console.WriteLine();
        
        for (int i = 0; i < bord.GetLength(0); i++)
        {
            Console.Write(i + "  |");
            for (int j = 0; j < bord.GetLength(1); j++)
            {
                Console.Write(bord[i,j].value + "  ");
            }
        
            Console.WriteLine();
        }
    
    }

    private Boolean speel (){
        
        // Console.WriteLine("Wilt u een zet terug doen? typ dan 1, anders 0");
        // string terug = Console.ReadLine();
        // if(int.Parse(terug) == 1){
        //     bord = geschiedenis.pak();
        //     bord = geschiedenis.pak();
        //     showHuidigBord(bord.Grid);
        //     return false;
        // }
        
        Console.WriteLine("Typ uw zet in doormiddel van: Y,X,nieuweY,nieuweX");
        String? antwoord = Console.ReadLine();

        if(antwoord == "terug"){
            geschiedenis.pak();
            geschiedenis.pak();
            SpeelBord terug = geschiedenis.pak();
            
            for(int i = 0; i < bord.Grootte; i++){
                for(int j = 0; j < bord.Grootte; j++){
                    bord.Grid[i,j] = terug.Grid[i,j];

                    Console.WriteLine("undo werkt");
                }
            }
            return true;
        }

        String splitwaarde = ",";
        String[] splits = antwoord.Split(splitwaarde);



        int initX = int.Parse(splits[0]);
        int initY = int.Parse(splits[1]);

        int nieuweX = int.Parse(splits[2]);
        int nieuweY = int.Parse(splits[3]);


        
        if(nieuweX < 0 || nieuweY < 0 || nieuweX >= bord.Grootte || nieuweY >= bord.Grootte )
        {
            Console.WriteLine("Je mag niet buiten het veld zetten!");
            return true;
        }
        int manier = Logic.checkValideZet(initX, initY, nieuweX, nieuweY, bord, aanDeBeurt);
        if(!(manier == 0))
        {
            aanDeBeurt.maakZet(initX, initY, nieuweX, nieuweY, bord, manier);
            return false;
        }
        else{
            return true;
        }

        
        

    }

    public void showPunten(){
        
        int puntenH = 0;
        int puntenB = 0;

        for(int i = 0; i< bord.Grootte; i++){
            for(int j = 0; j< bord.Grootte; j++){
                if((bord.Grid[i,j].value.Equals("H"))){
                    puntenH ++;
                }
                if((bord.Grid[i,j].value.Equals("B"))){
                    puntenB++;
                }
            }
        }

        Console.WriteLine("Punten gescoord: ");
        Console.WriteLine("Hoodie: " + puntenH);
        Console.WriteLine("BaggySweater: " + puntenB);
    }

    public void stapelOpslaan(){

        SpeelBord kopie = new SpeelBord(bord.Grootte);
        for(int i = 0; i < bord.Grootte; i++){
            for(int j = 0; j < bord.Grootte; j++){
                kopie.Grid[i,j].value = bord.Grid[i,j].value;
                kopie.Grid[i,j].Bezet = bord.Grid[i,j].Bezet;
            }
        }
        
        geschiedenis.duw(kopie);
    }



}
}