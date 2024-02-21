using System;
using System.Text;

public class App {
   public static void Main() {
     int n = 50;
     float [] xray = new float [n];
     int i, ip, id_tbl;

     Swgcb2CB cb = new Swgcb2CB (App.myfunc);

     for (i = 0; i < n; i++)
     { xray[i] = i + 1;
     }

     dislin.swgwth (100);
     dislin.swgtit ("Dislin Table Widget");
     ip = dislin.wgini ("vert");

     dislin.swgopt ("on", "edit");
     dislin.swgopt ("both", "header");
     id_tbl = dislin.wgtbl (ip, 10, 5);
     dislin.swgcb2 (id_tbl, cb);

     dislin.swgtbs (id_tbl, "Tabelle", 0, 0, "value");
     
     for (i = 1; i <= 5; i++) 
     { string s = "C" + i.ToString ();
       dislin.swgtbs (id_tbl, s, 0, i, "value");
     }

     for (i = 1; i <= 10; i++) 
     { string s = "R" + i.ToString ();
       dislin.swgtbs (id_tbl, s, i, 0, "value");
     }

     dislin.swgtbl (id_tbl, xray, n, 2, 0, "ctable");
     dislin.wgfin ();
  }

  public static void myfunc (int id, int irow, int icol)
  { StringBuilder cstr = new StringBuilder ();

    dislin.gwgtbs (id, irow, icol, cstr);     
    Console.WriteLine (cstr);     
  }
}
