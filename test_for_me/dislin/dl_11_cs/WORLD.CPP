#using <mscorlib.dll>
#using <disnet.dll>

using namespace System;

void main ()
{
  dislin::metafl ("cons");
  dislin::disini ();
  dislin::pagera ();
  dislin::complx ();

  dislin::axspos (400, 1850);
  dislin::axslen (2400, 1400);

  dislin::name   ("Longitude", "X");
  dislin::name   ("Latitude",  "Y");
  dislin::titlin ("World Coastlines and Lakes", 3);

  dislin::labels ("MAP", "XY");
  dislin::labdig (-1, "XY");
  dislin::grafmp (-180.0f, 180.0f, -180.0f, 90.0f, 
                      -90.0f, 90.0f, -90.0f, 30.0f); 
  dislin::gridmp (1,1);
  dislin::color  ("green");
  dislin::world ();

  dislin::color  ("fore");
  dislin::height (50); 
  dislin::title ();
  dislin::disfin ();
}
