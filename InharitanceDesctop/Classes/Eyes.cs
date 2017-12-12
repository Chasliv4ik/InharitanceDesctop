using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace InharitanceDesctop.Classes
{
    public class Eyes
    {
       public Dictionary<string, float> EyesColor;
        public Dictionary<string, float> EyesSize;
        public Dictionary<string, float> EyesType;
        public Dictionary<string, float> EyesSplit;

        public void GetEyesSplit(string womenSplit, string manSplit)
        {
            if (womenSplit == "Прямий" && manSplit == "Прямий")
            {
                EyesSplit = new Dictionary<string, float>()
                {
                    {"Прямий",75 },
                    {"Розкосий",25 }
                };
            }
            else if ((womenSplit == "Розкосий" && manSplit == "Прямий") || (womenSplit == "Прямий" && manSplit == "Розкосий"))
            {
                EyesSplit = new Dictionary<string, float>()
                {
                    {"Прямий", 50},
                    {"Розкосий", 50}
                };
            }
            else
            {
                EyesSplit = new Dictionary<string, float>()
                {
                    {"Прямий",0},
                    {"Розкосий",100 }
                };
            }
        }
        public void GetEyesType(string womenType,string manType)
        {
            if (womenType == "Монголоїдний" && manType == "Монголоїдний")
            {
                EyesType = new Dictionary<string, float>()
                {
                    {"Монголоїдний",75 },
                    {"Європеїдний",25 }
                };
            }
            else if ((womenType == "Європеїдний" && manType == "Монголоїдний") || (womenType == "Монголоїдний" && manType == "Європеїдний"))
            {
                EyesType = new Dictionary<string, float>()
                {
                    {"Монголоїдний", 50},
                    {"Європеїдний", 50}
                };
            }
            else
            {
                EyesType = new Dictionary<string, float>()
                {
                    {"Монголоїдний",0},
                    {"Європеїдний",100 }
                };
            }
        }
        public void GetEyesSize(string womenSize, string manSize)
        {
            if (womenSize == "Великі" && manSize == "Великі")
            {
                EyesSize = new Dictionary<string, float>()
                {
                    {"Великі",75 },
                    {"Маленькі",25 }
                };
            }
            else if ((womenSize == "Маленькі" && manSize == "Великі") || (womenSize == "Великі" && manSize == "Маленькі"))
            {
                EyesSize = new Dictionary<string, float>()
                {
                    {"Великі", 50},
                    {"Маленькі", 50}
                };
            }
            else
            {
                EyesSize = new Dictionary<string, float>()
                {
                    {"Маленькі",0},
                    {"Великі",100 }
                };
            }
        }
        public void GetColorByParents(string womenColor, string manColor)
        {
            
            if (womenColor == "Карі" && manColor == "Карі")
                EyesColor = new Dictionary<string, float>()
                {
                    {"Карі", 75},
                    {"Зелені", 18.75f},
                    {"Сині", 6.25f}
                };
            if (womenColor == "Зелені" && manColor == "Карі")
                EyesColor = new Dictionary<string, float>()
                {
                    {"Карі", 50},
                    {"Зелені", 37.5f},
                    {"Сині", 12.5f}
                };
            if (womenColor == "Сині" && manColor == "Карі")
                EyesColor = new Dictionary<string, float>()
                {
                    {"Карі", 50},
                    {"Зелені", 0},
                    {"Сині", 50}
                };
            if (womenColor == "Зелені" && manColor == "Зелені")
                EyesColor = new Dictionary<string, float>()
                {
                    {"Карі", 1},
                    {"Зелені", 75f},
                    {"Сині", 25f}
                };
            if (womenColor == "Зелені" && manColor == "Сині")
                EyesColor = new Dictionary<string, float>()
                {
                    {"Карі", 0},
                    {"Зелені", 50f},
                    {"Сині", 50f}
                };
            if (womenColor == "Сині" && manColor == "Сині")
                EyesColor = new Dictionary<string, float>()
                {
                    {"Карі", 0},
                    {"Зелені", 1},
                    {"Сині", 99f}
                };
        }
    }
}