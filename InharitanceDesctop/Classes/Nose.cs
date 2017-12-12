using System.Collections.Generic;

namespace InharitanceDesctop.Classes
{
    public class Nose
    {
        public Dictionary<string, float> NoseForm;
        public Dictionary<string, float> NoseNostris;
        public Dictionary<string, float> NoseBridge;
        public Dictionary<string, float> NoseTip;

        public void GetNoseTrip(string woman, string man)
        {
            Dictionary<string, float> tmp;
            if (woman == "Прямий" && man == "Прямий")
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Прямий",75 },
                    {"Курносий",25 }
                };
            }
            else if ((woman == "Прямий" && man == "Курносий") || (woman == "Курносий" && man == "Прямий"))
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Прямий", 50},
                    {"Курносий", 50}
                };
            }
            else
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Прямий",0},
                    {"курносий",100 }
                };
            }
            NoseTip = tmp;
        }
        public void GetNoseBridge(string woman, string man)
        {
            Dictionary<string, float> tmp;
            if (woman == "Висока і вузька" && man == "Висока і вузька")
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Висока і вузька",75 },
                    {"Низька і широка",25 }
                };
            }
            else if ((woman == "Висока і вузька" && man == "Низька і широка") || (woman == "Низька і широка" && man == "Висока і вузька"))
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Висока і вузька", 50},
                    {"Низька і широка", 50}
                };
            }
            else
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Висока і вузька",0},
                    {"Низька і широка",100 }
                };
            }
           NoseBridge = tmp;
        }

        public void GetNoseNostris(string woman, string man)
        {
            Dictionary<string, float> tmp;
            if (woman == "Кругла" && man == "Кругла")
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Кругла",75 },
                    {"Вузька",25 }
                };
            }
            else if ((woman == "Кругла" && man == "Вузька") || (woman == "Вузька" && man == "Кругла"))
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Кругла", 50},
                    {"Вузька", 50}
                };
            }
            else
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Кругла",0},
                    {"Вузька",100 }
                };
            }
            NoseNostris = tmp;
        }
        public void GetNoseForm(string woman, string man)
        {
            Dictionary<string, float> tmp;
            if (woman == "Кругла" && man == "Кругла")
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Кругла",75 },
                    {"Загострена",25 }
                };
            }
            else if ((woman == "Кругла" && man == "Загострена") || (woman == "Загострена" && man == "Кругла"))
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Кругла", 50},
                    {"Загострена", 50}
                };
            }
            else
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Кругла",0},
                    {"Загострена",100 }
                };
            }
            NoseForm = tmp;
        }
    }
}