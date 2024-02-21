using System;
using System.Runtime.InteropServices;

public class App {
   public static void Main() {

     float pi = 3.14159f, step;

     SurfcpCB cb = new SurfcpCB (App.zfun);

     dislin.metafl ("xwin");
     dislin.setpag ("da4p");
     dislin.disini ();
     dislin.pagera ();
     dislin.complx ();

     dislin.titlin ("Surface Plot of the Parametric Function", 2);
     dislin.titlin ("[COS(t)*(3+COS(u)), SIN(t)*(3+COS(u)), SIN(u)]", 4);

     dislin.axspos (200, 2400);
     dislin.axslen (1800, 1800);
     dislin.intax (); 

     dislin.name ("X-axis", "X");
     dislin.name ("Y-axis", "Y");
     dislin.name ("Z-axis", "Z");

     dislin.vkytit (-300);
     dislin.zscale (-1.0f, 1.0f); 
     dislin.graf3d (-4.0f, 4.0f, -4.0f, 1.0f, -4.0f, 4.0f, -4.0f, 1.0f,
        -3.0f, 3.0f, -3.0f, 1.0f);
     dislin.height (40);
     dislin.title ();

     step = 2 * pi / 30.0f;     
     dislin.surmsh ("on");
     dislin.surfcp (cb, 0.0f, 2 * pi, step, 0.0f, 2 * pi, step);
     dislin.disfin ();
  }

  public static float zfun (float x, float y, int iopt)
  { float ret;

    if (iopt == 1)
      ret = (float) (Math.Cos (x) * (3 + Math.Cos (y)));
    else if (iopt == 2)
      ret = (float) (Math.Sin (x) * (3 + Math.Cos (y)));
    else
      ret = (float) Math.Sin (y);
    return ret;
  }
}
