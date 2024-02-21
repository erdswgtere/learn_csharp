using System;

public class App {
   public static void Main() {
     int n = 100;
     float [,] zmat = new float [n,n];
     int i, j;
     float x, y, step, fpi;

     fpi = 3.1415926f / 180;
     step = 360.0f / (n - 1);
     for (i = 0; i < n; i++)
     { x = i * step;
       for (j = 0; j < n; j++)
       { y = j * step;
         zmat[i,j] = (float) (2 * Math.Sin (x * fpi) * Math.Sin (y * fpi));
       }
     }

     dislin.metafl ("xwin");
     dislin.disini ();
     dislin.pagera ();
     dislin.hwfont ();

     dislin.titlin ("3-D Colour Plot of the Function", 1);
     dislin.titlin ("F(X,Y) = 2 * SIN(X) * SIN(Y)", 3);
     dislin.name ("X-axis", "X");
     dislin.name ("Y-axis", "Y");
     dislin.name ("Z-axis", "Z");

     dislin.axspos (300, 1850);
     dislin.ax3len (2200, 1400, 1400);

     dislin.intax ();    
     dislin.autres (n, n);
     dislin.graf3 (0.0f, 360.0f, 0.0f, 90.0f, 0.0f, 360.0f, 0.0f, 90.0f,
        -2.0f, 2.0f, -2.0f, 1.0f);
     dislin.crvmat (zmat, n, n, 1, 1); 

     dislin.height (50);
     dislin.title ();
     dislin.disfin ();
  }
}
