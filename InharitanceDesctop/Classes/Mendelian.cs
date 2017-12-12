using System.Collections.Generic;

namespace InharitanceDesctop.Classes
{
    public class Mendelian
    {
        public Dictionary<string, float> GetPennet()
        { 
            return null;
        }

        public Dictionary<string,float> Crossing(Gene women, Gene man)
        {
            if (women.Dominante && women.Recessive && man.Dominante && man.Recessive) //Aa x Aa
            {
                return new Dictionary<string, float>()
                {
                    {
                        women.DominanteAllele,75
                    },
                    {
                        women.RecessiveAllele, 25
                    }
                    
                };
            }

            if (women.Dominante && women.Recessive && !man.Dominante && man.Recessive) //Aa x aa
            {
                return new Dictionary<string, float>()
                {
                    {
                        women.DominanteAllele,50
                    },
                    {
                        women.RecessiveAllele, 50
                    }

                };
            }

            if (women.Dominante && women.Recessive && man.Dominante && !man.Recessive) //Aa x AA
            {
                return new Dictionary<string, float>()
                {
                    {
                        women.DominanteAllele,100
                    },
                    {
                        women.RecessiveAllele,0
                    }

                };
            }

            if (women.Dominante && !women.Recessive && man.Dominante && !man.Recessive) //AA x AA
            {
                return new Dictionary<string, float>()
                {
                    {
                        women.DominanteAllele,100
                    },
                    {
                        women.RecessiveAllele,0
                    }

                };
            }
            return null;
        }
    }

    public class Gene
    {
        public string Name;
        public string DominanteAllele;
        public string DominanteSymbol;
        public bool Dominante;
        public string RecessiveAllele;
        public string RecessiveSymbol;
        public bool Recessive;
       
    }
}