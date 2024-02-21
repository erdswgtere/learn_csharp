Imports System

Public Class App
  Public Shared Sub Main ()

  Const [N] As Integer = 300
  Dim xray([N]), y1ray([N]), y2ray([N]) As Single
  Dim x, stp, fpi As Single
  Dim i As Integer

  fpi = 3.1415926f / 180
  stp = 360.0f / ([N])
  
  For i = 0 To [N]
    xray(i) = i * stp
    x = xray(i) * fpi
    y1ray(i) =  Math.Sin (x)
    y2ray(i) =  Math.Cos (x)
  Next i

  dislin.metafl ("xwin")
  dislin.disini ()
  dislin.pagera ()
  dislin.complx ()

  dislin.axspos (450, 1800)
  dislin.axslen (2200, 1200)

  dislin.name ("X-axis", "X")
  dislin.name ("Y-axis", "Y")

  dislin.labdig (-1, "X")
  dislin.ticks (10, "XY")

  dislin.titlin ("Demonstration of CURVE", 1)
  dislin.titlin ("SIN(X), COS(X)", 3)

  dislin.graf (0.0f, 360.0f, 0.0f, 90.0f, -1.0f, 1.0f, -1.0f, 0.5f)
  dislin.title ()

  dislin.color ("red")
  dislin.curve (xray, y1ray, [N] + 1)
  dislin.color ("green")
  dislin.curve (xray, y2ray, [N] + 1)

  dislin.color ("fore")
  dislin.dash ()
  dislin.xaxgit ()
  dislin.disfin ()

  End Sub
End Class
