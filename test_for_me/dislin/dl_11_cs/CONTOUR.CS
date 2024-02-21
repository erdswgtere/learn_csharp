using System;

public class App {
   public static void Main() {
     int n = 50, m = 50;
     float [,] zmat = new float [n,m];
     float [] xray = new float [n];
     float [] yray = new float [m];
     int i, j;
     float x, y, stepx, stepy, fpi, zlev;

     stepx = 360.0f / (n - 1);
     stepy = 360.0f / (m - 1);
     fpi = 3.1415926f / 180;

     for (i = 0; i < n; i++)
     { xray[i] = stepx * i;
     }

     for (j = 0; j < m; j++)
     { yray[j] = stepy * j;
     }

     for (i = 0; i < n; i++)
     { x = xray[i] * fpi;
       for (j = 0; j < m; j++)
       { y = yray[j] * fpi;
         zmat[i,j] = (float) (2 * Math.Sin (x) * Math.Sin (y));
       }
     }

     dislin.metafl ("cons");
     dislin.setpag ("da4p");
     dislin.disini ();
     dislin.pagera ();
     dislin.complx ();

     dislin.titlin ("Contour Plot", 1);
     dislin.titlin ("F(X,Y) = 2 * SIN(X) * SIN(Y)", 3);

     dislin.intax (); 
     dislin.axspos (450, 2650);

     dislin.name ("X-axis", "X");
     dislin.name ("Y-axis", "Y");

     dislin.graf (0.0f, 360.0f, 0.0f, 90.0f, 0.0f, 360.0f, 0.0f, 90.0f);
     dislin.height (50);
     dislin.title ();

     dislin.height (30);
     for (i = 0; i < 9; i++)
     { zlev = -2.0f + i * 0.5f;
       if (i == 4)
         dislin.labels ("NONE", "CONTUR");
       else
         dislin.labels ("FLOAT", "CONTUR");

       dislin.setclr ((i+1) * 28);
       dislin.contur (xray, n, yray, m, zmat, zlev);
     }
     dislin.disfin ();
  }
}
