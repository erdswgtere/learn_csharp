using System;

public class App {
   public static void Main() {
     int i, n = 300, m = 10;
     float f = 3.1415927f / 180, step, a; 
     float [] x1 = new float [n];
     float [] y1 = new float [n];
     float [] x2 = new float [m];
     float [] y2 = new float [m];

     step = 360.0f / (n - 1);
     for (i = 0; i < n; i++)
     { a = (i * step) * f;
       y1[i] = a;
       x1[i] = (float) Math.Sin (5 * a);
     }

     for (i = 0; i < m; i++)
     { x2[i] = i + 1;
       y2[i] = i + 1;
     }

     dislin.metafl ("cons");
     dislin.setpag ("da4p");
     dislin.disini ();
     dislin.pagera ();
     dislin.hwfont ();

     dislin.titlin ("Polar Plots", 2);
     dislin.ticks (3, "y");

     dislin.axends ("NOENDS", "X");
     dislin.labdig (-1, "Y");
     dislin.axslen (1000, 1000); 
     dislin.axsorg (1050, 900);

     dislin.polar  (1.0f,0.0f, 0.2f, 0.0f, 30.0f);
     dislin.curve  (x1, y1, n);
     dislin.htitle (50);
     dislin.title  ();
     dislin.endgrf ();

     dislin.labdig (-1, "X");
     dislin.axsorg (1050, 2250);
     dislin.labtyp ("VERT", "Y");
     dislin.polar  (10.0f, 0.0f, 2.0f, 0.0f, 30.0f);
     dislin.barwth (-5.0f);
     dislin.polcrv ("FBARS");
     dislin.curve  (x2, y2, m);
     dislin.disfin ();
  }
}
