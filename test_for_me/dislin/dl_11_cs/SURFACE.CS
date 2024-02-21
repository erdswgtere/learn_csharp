using System;

public class App {
   public static void Main() {
     int n = 50, m = 50;
     float [,] zmat = new float [n,m];
     int i, j;
     float x, y, step, fpi;

     fpi = 3.1415926f / 180;
     step = 360.0f / (n - 1);
     for (i = 0; i < n; i++)
     { x = i * step;
       for (j = 0; j < m; j++)
       { y = j * step;
         zmat[i,j] = (float) (2 * Math.Sin (x * fpi) * Math.Sin (y * fpi));
       }
     }

     dislin.metafl ("cons");
     dislin.setpag ("da4p");
     dislin.disini ();
     dislin.pagera ();
     dislin.hwfont ();

     dislin.titlin ("Surface Plot of the Function", 2);
     dislin.titlin ("F(X,Y) = 2 * SIN(X) * SIN (Y)", 4);

     dislin.axspos (200, 2600);
     dislin.axslen (1800, 1800);

     dislin.name ("X-axis", "X");
     dislin.name ("Y-axis", "Y");
     dislin.name ("Z-axis", "Z");

     dislin.view3d (-5.0f, -5.0f, 4.0f, "ABS");
     dislin.graf3d (0.0f, 360.0f, 0.0f, 90.0f, 0.0f, 360.0f, 0.0f, 90.0f,
        -3.0f, 3.0f, -3.0f, 1.0f);
     dislin.height (50);
     dislin.title ();

     dislin.color  ("green");
     dislin.surmat (zmat, n, m, 1, 1);
     dislin.disfin ();
  }
}
