using System.Collections.Generic;

namespace InharitanceDesctop.Classes
{
    public class Blood
    {
        public Dictionary<string, float> BloodGroup;
        public Dictionary<string, float> ResusFactor;

        public void GetResusFactor(string womanResus, string manResus)
        {
            if (womanResus == "Rh+" && manResus == "Rh+")
            {
                ResusFactor = new Dictionary<string, float>()
                {
                    {"Rh+",75 },
                    {"Rh-",25 }
                };
            }else if ((womanResus == "Rh-" && manResus == "Rh+") || (womanResus == "Rh+" && manResus == "Rh-"))
            {
                ResusFactor = new Dictionary<string, float>()
                {
                    {"Rh+", 50},
                    {"Rh-", 50}
                };
            }
            else
            {
                ResusFactor = new Dictionary<string, float>()
                {
                    {"Rh+",0},
                    {"Rh0-",100 }
                };
            }

            

        }
        public void GetGroupByParents(string womenGroup, string manGroup)
        {

            if (womenGroup == "I" && manGroup == "I")
                BloodGroup = new Dictionary<string, float>()
                {
                    {"I", 100},
                
                };
            if (womenGroup == "I" && manGroup == "II")
                BloodGroup = new Dictionary<string, float>()
                {
                    {"I", 25},
                    {"II",75 }
                };
            if (womenGroup == "I" && manGroup == "III")
                BloodGroup = new Dictionary<string, float>()
                {
                    {"I", 25},
                    {"II",75 }
                };
            if (womenGroup == "I" && manGroup == "IV")
                BloodGroup = new Dictionary<string, float>()
                {
                    {"II", 50},
                    {"III",50 }
                };


            if (womenGroup == "II" && manGroup == "I")
                BloodGroup = new Dictionary<string, float>()
                {
                    {"I", 25},
                    {"II",75 }

                };
            if (womenGroup == "II" && manGroup == "II")
                BloodGroup = new Dictionary<string, float>()
                {
                    {"I", 6},
                    {"II",94 }
                };
            if (womenGroup == "II" && manGroup == "III")
                BloodGroup = new Dictionary<string, float>()
                {
                    {"I", 6},
                    {"II",19 },
                    {"III",19},
                    {"IV",56 }
                };
            if (womenGroup == "II" && manGroup == "IV")
                BloodGroup = new Dictionary<string, float>()
                {
                    {"II", 50},
                    {"III",37 },
                    {"IV",13}
                };


            if (womenGroup == "III" && manGroup == "I")
                BloodGroup = new Dictionary<string, float>()
                {

                    {"I", 25},
                    {"III",75 }
                };
            if (womenGroup == "III" && manGroup == "II")
                BloodGroup = new Dictionary<string, float>()
                {
                    {"I", 6},
                    {"II",19 },
                    {"III",19},
                    {"IV",56 }
                };
            if (womenGroup == "III" && manGroup == "III")
                BloodGroup = new Dictionary<string, float>()
                {
                    {"I", 6},
                    {"III",94 }
                };
            if (womenGroup == "III" && manGroup == "IV")
                BloodGroup = new Dictionary<string, float>()
                {
                    { "II", 37},
                    {"III",50 },
                    {"IV",13}
                };

            if (womenGroup == "IV" && manGroup == "I")
                BloodGroup = new Dictionary<string, float>()
                {
                    {"II", 50},
                    {"III",50 }

                };
            if (womenGroup == "IV" && manGroup == "II")
                BloodGroup = new Dictionary<string, float>()
                {
                    {"II", 50},
                    {"III",37 },
                    {"IV",13}
                };
            if (womenGroup == "IV" && manGroup == "III")
                BloodGroup = new Dictionary<string, float>()
                {
                    {"II", 37},
                    {"III",50 },
                    {"IV",13}
                };
            if (womenGroup == "IV" && manGroup == "IV")
                BloodGroup = new Dictionary<string, float>()
                {
                    {"II", 25},
                    {"III",25 },
                    {"IV",50 }
                };
        }
    }
}