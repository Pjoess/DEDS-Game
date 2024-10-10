namespace BordModel{

    class Persoon: Speler{

        public override string team{get;set;} = "";
        public override string naam{get;set;} = "";

        public override string type{get;set;} = "Persoon";

        public Persoon(string team){
            if(team.Equals("Hoodie")){
                this.team = "H";
                naam = team;
            }
            if(team.Equals("BaggySweater")){
                this.team = "B";
                naam = team;
            }
        }
        public override void maakZet(int x, int y, int nx, int ny, SpeelBord bord, int manier)
        {
            // Console.WriteLine(x);
            // Console.WriteLine(y);


            // maak het vakje bezet en je eigen team
            bord.Grid[nx, ny].Bezet = true;
            bord.Grid[nx, ny].value = team;
            if(manier == 2){
                bord.Grid[x,y].value = "-";
            }

            //check de omliggende vakjes
            for(int i = nx-1; i < nx+2; i++){
                for(int j = ny-1; j < ny+2; j++){
                    if(!(i > bord.Grootte-1 || i < 0 || j > bord.Grootte-1 || j < 0))
                    {
                        if((!(bord.Grid[i,j].value == team)) ){
                            if(!(bord.Grid[i,j].value == "-")){
                                // maak de vakjes je team
                                bord.Grid[i,j].value = team;
                            }
                        }
                        Console.Write(bord.Grid[i,j].value);
                    }    
                }
            }           
        }
    }
}