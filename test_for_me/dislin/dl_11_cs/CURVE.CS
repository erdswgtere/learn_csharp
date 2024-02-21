using System;

public class App {
   public static void Main() {
     int n = 301;
     float [] xray = new float [n];
     float [] y1ray = new float [n];
     float [] y2ray = new float [n];
     int i;
     float x, step, fpi;

     fpi = 3.1415926f / 180;
     step = 360.0f / (n - 1);
     for (i = 0; i < n; i++)
     { xray[i] = i * step;
       x = xray[i] * fpi;
       y1ray[i] = (float) Math.Sin (x);
       y2ray[i] = (float) Math.Cos (x);
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

     dislin.titlin ("Demonstration of CURVE", 1);
     dislin.titlin ("SIN(X), COS(X)", 3);

     dislin.graf (0.0f, 360.0f, 0.0f, 90.0f, -1.0f, 1.0f, -1.0f, 0.5f);
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
