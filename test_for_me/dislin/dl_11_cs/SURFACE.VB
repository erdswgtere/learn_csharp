Imports System
Imports System.Text

Public Class App
  Public Shared Sub Main ()

  Const [N] As Integer = 50
  Dim zmat([N],[N]) As Single
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
  dislin.setpag ("da4p")
  dislin.disini ()
  dislin.pagera ()
  dislin.hwfont ()

  dislin.titlin ("Surface Plot of the Function", 2)
  dislin.titlin ("F(X,Y) = 2 * SIN(X) * SIN(Y)", 4)

  dislin.axspos (200, 2600)
  dislin.axslen (1800, 1800)

  dislin.name ("X-axis", "X")
  dislin.name ("Y-axis", "Y")
  dislin.name ("Z-axis", "Z")

  dislin.view3d (-5.0f, -5.0f, 4.0f, "ABS")
  dislin.graf3d (0.0f, 360.0f, 0.0f, 90.0f, 0.0f, 360.0f, 0.0f, 90.0f, _
        -3.0f, 3.0f, -3.0f, 1.0f)
  dislin.height (50)
  dislin.title ()

  dislin.surmat (zmat, [N] + 1, [N] + 1, 1, 1) 
  dislin.disfin ()

  End Sub
End Class
