namespace InharitanceDesctop.Classes
{
    public class Height
    {
        public float ManHeightH = 0;
        public float WomanHeightH;
        public float ManHeightK;
        public float WomanHeightK;
        public void GetHeightResult(float womanHeight, float manHeight)
        {
            var height = (womanHeight + manHeight) / 2;
            ManHeightH = height + 6.4f;
            WomanHeightH = height - 6.4f;
            ManHeightK = (manHeight + womanHeight * 1.08f) / 2;
            WomanHeightK = (manHeight * 0.923f + womanHeight) / 2;

        }
    }
}