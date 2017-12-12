using System.Collections.Generic;

namespace InharitanceDesctop.Classes
{
    public class Eyars
    {
        public Dictionary<string, float> EyarsType;
        public Dictionary<string, float> EyarsLobe;
        public Dictionary<string, float> EyarsTip;

       

        public void GetEyarsTip(string womanTip, string manTip)
        {
            if (womanTip == "Гостра" && manTip == "Гостра")
            {
                EyarsTip = new Dictionary<string, float>()
                {
                    {"Гостра",75 },
                    {"Нормальна",25 }
                };
            }
            else if ((womanTip == "Гостра" && manTip == "Нормальна") || (womanTip == "Нормальна" && manTip == "Гостра"))
            { 
                EyarsTip = new Dictionary<string, float>()
                {
                    {"Гостра", 50},
                    {"Нормальна", 50}
                };
            }
            else
            {
                EyarsTip = new Dictionary<string, float>()
                {
                    {"Гостра",0},
                    {"Нормальна",100 }
                };
            }
        }
        public void GetEyarsLobe(string womaLobe, string manLobe)
        {
            if (womaLobe == "Вільна" && manLobe == "Вільна")
            {
                EyarsLobe = new Dictionary<string, float>()
                {
                    {"Вільна",75 },
                    {"Зрощена",25 }
                };
            }
            else if ((womaLobe == "Вільна" && manLobe == "Зрощена") || (womaLobe == "Зрощена" && manLobe == "Вільна"))
            {
                EyarsLobe = new Dictionary<string, float>()
                {
                    {"Вільна", 50},
                    {"Зрощена", 50}
                };
            }
            else
            {
                EyarsLobe = new Dictionary<string, float>()
                {
                    {"Вільна",0},
                    {"Зрощена",100 }
                };
            }
        }
        public void GetEyarsType(string womanType, string manType)
        {
            if (womanType == "Лаповухий" && manType == "Лаповухий")
            {
                EyarsType = new Dictionary<string, float>()
                {
                    {"Лаповухий",75 },
                    {"Притиснутий",25 }
                };
            }
            else if ((womanType == "Притиснутий" && manType == "Лаповухий") || (womanType == "Лаповухий" && manType == "Притиснутий"))
            {
                EyarsType = new Dictionary<string, float>()
                {
                    {"Лаповухий", 50},
                    {"Притиснутий", 50}
                };
            }
            else
            {
                EyarsType = new Dictionary<string, float>()
                {
                    {"Лаповухий",0},
                    {"Притиснутий",100 }
                };
            }
        }


    }
}