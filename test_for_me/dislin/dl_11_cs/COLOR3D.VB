Imports System
Imports System.Text

Public Class App
  Public Shared Sub Main ()

  Const [N] As Integer = 100
  Dim zmat(100,100) As Single
  Dim x, y, stp, fpi As Single
  Dim i, j As Integer

  fpi = 3.1415926f / 180
  stp = 360.0f / [N]
  
  For i = 0 To [N]
    x = i * stp
    For j = 0 To [N]
      y = j * stp
      zmat (i,j) = 2 * Math.Sin (x * fpi) * Math.Sin (y * fpi)
    Next j
  Next i

  dislin.metafl ("xwin")
  dislin.disini ()
  dislin.pagera ()
  dislin.hwfont ()

  dislin.titlin ("3-D Colour Plot of the Function", 1)
  dislin.titlin ("F(X,Y) = 2 * SIN(X) * SIN(Y)", 3)
  dislin.name ("X-axis", "X")
  dislin.name ("Y-axis", "Y")
  dislin.name ("Z-axis", "Z")

  dislin.axspos (300, 1850)
  dislin.ax3len (2200, 1400, 1400)

  dislin.intax ()    
  dislin.autres (n, n)
  dislin.graf3 (0.0f, 360.0f, 0.0f, 90.0f, 0.0f, 360.0f, 0.0f, 90.0f, _
        -2.0f, 2.0f, -2.0f, 1.0f)
  dislin.crvmat (zmat, [N] + 1, [N] + 1, 1, 1) 

  dislin.height (50)
  dislin.title ()
  dislin.disfin ()

  End Sub
End Class
