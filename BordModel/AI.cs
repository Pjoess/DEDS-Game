// namespace BordModel{

//     class AI : Speler
//     {
//         public override string naam { get; set; }
//         public override string team { get; set; }
        
//         public override string type{get;set;} = "AI";

//         public AI(string team){
//             if(team.Equals("Hoodie")){
//                 this.team = "H";
//                 naam = team;
//             }
//             if(team.Equals("BaggySweater")){
//                 this.team = "B";
//                 naam = team;
//             }


//         }
//         public override void maakZet(int x, int y, int nx, int ny, SpeelBord bord, int manier)
//         {
//             Boolean optie = optie1Plaats(bord);

//             if(optie == false){
//                 optie = optie2Plaats(bord);
//             }
//             else{
//                 return;
//             }


//         }

//         public Boolean optie1Plaats(SpeelBord bord)
//         {
//             int ii = 0;
//             int jj = 0;
//             List<Cel> cellen = new List<Cel>();
            
//             Random random = new Random();
//             // int i = random.Next(-1,1);
//             // int j = random.Next(-1,1);

//             for(int i = 0; i< bord.Grootte; i++){
//                 for(int j = 0; j< bord.Grootte; j++){
//                     if(bord.Grid[i,j].value.Equals(team)){
//                         cellen.Add(bord.Grid[i,j]);
//                     }
//                 }
//             }
//             //vind alle cellen die de AI over heeft
//             for(int i = 0; i< bord.Grootte; i++){
//                 for(int j = 0; j< bord.Grootte; j++){
//                     if(bord.Grid[i,j].value.Equals(team)){
//                         //werkt

//                         //vind voor de cel hierboven de aanliggende vrije cellen
//                         bool probleem = true;
//                         int tries = 0;

//                         while(probleem && tries!=10 ){
//                             ii = rdn.Next((i-1), (i+2));
//                             jj = rdn.Next((j-1), (j+2));
//                             if(!(ii > bord.Grootte-1 || ii < 0 || jj > bord.Grootte-1 || jj < 0))
//                             {
//                                 if(!(bord.Grid[ii,jj].Bezet)){
//                                     tries++;
//                                 }
//                                 else{
//                                     // maak de vakjes je team
//                                     bord.Grid[ii,jj].value = team;
//                                     checkOmringende(bord, ii,jj);
//                                     probleem = false;
//                                     return true;
                                    
//                                 }
//                             }
//                         }              
//                     }
//                 }
//             }
//             return false;
//         }

//         public void checkOmringende(SpeelBord bord, int nx, int ny){
//             for(int i = nx-1; i < nx+2; i++){
//                 for(int j = ny-1; j < ny+2; j++){
//                     if(!(i > bord.Grootte-1 || i < 0 || j > bord.Grootte-1 || j < 0))
//                     {
//                         if((!(bord.Grid[i,j].value == team)) ){
//                             if(!(bord.Grid[i,j].value == "-")){
//                                 bord.Grid[i,j].value = team;
//                             }
//                         }
//                         Console.Write(bord.Grid[i,j].value);
//                     }    
//                 }
//             }
//         }



//         public Boolean optie2Plaats(SpeelBord bord)
//         {
//             Boolean werkend = false;
//             int ii;
//             int jj;
            

//             List<Cel> cellen = new List<Cel>();
            
//             Random random = new Random();
//             // int i = random.Next(-1,1);
//             // int j = random.Next(-1,1);

//             for(int i = 0; i< bord.Grootte; i++){
//                 for(int j = 0; j< bord.Grootte; j++){
//                     if(bord.Grid[i,j].value.Equals(team)){
//                         cellen.Add(bord.Grid[i,j]);
//                     }
//                 }
//             }

//             for(int c = 0; c < cellen.Count(); c++){
//                  int celIndex = random.Next(0, cellen.Count());
//                 Cel gekozen = cellen.Skip(celIndex).Take(1).ToList()[0];

