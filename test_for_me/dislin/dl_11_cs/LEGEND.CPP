#using <mscorlib.dll>
#using <disnet.dll>

using namespace System;
using namespace System::Text;

void main ()
{ int n = 100, i, nx, ny;
  double fpi = 3.1415926/180., step, x;

  // new style (MS Studio 2005, 2008)
  array<float>^  xray = gcnew array<float> (n);
  array<float>^  y1ray = gcnew array<float> (n);
  array<float>^  y2ray = gcnew array<float> (n);
  StringBuilder^ cbuf = gcnew StringBuilder (80);

  // old style (MS Studio 2003 .NET)
  // Single  xray[] = __gc new Single [n];
  // Single  y1ray[] = __gc new Single [n];
  // Single  y2ray[] = __gc new Single [n];
  // StringBuilder *cbuf = __gc new StringBuilder (80);
 
  step = 360. / (n-1);
  for (i = 0; i < n; i++)
  { xray[i] = (float) (i * step);
    x = xray[i] * fpi;
    y1ray[i] = (float) Math::Sin(x);
    y2ray[i] = (float) Math::Cos(x);
  }

  dislin::metafl ("xwin");
  dislin::disini ();
  dislin::complx ();

  dislin::axspos (450,1800);
  dislin::axslen (2200,1200);

  dislin::axspos (450, 1800);
  dislin::axslen (2200, 1200);

  dislin::name ("X-axis", "X");
  dislin::name ("Y-axis", "Y");

  dislin::labdig (-1, "X");
  dislin::ticks (10, "XY");

  dislin::titlin ("Demonstration of CURVE", 1);
  dislin::titlin ("SIN(X), COS(X)", 3);

  dislin::graf(0.f, 360.f, 0.f, 90.f, -1.f, 1.f, -1.f, 0.5f);
  dislin::title ();
  dislin::xaxgit();

  dislin::chncrv ("both");
  dislin::curve(xray, y1ray,n);
  dislin::curve(xray, y2ray,n);

  dislin::legini (cbuf, 2, 7);
  nx = dislin::nxposn (190.0f);
  ny = dislin::nyposn (0.75f);
  dislin::legpos (nx, ny);
  dislin::leglin (cbuf, "sin (x)", 1);

  dislin::leglin (cbuf, "cos (x)", 2);
  dislin::legtit ("Legend");
  dislin::legend (cbuf, 3);

  dislin::disfin ();
}  
