using System;

public class App {
   public static void Main() {
     int n = 301;
     double [] xray = new double [n];
     double [] y1ray = new double [n];
     double [] y2ray = new double [n];
     int i;
     double x, step, fpi;

     fpi = 3.1415926f / 180;
     step = 360.0f / (n - 1);
     for (i = 0; i < n; i++)
     { xray[i] = i * step;
       x = xray[i] * fpi;
       y1ray[i] = (double) Math.Sin (x);
       y2ray[i] = (double) Math.Cos (x);
     }

     dislin.metafl ("xwin");
     dislin.disini ();
     dislin.pagera ();
     dislin.complx ();

     dislin.axspos (450, 1800);
     dislin.axslen (2200, 1200);

     dislin.name ("X-axis", "X");
     dislin.name ("Y-axis", "Y");

     dislin.labdig (-1, "X");
     dislin.ticks (10, "XY");

     dislin.titlin ("Demostration of CURVE", 1);
     dislin.titlin ("SIN(X), COS(X)", 3);

     dislin.graf (0.0, 360.0, 0.0, 90.0, -1.0, 1.0, -1.0, 0.5);
     dislin.title ();

     dislin.color ("red");
     dislin.curve (xray, y1ray, n);
     dislin.color ("green");
     dislin.curve (xray, y2ray, n);

     dislin.color ("fore");
     dislin.dash ();
     dislin.xaxgit ();
     dislin.disfin ();
  }
}
