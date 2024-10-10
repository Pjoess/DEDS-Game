using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordModel
{
    class SpeelBord
    {
        public int Grootte { get; set; }
        //2 coordinaten
        public Cel[,] Grid { get; set; }

        public SpeelBord(int s)
        {
            // De grootte van het bord
            Grootte = s;

            //2D array
            Grid = new Cel[Grootte, Grootte];

            // vul de 2D array
            for(int i = 0; i < Grootte; i++)
            {
                for (int j = 0; j < Grootte; j++)
                {

                    Grid[i, j] = new Cel(i, j);

                    // Maak startposities voor BaggySweater(B)
                    if(i == 0 && j == Grootte-1){
                        Grid[i,j].value = "B";
                        Grid[i,j].Bezet = true;
                    }
                    if(i == 1 && j == Grootte-1){
                        Grid[i,j].value = "B";
                        Grid[i,j].Bezet = true;
                    }
                    if(i == 0 && j == Grootte-2){
                        Grid[i,j].value = "B";
                        Grid[i,j].Bezet = true;                        
                    }
                    if(i == 1 && j == Grootte-2){
                        Grid[i,j].value = "B";
                        Grid[i,j].Bezet = true;                        
                    }
                    // Maak startposities voor Hoodie(H)
                    if(i == Grootte-1 && j == 0){
                        Grid[i,j].value = "H";
                        Grid[i,j].Bezet = true;
                    }
                    if(i == Grootte-1 && j == 1){
                        Grid[i,j].value = "H";
                        Grid[i,j].Bezet = true;
                    }
                    if(i == Grootte-2 && j == 0){
                        Grid[i,j].value = "H";
                        Grid[i,j].Bezet = true;                        
                    }
                    if(i == Grootte-2 && j == 1){
                        Grid[i,j].value = "H";
                        Grid[i,j].Bezet = true;                        
                    }
                }
            }

            
        }



    }
}
