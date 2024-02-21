Imports System
Imports System.Text

Public Class Legend
  Public Shared Sub Main ()

  Const [N] As Integer = 300
  Dim xray([N]), y1ray([N]), y2ray([N]) As Single
  Dim x, stp, fpi As Single
  Dim i, nx, ny As Integer
  Dim cbuf As New StringBuilder (80)

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
  dislin.xaxgit ()
  dislin.title ()

  dislin.chncrv ("Line")
  dislin.curve (xray, y1ray, [N] + 1)
  dislin.curve (xray, y2ray, [N] + 1)

  dislin.legini (cbuf, 2, 7)
  nx = dislin.nxposn (190.0f)
  ny = dislin.nyposn (0.75f)
  dislin.legpos (nx, ny)
  dislin.leglin (cbuf, "sin (x)", 1)

  dislin.leglin (cbuf, "cos (x)", 2)
  dislin.legtit ("Legend")
  dislin.legend (cbuf, 3)

  dislin.disfin ()

  End Sub
End Class
