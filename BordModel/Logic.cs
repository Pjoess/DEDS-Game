namespace BordModel{
    class Logic{

        public static int checkBeurtManier(int initX, int initY, int nieuweX, int nieuweY)
        {
            int xDif;
            int yDif;
            if(initX > nieuweX){
                xDif = initX - nieuweX;
            }
            else{
                xDif = nieuweX - initX;
            }
            if(initY > nieuweY){
                yDif = initY - nieuweY;
            }
            else{
                yDif = nieuweY - initY;
            }


            if(xDif == 2 || yDif == 2)
            {
                return 2;
            }
            if(xDif == 2 && yDif == 2)
            {
                return 2;
            }
            if(xDif == 1 && yDif == 1)
            {
                return 1;
            }
            if(xDif == 1 && yDif == 0)
            {
                return 1;
            }
            if(xDif == 0 && yDif == 1)
            {
                return 1;
            }
            return 0;

        }
        public static Boolean checkLegeVelden(SpeelBord bord)
        {
            Boolean leegVakjeGevonden = false;
            //check lege velden over:
            for(int i = 0; i< bord.Grootte; i++){
                for(int j = 0; j< bord.Grootte; j++){
                    if(!(bord.Grid[i,j].Bezet)){
                        leegVakjeGevonden = true;
                    }
                    else{
                        leegVakjeGevonden = false;
                    }
                }
            }
            return leegVakjeGevonden;
        }



        public static int checkValideZet(int initX, int initY, int nieuweX, int nieuweY, SpeelBord bord, Speler speler)
        {

            // Boolean checkUitVelt = checkUitSpeelvelt(nieuweX, nieuweY, bord);
            
            // if(checkUitVelt){
            //     Console.WriteLine("Je mag niet buiten het speelvelt spelen!");
            //     return 0;
            // }
            int checkManier = checkBeurtManier(initX, initY, nieuweX, nieuweY);


            if(checkManier == 0){
                Console.WriteLine("deze move mag niet");
                return 0;
            }
            if(bord.Grid[nieuweX,nieuweY].Bezet){
                Console.WriteLine("dit vakje is vol");
                return 0;
            }
            if(bord.Grid[initX,initY].value != speler.team){
                Console.WriteLine("dit is niet je eigen kledingsoort!");
                return 0;
            }

            return checkManier;
        }

        public static Boolean checkEnd(SpeelBord bord)
        {
            //check lege velden
            Boolean leegVelt = checkLegeVelden(bord);
            if(!leegVelt){
                Console.WriteLine("Het veld is vol!");
                return false;
            }
            //check of 1 team geen speelstukken meer heeft
                //check of H geen stukken meer heeft
                Boolean stukH = false;
                for(int i = 0; i< bord.Grootte; i++){
                    for(int j = 0; j< bord.Grootte; j++){
                        if((bord.Grid[i,j].value.Equals("H"))){
                            stukH = true;
                        }
                    }
                }
                if(!stukH){
                    Console.WriteLine("Team BaggySweater wint!");
                    return true;
                }
                //check of B geen stukken meer heeft
                Boolean stukB = false;
                for(int i = 0; i< bord.Grootte; i++){
                    for(int j = 0; j< bord.Grootte; j++){
                        if((bord.Grid[i,j].value.Equals("B"))){
                            stukB = true;
                        }
                    }
                }
                if(!stukB){
                    Console.WriteLine("Team Hoodie wint!");
                    return true;
                }

            //check of een team geen zetten meer kan doen
            Boolean legeZettenH = false;
            for(int i = 0; i< bord.Grootte; i++){
                for(int j = 0; j< bord.Grootte; j++){
                    if((bord.Grid[i,j].value.Equals("H"))){
                        legeZettenH = checkLegeZetten(bord, i, j);
                        if(legeZettenH){
                            return true;
                        }
                    }
                }
            }
            if(!legeZettenH){
                Console.WriteLine("Hoodie kan geen zetten meer doen");
                return !legeZettenH;
            }
            Boolean legeZettenB = false;
            for(int i = 0; i< bord.Grootte; i++){
                for(int j = 0; j< bord.Grootte; j++){
                    if(!(bord.Grid[i,j].value.Equals("B"))){
                        legeZettenB = checkLegeZetten(bord, i, j);
                        if(legeZettenB){
                            return true;
                        }
                    }
                }
            }
            if(!legeZettenB){
                Console.WriteLine("BaggySweater kan geen zetten meer doen");
                return !legeZettenB;
            }


            return false;
        }

        public static Boolean checkLegeZetten(SpeelBord bord, int nx, int ny)
        {
            Boolean leegVakjeGevonden = false;
            //check lege velden over:
            for(int i = nx-2; i < nx+3; i++){
                for(int j = ny-2; j < ny+3; j++){
                    if(!(i > bord.Grootte-1 || i < 0 || j > bord.Grootte-1 || j < 0))
                    {
                        if(bord.Grid[i,j].value.Equals("-")){
                            return true;
                        }
                    }    
                }
            }  
            Console.WriteLine("geen lege zetten");
            return leegVakjeGevonden;
        }


    }
        

}

        // public void MarkeerVolgendeLegaleZet(Cell dezeCell, string bordStuk)
        // {
        //     //stap 1 - leegmaken
        //     for (int i = 0; i < Grootte; i++)
        //     {
        //         for(int j = 0; j < Grootte; i++)
        //         {
        //             Grid[i, j].LegaleNieuweZet = false;
        //             Grid[i, j].Bezet = false;
        //         }
        //     }

        // }