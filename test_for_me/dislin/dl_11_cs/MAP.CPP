#using <mscorlib.dll>
#using <disnet.dll>

using namespace System;
using namespace System::Text;

static int id_but, id_lis, id_draw; 

void myplot (int id);

void main ()
{ int nproj = 14, i, ip, ip1, ip2, id_lab1, id_lab2, id_quit;
  array<String ^>^ cl1 = {"Cylindrical Equidistant",
                         "Mercator",
                         "Cylindrical Equal-Area",
                         "Hammer (Elliptical)",
                           "Aitoff (Elliptical)",
                           "Winkel (Elliptical)",
                           "Sanson (Elliptical)",
                           "Conical Equidistant",
                           "Conical Equal-Area",
                           "Conical Conformal",
                           "Azimuthal Equidistant",
                           "Azimuthal Equal-Area",
                           "Azimuthal Stereographic",
                           "Azimuthal Orthgraphic"};

    StringBuilder^ clis = gcnew StringBuilder (512);

    SwgcbkCB^ cb = gcnew SwgcbkCB (myplot);

    for (i = 0; i < nproj; i++)
      dislin::itmcat (clis, cl1[i]);

    dislin::swgtit ("DISLIN Map Plot");
    ip = dislin::wgini ("hori");
    dislin::swgwth (-15);
    ip1 = dislin::wgbas (ip, "vert");
    dislin::swgwth (-50);
    ip2 = dislin::wgbas (ip, "vert");

    dislin::swgdrw ((float) (2100.0f/2970.0f));
    id_lab1 = dislin::wglab (ip1, "Projection:");
    id_lis  = dislin::wglis (ip1, clis->ToString (), 1);

    id_but  = dislin::wgpbut (ip1, "Plot");
    dislin::swgcbk (id_but, cb); 

    id_quit = dislin::wgquit (ip1);
    id_lab2 = dislin::wglab (ip2, "DISLIN Draw Widget:");
    id_draw = dislin::wgdraw (ip2);
    dislin::wgfin ();
  }

  void myplot (int id)
  { array<String ^>^  cl2 = {"CYLI", "MERC", "EQUA", "HAMM", "AITO", "WINK",
                     "SANS", "CONI", "ALBE", "CONF", "AZIM", "LAMB",
                     "STER", "ORTH"};

    int isel;
    float xa = -180.0f, xe = 180.0f, xor = -180.0f, xstp = 60.0f, 
          ya =  -90.0f, ye =  90.0f, yor =  -90.0f, ystp = 30.0f;

    if (id != id_but) return;  

    isel = dislin::gwglis (id_lis);
    dislin::setxid (id_draw, "widget");
    dislin::metafl ("xwin");
    dislin::disini ();
    dislin::erase ();
    dislin::hwfont ();

    if (isel >=4 && isel <= 7) 
      dislin::noclip ();
    else if (isel == 2)
    { ya = -85.0f;
      ye = 85.0f;
      yor = -60.0f;
    }
    else if (isel >= 8 && isel <= 10)
    { ya = 0.0f;
      ye = 90.0f;
      yor = 0.0f;
    }

    dislin::labdig (-1, "xy");
    dislin::name ("Longitude", "x");
    dislin::name ("Latitude", "y");

    dislin::projct (cl2[isel-1]);
    dislin::grafmp (xa, xe, xor, xstp, ya, ye, yor, ystp);
    dislin::gridmp (1,1);
    dislin::color ("green");
    dislin::world ();
    dislin::errmod ("Protocol", "Off");
    dislin::disfin ();
}
