#using <mscorlib.dll>
#using <disnet.dll>

using namespace System;

void main ()
{ int n = 50, i, j;
  double fpi = 3.1415926/180., step, x, y;

  // new style (MS Studio 2005, 2008)
  array<float,2>^  zmat = gcnew array<float,2> (n,n);

  // old style (MS Studio 2003 .NET)
  //  Single  zmat[,] = __gc new Single [n,n];

  step = 360./(n-1);
  for (i = 0; i < n; i++)
  { x = i*step;
    for (j = 0; j < n; j++)
    { y = j*step;
      zmat[i,j] = (float) (2*Math::Sin(x*fpi)*Math::Sin(y*fpi));
    }
  }

  dislin::metafl ("xwin");
  dislin::setpag ("da4p");
  dislin::disini ();
  dislin::pagera ();
  dislin::hwfont ();

  dislin::titlin ("Surface Plot of the Function", 2);
  dislin::titlin ("F(X,Y) = 2 * SIN(X) * SIN(Y)", 4);

  dislin::axspos (200, 2600);
  dislin::axslen (1800, 1800);

  dislin::name ("X-axis", "X");
  dislin::name ("Y-axis", "Y");
  dislin::name ("Z-axis", "Z");

  dislin::view3d (-5.0f, -5.0f, 4.0f, "ABS");
  dislin::graf3d (0.f, 360.f, 0.f, 90.f, 0.f, 360.f, 0.f, 90.f, 
        -3.f, 3.f, -3.f, 1.f);
  dislin::height (50);
  dislin::title ();

  dislin::color ("green");
  dislin::surmat(zmat,n,n,1,1);
  dislin::disfin ();
}  