//                  if(Logic.checkLegeZetten(bord, gekozen.RijNummer, gekozen.ColumnNummer)){

                    
//                      for(int i = gekozen.RijNummer-1; i < gekozen.RijNummer+2; i++){
//                          for(int j = gekozen.ColumnNummer-1; j < gekozen.ColumnNummer+2; j++){
                            
//                              if(!(i > bord.Grootte-1 || i < 0 || j > bord.Grootte-1 || j < 0))
//                              {
//                                  if(bord.Grid[i,j].value.Equals("-")){
//                                      if((Logic.checkValideZet(gekozen.RijNummer, gekozen.ColumnNummer, i,j, bord, this)) != 0){
//                                          if(bord.Grid[i,j].Bezet == false){
//                                              bord.Grid[i,j].Bezet = true;
//                                              bord.Grid[i,j].value = team;
//                                              break;
//                                          }
//                                      }
//                                  }
//                              }  
                            
//                          }
//                     }  
//                  }
//              }
            
            
//             //check of er sprongen mogelijk zijn 
//             for(int i = 0; i< bord.Grootte; i++){
//                 for(int j = 0; j< bord.Grootte; j++){
//                     if(bord.Grid[i,j].value.Equals(team)){
                        

//                         //vind voor de cel hierboven de mogelijke sprongen
//                         bool probleem = true;
//                         int tries = 0;

//                         //defineer de mogelijke sprongen in een list
                        // mogelijkeCellen.Add(bord.Grid[i-2,j+2]);
                        // mogelijkeCellen.Add(bord.Grid[i-2,j+1]);
                        // mogelijkeCellen.Add(bord.Grid[i-2,j]);
                        // mogelijkeCellen.Add(bord.Grid[i-2,j-1]);
                        // mogelijkeCellen.Add(bord.Grid[i-2,j-2]);
                        // mogelijkeCellen.Add(bord.Grid[i+2,j-2]);
                        // mogelijkeCellen.Add(bord.Grid[i+1,j-2]);
                        // mogelijkeCellen.Add(bord.Grid[i,j-2]);
                        // mogelijkeCellen.Add(bord.Grid[i-1,j-2]);
                        // mogelijkeCellen.Add(bord.Grid[i-2,j-2]);
                        // mogelijkeCellen.Add(bord.Grid[i+2,j+1]);
                        // mogelijkeCellen.Add(bord.Grid[i+2,j]);
                        // mogelijkeCellen.Add(bord.Grid[i+2,j-1]);
                        // mogelijkeCellen.Add(bord.Grid[i+1,j+2]);
                        // mogelijkeCellen.Add(bord.Grid[i,j+2]);
                        // mogelijkeCellen.Add(bord.Grid[i-1,j+2]);
//                         while(probleem && tries<16 ){
                            
//                             int random = rdn.Next(0, mogelijkeCellen.Count());
//                             Cel cel = mogelijkeCellen.Skip(random).Take(1).ToList()[0];
//                             ii = cel.RijNummer;
//                             jj = cel.ColumnNummer;
//                             if(!(ii > bord.Grootte-1 || ii < 0 || jj > bord.Grootte-1 || jj < 0))
//                             {
//                                 if(!(bord.Grid[ii,jj].Bezet)){
//                                     tries++;
//                                 }
//                                 else{
//                                     // maak de vakjes je team
//                                     bord.Grid[ii,jj].value = team;
//                                     checkOmringende(bord, ii,jj);
//                                     probleem = false;
//                                     werkend = true;
                                    
//                                 }
//                             }
//                         }  

//                     }
//                 }
//             }
//             return werkend;
//         }
//     }
// }


namespace BordModel{

    class AI : Speler
    {
        public override string naam { get; set; }
        public override string team { get; set; }
        public override string type { get; set; }

        public AI(string team){
            this.type = "AI";
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
            Random random = new Random();
            List<Cel> cellen = krijgKopieerOpenCellen(bord);
            if(!(cellen == null)){
                int celIndex = random.Next(0, cellen.Count());
                Cel gekozen = cellen.Skip(celIndex).Take(1).ToList()[0];

                bord.Grid[gekozen.RijNummer, gekozen.ColumnNummer].value = team;
                checkOmliggende(bord, gekozen);
            }    
            else{
                // cellen = krijgSpringOpenCellen(bord);
            }
        



        }

