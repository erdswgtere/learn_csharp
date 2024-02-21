using System;
using System.Text;

public class App {
   public static void Main() {
     float [] xray = {1.0f, 2.5f, 2.0f, 2.7f, 1.8f};
     StringBuilder cbuf = new StringBuilder (80);

     dislin.metafl ("cons");
     dislin.setpag ("da4p");
     dislin.disini ();
     dislin.pagera ();
     dislin.hwfont ();
     dislin.chnpie ("BOTH");

     dislin.axslen (1600, 1000);
     dislin.titlin ("Pie Charts (PIEGRF)", 1);

     dislin.legini (cbuf, 5, 8);
     dislin.leglin (cbuf, "FIRST",  1);
     dislin.leglin (cbuf, "SECOND", 2);
     dislin.leglin (cbuf, "THIRD",  3);
     dislin.leglin (cbuf, "FOURTH", 4);
     dislin.leglin (cbuf, "FIFTH",  5);

     dislin.patcyc (1, 7);
     dislin.patcyc (2, 4);
     dislin.patcyc (3, 13);
     dislin.patcyc (4, 3);
     dislin.patcyc (5, 5);

     dislin.axspos (250, 2800);
     dislin.piegrf (cbuf.ToString (), 1, xray, 5);
     dislin.endgrf ();

     dislin.axspos (250, 1600);
     dislin.labels ("DATA", "PIE");
     dislin.labpos ("EXTERNAL", "PIE");
     dislin.piegrf (cbuf.ToString (), 1, xray, 5);

     dislin.height (50);
     dislin.title  ();
     dislin.disfin ();
   }
}
