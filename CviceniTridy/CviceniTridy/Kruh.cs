
namespace CviceniTridy
{
    class Kruh
    {
        public Kruh(int polomer)
        {
            this.polomer = polomer;
        }
        
        public int polomer;
        public int prumer;
        public float obvod;
        
        public int Prumer()
        {
            prumer = polomer * 2;
            return prumer;
        }

        public float Obvod()
        {
            obvod = 2 * 3.14f * polomer;
            return obvod;
        }
        
        
    }
}