        public List<Cel> krijgKopieerOpenCellen(SpeelBord bord){
            List<Cel> cellen = new List<Cel>();
            List<Cel> openCellen = new List<Cel>();
            
            Random random = new Random();
            // int i = random.Next(-1,1);
            // int j = random.Next(-1,1);

            for(int i = 0; i< bord.Grootte; i++){
                for(int j = 0; j< bord.Grootte; j++){
                    if(bord.Grid[i,j].value.Equals(team)){
                        cellen.Add(bord.Grid[i,j]);
                    }
                }
            }

            //check omheen
            for(int c = 0; c < cellen.Count(); c++){
                int celIndex = random.Next(0, cellen.Count());
                Cel gekozen = cellen.Skip(celIndex).Take(1).ToList()[0];

                for(int i = gekozen.RijNummer-1; i < gekozen.RijNummer+2; i++){
                for(int j = gekozen.ColumnNummer-1; j < gekozen.ColumnNummer+2; j++){
                    if(!(i > bord.Grootte-1 || i < 0 || j > bord.Grootte-1 || j < 0))
                    {
                        if((!(bord.Grid[i,j].value == team)) ){
                            if((bord.Grid[i,j].value == "-")){
                                // maak de vakjes je team
                                openCellen.Add(bord.Grid[i,j]);
                            }
                        }
                        Console.Write(bord.Grid[i,j].value);
                    }    
                }
                }
            }   

            return openCellen;
        }

        public void checkOmliggende(SpeelBord bord, Cel cel){
            for(int i = cel.RijNummer-1; i < cel.RijNummer+2; i++){
                for(int j = cel.ColumnNummer-1; j < cel.ColumnNummer+2; j++){
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

        // public List<Cel> krijgSpringOpenCellen(SpeelBord bord){
        //     List<Cel> cellen = new List<Cel>();
        //     List<Cel> openCellen = new List<Cel>();
            
        //     Random random = new Random();
        //     // int i = random.Next(-1,1);
        //     // int j = random.Next(-1,1);

        //     for(int i = 0; i< bord.Grootte; i++){
        //         for(int j = 0; j< bord.Grootte; j++){
        //             if(bord.Grid[i,j].value.Equals(team)){
        //                 cellen.Add(bord.Grid[i,j]);
        //             }
        //         }

        //     }

        //     int celIndex = random.Next(0, cellen.Count());
        //     Cel gekozen = cellen.Skip(celIndex).Take(1).ToList()[0];

        //                 if(bord.Grid[gekozen.RijNummer-2,gekozen.ColumnNummer+2].value == "-"){
        //                     bord.Grid[gekozen.RijNummer-2,gekozen.ColumnNummer+2].value == team; 
        //                     bord.Grid[gekozen.RijNummer-2,gekozen.ColumnNummer+2].Bezet = true;
        //                     }
        //                 if(bord.Grid[i-2,j+1].value == "-"){}
        //                 if(bord.Grid[i-2,j].value == "-"){}
        //                 if(bord.Grid[i-2,j-1].value == "-"){}
        //                 if(bord.Grid[i-2,j-2].value == "-"){}
        //                 if(bord.Grid[i+2,j-2].value == "-"){}
        //                 if(bord.Grid[i+1,j-2].value == "-"){}
        //                 if(bord.Grid[i,j-2].value == "-"){}
        //                 if(bord.Grid[i-1,j-2].value == "-"){}
        //                 if(bord.Grid[i-2,j-2].value == "-"){}
        //                 if(bord.Grid[i+2,j+1].value == "-"){}
        //                 if(bord.Grid[i+2,j].value == "-"){}
        //                 if(bord.Grid[i+2,j-1].value == "-"){}
        //                 if(bord.Grid[i+1,j+2].value == "-"){}
        //                 if(bord.Grid[i,j+2].value == "-"){}
        //                 if(bord.Grid[i-1,j+2].value == "-"){}
            

        //     return null;
        // }
    }
}