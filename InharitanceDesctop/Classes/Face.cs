using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;

namespace InharitanceDesctop.Classes
{
    public class Face
    {
        public Dictionary<string, float> FaceForm;
        public Dictionary<string, float> FaceFreckles;
        public Dictionary<string, float> FaceChin;
        public Dictionary<string, float> FaceCheek;
        public Dictionary<string, float> FaceBrow;
        public Dictionary<string, float> FaceCilia;

        public void GetFaceCilia(string woman, string man)
        {
            Dictionary<string, float> tmp;
            if (woman == "Довгі" && man == "Довгі")
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Довгі",75 },
                    {"Короткі",25 }
                };
            }
            else if ((woman == "Довгі" && man == "Короткі") || (woman == "Короткі" && man == "Довгі"))
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Довгі", 50},
                    {"Короткі", 50}
                };
            }
            else
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Довгі",0},
                    {"Короткі",100 }
                };
            }
            FaceCilia = tmp;
        }
        public void GetFaceBrow(string woman, string man)
        {
            Dictionary<string, float> tmp;
            if (woman == "Густі" && man == "Густі")
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Густі",75 },
                    {"Тонкі",25 }
                };
            }
            else if ((woman == "Густі" && man == "Тонкі") || (woman == "Тонкі" && man == "Густі"))
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Густі", 50},
                    {"Тонкі", 50}
                };
            }
            else
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Густі",0},
                    {"Тонкі",100 }
                };
            }
            FaceBrow = tmp;
        }
        public void GetFaceCheek(string woman, string man)
        {
            Dictionary<string, float> tmp;
            if (woman == "Є" && man == "Є")
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Є",75 },
                    {"Нема",25 }
                };
            }
            else if ((woman == "Є" && man == "Нема") || (woman == "Нема" && man == "Є"))
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Є", 50},
                    {"Нема", 50}
                };
            }
            else
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Є",0},
                    {"Нема",100 }
                };
            }
            FaceCheek = tmp;
        }
        public void GetFaceChin(string woman, string man)
        {
            Dictionary<string, float> tmp;
            if (woman == "Є" && man == "Є")
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Є",75 },
                    {"Нема",25 }
                };
            }
            else if ((woman == "Є" && man == "Нема") || (woman == "Нема" && man == "Є"))
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Є", 50},
                    {"Нема", 50}
                };
            }
            else
            {
                tmp = new Dictionary<string, float>()
                {
                    {"Є",0},
                    {"Нема",100 }
                };
            }
            FaceChin = tmp;
        }
        public void GetFaceFreckles(string woman, string man)
        {
            Dictionary<string, float> tmp;
            if (woman == "Є" && man == "Є")
            {
               tmp = new Dictionary<string, float>()
                {
                    {"Є",75 },
                    {"Нема",25 }
                };
            }
            else if ((woman == "Є" && man == "Нема") || (woman == "Нема" && man == "Є"))
            {
               tmp= new Dictionary<string, float>()
                {
                    {"Є", 50},
                    {"Нема", 50}
                };
            }
            else
            {
                 tmp = new Dictionary<string, float>()
                {
                    {"Є",0},
                    {"Нема",100 }
                };
            }
            FaceFreckles = tmp;
        }
        public void GetFaceForm(string woman, string man)
        {
            if (woman == "Кругла" && man == "Кругла")
            {
                FaceForm = new Dictionary<string, float>()
                {
                    {"Кругла",75 },
                    {"Квадратна",25 }
                };
            }
            else if ((woman == "Кругла" && man == "Квадратна") || (woman == "Квадратна" && man == "Кругла"))
            {
                FaceForm = new Dictionary<string, float>()
                {
                    {"Кругла", 50},
                    {"Квадратна", 50}
                };
            }
            else
            {
                FaceForm = new Dictionary<string, float>()
                {
                    {"Кругла",0},
                    {"Квадратна",100 }
                };
            }
        }

    }
}