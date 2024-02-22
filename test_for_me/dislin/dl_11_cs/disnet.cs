/******************************************************************/
/**                         disnet.cs                            **/
/**                                                              **/
/** Dislin interface for .NET.                                   **/
/**                                                              **/
/** Date     : 15.03.2023                                        **/
/** Version  : 11.5 / Windows, 32- and 64-bit, single precision. **/
/******************************************************************/

using System.Runtime.InteropServices;
using System;
using System.Text;

public delegate float SurfunCB (float x, float y);
public delegate float SurfcpCB (float x, float y, int iopt);
public delegate void  SetcbkCB (ref float x, ref float y);
public delegate void  WincbkCB (int id, int nx, int ny, int nw, int nh);
public delegate void  SwgcbkCB (int i);
public delegate void  Swgcb2CB (int i, int irow, int icol);
public delegate void  Swgcb3CB (int i, int ival);
public delegate void  PiecbkCB (int iseg, float xdat, float xper,
                 ref int nrad, ref int noff, ref float a, ref int nvx,
                 ref int nvy, ref int idrw, ref int iann);

public class dislin {
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void abs3pt (float x, float y, float z, 
         ref float xp, ref float yp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void addlab (string cstr, float v, int itic, 
         string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void  angle (int ngrad);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void  arcell (int nx, int ny, int na, int nb, 
         float a, float b, float t);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void areaf (int [] nxray, int [] nyray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void autres (int ixdim, int iydim);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void autres3d (int ixdim, int iydim, int izdim);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void ax2grf ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void ax3len (int nxl, int nyl, int nzl);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
     public static extern void axclrs (int nclr, string copt, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void axends (string cstr, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void axgit  ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void axis3d (float x3, float y3, float z3);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void axsbgd (int nclr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void axsers ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void axslen (int nxl, int nyl);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void axsorg (int nxa, int nya);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void axspos (int nxa, int nya);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void axsscl (string cscl, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void axstyp (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void barbor (int iclr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void barclr (int ic1, int ic2, int ic3);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void bargrp (int ngrp, float gap);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void barmod (string cmod, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void baropt (float xf, float ang); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
     public static extern void barpos (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void bars   (float [] xray, float [] y1ray, 
          float [] y2ray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void bars3d   (float [] xray, float [] yray, 
          float [] z1ray, float [] z2ray, float [] xwray, 
          float [] ywray, int [] icray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void bartyp (string ctyp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void barwth (float factor);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void basalf (string calph);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void basdat (int id, int im, int iy); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void bezier (float [] xray, float [] yray, int nray,
         float [] x, float [] y, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern short bitsi2 (int nbits, short mher, int iher, short mhin,
      int ihin);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int bitsi4 (int nbits, int mher,int iher, int mhin, 
        int ihin);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void bmpfnt (string cfont);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void bmpmod (int n, string cval, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void box2d  ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void box3d  ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void bufmod (string cmod, string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void center ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void cgmbgd (float xr, float xg, float xb);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void cgmpic (string cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void cgmver (int nclr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void chaang (float angle);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void chacod (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void chaspc (float xspc);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void chawth (float xwth);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void chnatt ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void chncrv (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void chndot ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void chndsh ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void chnbar (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void chnpie (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void circ3p (float x1, float y1, float x2,
       float y2, float x3, float y3, ref float xm, ref float ym, ref float r);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void circle (int nx, int ny, int nr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void circsp (int nspc);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void clip3d (string ctyp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int closfl (int nu); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void clpbor (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void clpmod (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void clpwin (int nx, int ny, int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void clrcyc (int index, int iclr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void clrmod (string cmode);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void clswin (int id);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void color  (string col);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void colran (int nca, int nce);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void colray (float [] zray, int [] nray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void complx ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void conclr (int [] nray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void concrv (float [] xray, float [] yray, int n,
      float zlev);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void cone3d (float xm, float ym, float zm, 
       float r, float h1, float h2, int n, int m);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void confll (float [] xray, float [] yray, 
       float [] zray, int n, int [] i1ray, int [] i2ray, int [] i3ray, 
       int ntri, float [] zlev, int nlev);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void congap (float xfac);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
     public static extern void conlab (string clab);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void conmat (float [,] zmat, int n, int m, 
      float zlev);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void conmod (float xfac, float xquot);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void conn3d (float x, float y, float z);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void connpt (float x, float y);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void conpts (float [] xray, int n, float []yray,
       int m, float [,] zmat, float zlev, float [] xpts, float [] ypts,
       int maxpts, int [] nray, int maxray, ref int nlins);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void conshd (float [] xray, int n, float [] yray,
      int m, float [,] zmat, float [] zlev, int nlev);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void conshd2 (float [,] xmat, float [,] ymat,
      float [,] zmat, int n, int m, float [] zlev, int nlev);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void conshd3d (float [] xray, int n, float [] yray,
      int m, float [,] zmat, float [] zlev, int nlev);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void contri (float [] xray, float [] yray, 
       float [] zray, int n, int [] i1ray, int [] i2ray, int [] i3ray,
       int ntri, float zlev);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void contur (float [] xray, int n, float [] yray,
       int m, float [,] zmat, float zlev);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void contur2 (float [,] xmat, float [,] ymat,
       float [,] zmat, int n, int m, float zlev);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void  cross  ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void  crvmat (float [,] zmat, int n, int m, 
      int ixpts, int iypts);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void crvqdr (float [] xray, float [] yray, 
       float [] zray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void crvt3d (float [] xray, float [] yray, 
       float [] zray, float [] rray, int [] icray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void crvtri (float [] xray, float [] yray, 
      float [] zray, int n, int [] i1ray, int [] i2ray, int [] i3ray, 
      int ntri);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void csrlin (ref int ix1, ref int iy1,
                                      ref int ix2, ref int iy2);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void csrmod (string cmod, string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int csrpos (ref int ix, ref int iy);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int csrkey ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void csrpol (int [] ix, int [] iy, int nmax, 
       ref int n, ref int iret);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void csrpt1 (ref int ix, ref int iy);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void csrrec (ref int ix1, ref int iy1,
                                      ref int ix2, ref int iy2);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void csrpts (int [] ix, int [] iy, int nmax, 
       ref int n, ref int iret);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void csrmov (int [] ix, int [] iy, int nmax, 
      ref int n, ref int iret);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void csrtyp (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void csruni (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int dwgbut (string cstr, int ival);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int dwgerr ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern string dwgfil (string clab, string cstr, 
      string cmask);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int dwglis (string clab, string clis, int ilis);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void dwgmsg (string cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern string dwgtxt (string clab, string cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void curv3d (float [] xray, float [] yray, 
       float [] zray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void curv4d (float [] xray, float [] yray, 
       float [] zray, float [] wray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void curve  (float [] xray, float [] yray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void curve3 (float [] xray, float [] yray, 
        float [] zray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void curvmp (float [] xray, float [] yray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void curvx3 (float [] xray, float y, 
        float [] zray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void curvy3 (float x, float [] yray, 
        float [] zray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void cyli3d (float xm, float ym, float zm, 
       float r, float h, int n, int m);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void dash   ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void dashl  ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void dashm  ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
     public static extern void dattim (string cdate, string ctime);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void dbffin ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int dbfini ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void dbfmod(string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void delglb (); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
     public static extern void digits (int ndig, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void disalf ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void disenv (string cfil);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void disfin (); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void disini (); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void disk3d (float xm, float ym, float zm, 
       float r1, float r2, int n, int m);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void doevnt ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void dot ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void dotl ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void duplx ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void ellips (int nx, int ny, int na, int nb);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void endgrf ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void erase  ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void errbar (float [] x, float [] y, 
        float [] err1, float [] err2, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void errdev (string cdev);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void errfil (string cfil);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void errmod (string cstr, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void eushft (string cnat, string cshf);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void expimg (string cstr, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void expzlb (string cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void fbars (float [] xray, float [] y1ray, 
        float [] y2ray, float [] y3ray, float [] y4ray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int fcha  (float x, int ndig, StringBuilder cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void field  (float [] xray, float [] yray,
              float [] uray, float [] vray, int n, int ivec);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void field3d  (float [] x1ray, float [] y1ray,
              float [] z1ray, float [] x2ray, float [] y2ray, float [] z2ray,
              int n, int ivec);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void filbox (int nx, int ny, int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void filclr (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void filmod (string cmod);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void filopt (string copt, string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int filsiz (string cfil, ref int nw, ref int nh); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int filtyp (string cfl);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void filwin (int nx, int ny, int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void fitscls  ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern float fitsflt (string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int fitshdu (int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int fitsimg (byte [] iray, int nmax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int fitsopn (string cfl);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void fitsstr (string ckey, StringBuilder s, int nmax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int fitstyp (string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int fitsval (string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void fixspc (float xfac);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void flab3d ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int flen (float x, int ndig);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void frame  (int nfrm);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void frmclr  (int nclr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void frmbar (int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void frmess (int nfrm);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void gapcrv (float xgap);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void gapsiz (float x, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void gaxpar (float a1, float a2, string copt,
               string cax, ref float a, ref float b, 
               ref float or, ref float stp, ref int ndig);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern string getalf ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int getang ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int getbpp ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getclp (ref int nx, ref int ny, 
       ref int nw, ref int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern  int getclr ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getdig (ref int nxdig, ref int nydig, 
      ref int nzdig);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern string getdsp ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern string getfil ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void getgrf (ref float a, ref float e, 
       ref float org, ref float step, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int gethgt ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int gethnm ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getico (float x, float y, 
       ref float xp, ref float yp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getind (int index, ref float xr, 
       ref float xg, ref float xb);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void getlab (StringBuilder cx, StringBuilder cy,
      StringBuilder cz);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void getlen (ref int i1, ref int i2, ref int i3); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int getlev ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int getlin ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int getlit (float xp, float yp, float zp,
              float xn, float yn, float zn);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getmat (float [] xray, float [] yray, 
      float [] zray, int n, float [,] zmat, int nx, int ny, float zval, 
      int [,] imat, float [,] wmat);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern string getmfl ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern  string getmix (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getor  (ref int nx0, ref int ny0);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getpag (ref int nxpag, ref int nypag);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int getpat ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int getplv ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getpos (ref int nxa, ref int nya);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getran (ref int nca, ref int nce);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getrco (float x, float y, 
       ref float xp, ref float yp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getres (ref int npb, ref int nph);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getrgb (ref float xr, ref float xg, 
      ref float xb);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getscl (ref int nxscl, ref int nyscl, 
      ref int nzscl);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getscm (ref int ix, ref int iy, ref int iz);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getscr (ref int nwidth, ref int nheight);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern string getshf (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getsp1 (ref int nxdis, ref int nydis, 
       ref int nzdis);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void getsp2 (ref int nxdis, ref int nydis, 
        ref int nzdis);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void getsym (ref int nxsym, ref int nysym);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void gettcl (ref int nmaj, ref int nmin);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void gettic (ref int nxtic, ref int nytic, 
      ref int nztic);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern int gettyp ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern float getver ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getvk  (ref int nv, ref int nvfx, ref int nvfy);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern string getvlt ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int getwid ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getwin (ref int ix, ref int iy, 
       ref int nwidth, ref int nheight);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int getxid (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void gifmod (string cmod, string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int gmxalf (string copt, StringBuilder ca, 
       StringBuilder cb);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void gothic ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void grace  (int ngrace);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void graf (float xa, float xe, float xor, float xstp,
        float ya, float ye, float yor, float ystp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void graf3 (float xa, float xe, float xor, float xstp,
              float ya, float ye, float yor, float ystp,
              float za, float ze, float zor, float zstp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void graf3d (float xa, float xe, float xor, 
              float xstp, float ya, float ye, float yor, float ystp,
              float za, float ze, float zor, float zstp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void grafmp (float xa, float xe, float xor, 
              float xstp, float ya, float ye, float yor, float ystp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void grafp (float xe, float xorg, float xstp, 
       float yorg, float ystp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void grafr  (float [] xray, int n, 
       float [] yray, int m);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void grdpol (int ixgrid, int iygrid);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void grfimg (string cfil);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void grffin ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void grfini (float x1, float y1, float z1,
              float x2, float y2, float z2, 
              float x3, float y3, float z3);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void grid   (int ixgrid, int iygrid);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void grid3d (int ixgrid, int iygrid, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void gridim  (float x1, float x2, float x3, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void gridmp (int ixgrid, int iygrid);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void gridre  (float x1, float x2, float x3, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int gwgatt (int id, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int gwgbox (int id);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int gwgbut (int id);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void gwgfil (int id, StringBuilder cfile);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern float gwgflt (int id);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int gwggui ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int gwgint (int id);
 [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int gwglis (int id);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern float gwgscl (int id);
   [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void gwgsiz (int id, ref int nw, ref int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern float gwgtbf (int id, int irow, int icol);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int gwgtbi (int id, int irow, int icol);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void gwgtbl (int id, float [] xray, int n,
                         int idx, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void gwgtbs (int id, int irow, int icol, 
                         StringBuilder ctext);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void gwgtxt (int id, StringBuilder ctext);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int gwgxid (int id);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void height (int nhchar);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void helve  ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void helves ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void helvet ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void hidwin  (int id, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void histog (float [] xray, int n, 
      float [] x, float [] y, ref int m);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void hname  (int nhchar);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void hpgmod (string cmod, string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void hsvrgb (float  xh, float  xs, float  xv, 
              ref float xr, ref float xg, ref float xb);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void hsym3d (float h);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void hsymbl (int nhsym);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void htitle (int nhtit);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void hwfont ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void hwmode (string cmod, string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void hworig (int nx, int ny);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void hwpage (int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void hwscal (float xfac);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void imgbox (int nx, int ny, int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void imgclp (int nx, int ny, int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void imgfin ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void imgfmt (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void imgini ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void imgmod (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void imgtpr (int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void imgsiz (int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void inccrv (int ncrv);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int incdat (int id, int im, int iy);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void incfil (string cfil);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void incmrk (int nmrk);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int indrgb (float xr, float xg, float xb);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void intax  ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int intcha (int nx, StringBuilder cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int intlen (int nx);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int intrgb (float xr, float xg, float xb);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int intutf  (int [] iray, int nray, 
        StringBuilder cstr, int nmax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void isopts (float [] xray, int nx, 
      float [] yray, int ny, float [] zray, int nz, float [,,] wmat, 
      float wlev, float [] xtri, float [] ytri, float [] ztri, int nmax,
      ref int ntri);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void itmcat (StringBuilder clis, string cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void itmncat (StringBuilder clis, int nmx, 
      string cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int itmcnt (string clis);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern string itmstr (string clis, int nlis);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void jusbar (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void labclr (int iclr, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void labdig (int ndig, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void labdis (int ndis, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void labels (string clab, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void labjus (string copt, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void labl3d (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void labmod (string ckey, string cval, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void labpos (string cpos, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void labtyp (string ctyp, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int ldimg (string cfl, short [] iray, 
                   int nmax, int nc);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void legbgd (int ncol);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void legclr ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void legend (StringBuilder cbuf, int ncor);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void legini (StringBuilder cbuf, int nlin, 
                         int nmaxln);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void leglin (StringBuilder cbuf, string cstr, 
                 int ilin);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void legopt (float x1, float x2, float x3);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void legpat (int ityp, int ithk, int isym,
      int ipat, int iclr, int ilin);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void legpos (int nx, int ny);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void legsel (int [] nray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void legtbl  (int i, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void legtit (string cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void legtyp (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void legval (float x, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void lfttit ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void licmod (string cmod, string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void licpts (float [,] xv, float [,] yv,
       int nx, int ny, int [,] itmat, int [,] iwmat, float [,] wmat);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void light(string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void linclr (int [] nray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void lincyc (int index, int ityp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void line   (int nx, int ny, int nu, int nv);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void linesp (float xfac);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void linfit  (float [] xray, float [] yray, int n,
              ref float a, ref float b, ref float r, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void linmod (string copt, string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void lintyp (int ntyp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void linwid (int i);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void litmod(int id, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void litop3(int id, 
        float xr, float xg, float xb, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void litopt(int id, float xval, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void litpos(int id, float x, float y, float z, 
      string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void lncap  (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void lnjoin (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void lnmlt  (float x);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void logtic (string cmod);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void lsechk (string cmod);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void mapbas (string cmod);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void mapfil (string cfil, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void mapimg (string cfil, float x1, float x2,
       float x3, float x4, float x5, float x6);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void maplab (string copt, string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void maplev (string cmod);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void mapmod (string cmod);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void mapopt (string copt, string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mappol (float xpol, float ypol);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mapref (float ylower, float yupper);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mapsph (float xrad);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void marker (int nsym);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void matop3(float xr, float xg, float xb, 
         string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void matopt(float xval, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mdfmat (int nx, int ny, float weight);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
     public static extern void messag (String s, int nx, int ny); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
     public static extern void metafl (string s); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mixalf ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mixleg ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern float moment (float [] xray, int n, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mpaepl (int i);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mplang (float x);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mplclr (int nbg, int nfg);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mplpos (int nx, int ny);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mplsiz (int nsize);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void mpslogo (int i1, int i2, int i3, string cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mrkclr (int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void msgbox (string cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mshclr (int ic);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mshcrv (int ic);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void mylab  (string cstr, int itick, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void myline (int [] nray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mypat  (int iang, int itype, int idens, 
         int icross);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mysymb (float [] xray, float [] yray, int n,
      int isym, int iflag);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void myvlt  (float [] xr, float [] xg, 
        float [] xb, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void namdis (int ndis, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void name   (string cstr, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
   public static extern void namjus (string copt, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void nancrv (string cmode);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void neglog (float eps);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void newmix ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void newpag ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int nlmess (string cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int nlnumb (float x, int ndig);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void noarln ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void nobar ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void nobgd  ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void nochek ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void noclip ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void nofill ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void nograf ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void nohide ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void noline (string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void number (float x, int ndig, int nx, int ny);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void numfmt (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void numode (string cdec, string cgrp, 
      string cpos, string cfix);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int nwkday (int id, int im, int iy);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int nxlegn (string cbuf);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int nxpixl (int ix, int iy);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int nxposn (float x);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int nylegn (string cbuf);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int nypixl (int ix, int iy);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int nyposn (float y);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int nzposn (float z);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int openfl (string cfil, int nu, int irw); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void opnwin (int id);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void origin (int nx0, int ny0);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void page   (int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void pagera ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pagfll (int nclr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void paghdr (string cstr1, string cstr2, 
      int iopt, int idir);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void pagmod (string cmod);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void pagorg (string cpos);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void pagwin   (int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void patcyc (int index, int ipat);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int pdfbuf (byte [] cbuf, int nmax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void pdfmod (string cmod, string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void pdfmrk (string cfil, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void penwid (float x);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pie (int nxm, int nym, int nr, float a, float b);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void piebor (int iclr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void piecbk (PiecbkCB cb);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pieclr (int [] ic1, int [] ic2, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pieexp ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void piegrf (string cbuf, int nlin, 
      float [] xray, int nseg);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void pielab (string clab, string cpos);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pieopt (float xf, float a);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pierot (float angle);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void pietyp (string ctyp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void pieval(float xval, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void pievec (int ivec, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)]
    public static extern void pike3d (float x1, float y1, float z1, 
       float x2, float y2, float z2, float r, int n, int m);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void plat3d (float xm, float ym, float zm, 
       float xl, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void plyfin (string cfil, string cobj);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void plyini (string ctyp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void pngmod (string cmod, string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void point  (int nx, int ny, int nb, int nh, int ncol);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void polar (float xe, float xorg, float xstp, 
       float yorg, float ystp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int polclp (float [] xray, float [] yray, int nray,
         float [] x, float [] y, int nmax, float xv, string cedge);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void polcrv (string cpol);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void polmod (string cpos, string cdir);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pos2pt (float x, float y, 
       ref float xp, ref float yp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pos3pt (float x, float y, float z, 
       ref float xp, ref float yp, ref float zp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void posbar (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int posifl (int nu, int nbyte); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void proj3d (string cproj);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void projct (string cproj);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void psfont (string cfont);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void psmode (string cfont);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pt2pos (float x, float y, 
       ref float xp, ref float yp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pyra3d (float xm, float ym, float zm, 
       float xl, float h1, float h2, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void qplcrv  (float [] xray, float [] yray, int n,
                string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void qplot  (float [] xray, float [] yray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void qplsca (float [] xray, float [] yray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void qplpie (float [] xray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void qplbar (float [] yray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void qplclr (float [,] zmat, int n, int m);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void qplscl  (float a, float b, float or,
             float step, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void qplsur (float [,] zmat, int n, int m);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void qplcon (float [,] zmat, int n, int m, int nlv);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void quad3d (float xm, float ym, float zm, 
       float xl, float yl, float zl);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int rbfpng (byte [] cbuf, int nmax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void rbmp   (string cfil);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int readfl (int nu, byte [] cbuf, int nbyte); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void reawgt ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void recfll (int nx, int ny, int nw, int nh, 
       int ncol);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rectan (int nx, int ny, int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rel3pt (float x, float y, float z, 
      ref float xp, ref float yp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void resatt ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void reset  (string cname);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void revscr ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rgbhsv (float xr, float xg, float xb, 
      ref float xh, ref float xs, ref float xv);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void rgif   (string cfil);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rgtlab ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void rimage (string cfil);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlarc  (float xm, float ym, float xa, float xb,
              float a,  float b,  float t);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlarea (float [] xray, float [] yray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlcirc (float xm, float ym, float r);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlconn (float x, float y);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlell  (float xm, float ym, float a, float b);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rline  (float x, float y, float u, float v);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void rlmess (string cstr, float x, float y);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlnumb (float x, int ndig, float xp, float yp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlpie  (float xm, float ym, float r, 
      float a, float b);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlpoin (float x, float y, int nb, int nh, 
      int ncol);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlrec  (float x, float y, float xw, float xh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlrnd  (float x, float y, float xb, float xh,
      int irnd);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlsec  (float xm, float ym, float r1, float r2,
       float a,  float b,  int ncol);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlstrt (float x, float y);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlsymb (int nsym, float x, float y);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlvec  (float x1, float y1, float x2, 
      float y2, int ivec);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlwind (float xk, float x, float y, 
      int nwidth, float a);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rndrec (int nx, int ny, int nb, 
      int nh, int irnd);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rot3d (float x, float y, float z);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rpixel (int ix, int iy, ref int iclr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rpixls (byte [] iray, int ix, int iy, 
      int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void rpng   (string cfil);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void rppm   (string cfil);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rpxrow (byte [] iray, int ix, int iy, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void rtiff  (string cfil);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rvynam ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void scale  (string cscl, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void sclfac (float xfac);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void sclmod (string cmode);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void scrmod (string cmode);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void sector (int nx, int ny, int nr1, 
      int nr2, float a, float b, int ncol);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void selwin (int id);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void sendbf ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void sendmb ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void sendok ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void serif ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void setbas (float xfac);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void setcbk (SetcbkCB cb, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void setclr (int ncol);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void setcsr (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void setexp (float fexp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void setfil (string cfil);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void setfce (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void setgrf (string c1, string c2, 
      string c3, string c4);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void setind (int index, float xr, float xg, float xb);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void setmix (string cstr, string cmix);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void setpag (string cpag);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void setres (int npb, int nph);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void setres3d (float xl, float yl, float zl);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void setrgb (float xr, float xg, float xb);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void setscl (float [] xray, int n, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void setvlt (string cvlt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void setxid (int id, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdcha ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdcrv (float [] x1ray, float [] y1ray, int n1,
              float [] x2ray, float [] y2ray, int n2);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdafr (int [] inray, int [] ipray, 
      int [] icray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdasi (int [] inray, int [] ipray, 
      int [] icray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdaus (int [] inray, int [] ipray, 
      int [] icray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdeur (int [] inray, int [] ipray, 
      int [] icray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdfac (float xfac);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void shdmap (string cmap);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void shdmod (string copt, string ctyp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdnor (int [] inray, int [] ipray, 
      int [] icray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdpat (int ipat);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdsou (int [] inray, int [] ipray, 
      int [] icray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdusa (int [] inray, int [] ipray, 
      int [] icray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void shield (string carea, string cmode);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shlcir (int nx, int ny, int nr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shldel (int id);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shlell (int nx, int ny, int na, int nb, float t);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int shlind ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shlpie (int nx, int ny, int nr, 
      float a, float b);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shlpol (int [] nxray, int [] nyray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shlrct (int nx, int ny, int nw, int nh, float t);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shlrec (int nx, int ny, int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shlres (int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shlsur ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void shlvis (int id, string cmode);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void simplx ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int skipfl (int nu, int nbyte); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void smxalf (string calph, string c1, 
      string c2, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void solid  ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void sortr1 (float [] xray, int n, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void sortr2 (float [] xray, float [] yray, 
      int n, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void spcbar (int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void sphe3d (float xm, float ym, float zm, 
       float r, int n, int m);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void spline (float [] xray,  float [] yray,  int n,
              float [] xsray, float [] ysray, ref int nspl);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void splmod (int ngrad, int npts);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void stmmod (string cmod, string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void stmopt (int n, string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void stmpts (float [,] xv, float [,] yv,
       int nx, int ny, float [] xp, float [] yp, float x0, float y0,
       float [] xray, float [] yray, int nmax, ref int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void stmpts3d (float [,,] xv, float [,,] yv,
       float [,,] zv, int nx, int ny, int nz, float [] xp, float [] yp, 
       float [] zp, float x0, float y0, float z0,
       float [] xray, float [] yray, float [] zray, int nmax, ref int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void stmtri (float [] xv, float [] yv,
       float [] xp, float [] yp, int n, int [] i1ray, int [] i2ray,
       int [] i3ray, int ntri, float [] xs, float [] ys, int nray);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void stmval (float x, string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void stream (float [,] xv, float [,] yv,
       int nx, int ny, float [] xp, float [] yp, float [] xs, float [] ys,
       int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void stream3d (float [,,] xv, float [,,] yv,
       float [,,] zv, int nx, int ny, int nz, float [] xp, float [] yp, 
       float [] zp, float [] xs, float [] ys, float [] zs, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void strt3d (float x, float y, float z);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void strtpt (float x, float y);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void surclr (int ictop, int icbot);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void surfce (float [] xray, int n, 
       float [] yray, int m, float [,] zmat);
  [DllImport ("dislnc.dll", CallingConvention=CallingConvention.Cdecl)]
     public static extern void surfcp (SurfcpCB cb, float a1, float a2, 
        float astp, float b1, float b2, float bstp);
  [DllImport ("dislnc.dll", CallingConvention=CallingConvention.Cdecl)]
    public static extern void surfun (SurfunCB cb, int ix, float x, int iy,
      float y);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void suriso (float [] xray, int nx, 
      float [] yray, int ny, float [] zray, int nz, float [,,] wmat, 
      float wlev);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void surmat (float [,] zmat, int nx, int ny, 
       int ixpts, int iypts);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void surmsh (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void suropt (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void surshc (float [] xray, int n, 
       float [] yray, int m, float [,] zmat, float [,] wmat);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void surshd (float [] xray, int n, 
       float [] yray, int m, float [,] zmat);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void sursze (float xmin, float xmax, 
       float ymin, float ymax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void surtri (float [] xray, float [] yray, 
      float [] zray, int n, int [] i1ray, int [] i2ray, int [] i3ray, int ntri);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void survis (string cvis);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swapi2 (short [] iray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swapi4 (int [] iray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgatt (int id, string cval, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)]
    public static extern void swgbgd (int id, float xr, float xg, float xb);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgbox (int id, int ival);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgbut (int id, int ival);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgcb2 (int id, Swgcb2CB cb);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgcb3 (int id, Swgcb3CB cb);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgcbk (int id, SwgcbkCB cb);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgclr (float xr, float xg, float xb,
      string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgdrw (float x);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)]
    public static extern void swgfgd (int id, float xr, float xg, float xb);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgfil (int id, string cval);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgfnt (string cfnt, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgfoc (int id);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swghlp (string cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgjus (string ctyp, string cwidg);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swglis (int ip, int ival);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgmix (string c, string cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgmod (string cmod);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
   public static extern void swgmrg (int ival, string cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgoff (int nx, int ny);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgopt (string cval, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgpop (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgpos (int nx, int ny);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgscl (int ip, float xval);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgval (int ip, float xval);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgint (int ip, int iv);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
     public static extern void swgiop (int n, string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgflt (int ip, float xval, int ndig);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgsiz (int nx, int ny);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgspc (float xw, float xh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgstp (float step);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgtbf (int ip, float xv, int ndig, 
                              int irow, int icol, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgtbi (int ip, int iv,  
                              int irow, int icol, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgtbl (int ip, float [] xray, int n, int ndig,  
                              int idx, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgtbs (int ip, string cstr,  
                              int irow, int icol, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgtit (string ctit);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgtxt (int ip, string cval);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgtyp (string ctyp, string cwidg);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgwin (int nx, int ny, int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgwth (int nchar);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void symb3d (int n, float xm, float ym, float zm); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void symbol (int nsym, int nx, int ny);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void symfil (string cdev, string cstat);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void symrot (float angle);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int tellfl (int nu); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void texmod (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void texopt (string copt, string ctyp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void texval(float xval, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void thkc3d (float x);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void thkcrv (int nthk);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void ticks  (int itick, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void thrfin (); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void thrini (int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void ticlen (int nmaj, int nmin);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void ticmod (string copt, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void ticpos (string cpos, string cax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void tifmod (int n, string cval, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tiforg (int nx, int ny);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tifwin (int nx, int ny, int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void timopt ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void titjus (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void title  ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void titlin (string cstr, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void titpos (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void torus3d (float xm, float ym, float zm, 
       float r1, float r2, float h, float a1, float a2, int n, int m);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tprini ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tprfin ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void tprmod (string copt, string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tprval (float x);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tr3axs (float x, float y, float z, float a);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tr3res ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tr3rot (float x, float y, float z);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tr3scl (float xscl, float yscl, float zscl);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tr3shf (float x, float y, float z);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void trfco1 (float [] xray, int n, 
      string cfrom, string cto); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void trfco2 (float [] xray, float [] yray, 
      int n, string cfrom, string cto); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void trfco3 (float [] xray, float [] yray, 
      float [] zray, int n, string cfrom, string cto);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void trfdat (int ndays, ref int id, 
      ref int im, ref int iy); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void trfmat (float [,] zmat, int nx, int ny, 
      float [,] zmat2, int nx2, int ny2);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void trfrel (float [] xray, float [] yray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void trfres ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void trfrot (float xang, int nx, int ny);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void trfscl (float xscl, float yscl);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void trfshf (int nx, int ny);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tria3d (float [] x, float [] y, float [] z);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int triang (float [] xray, float [] yray, int n,
       int [] i1ray, int [] i2ray, int [] i3ray, int nmax); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void triflc (float [] xray, float [] yray, 
        int [] iray, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void trifll  (float [] xray, float [] yray);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void triplx ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int  trmlen (string cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tripts (float [] xray, float [] yray, 
       float [] zray, int n, int [] i1ray, int [] i2ray, int [] i3ray,
       int ntri, float zlev, float [] xpts, float [] ypts,
       int maxpts, int [] nray, int maxray, ref int nlins);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void ttfont (string cfont);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tube3d (float x1, float y1, float z1, 
       float x2, float y2, float z2, float r, int n, int m);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void txtbgd  (int nclr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void txtjus (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void txture (int [,] imat, int nx, int ny); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void units  (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void upstr  (StringBuilder cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int utfint  (StringBuilder cstr, 
           int [] iray, int nray);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vang3d (float a);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vclp3d (float x1, float x2);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vecclr (int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vecf3d  (float [] x1ray, float [] y1ray,
              float [] z1ray, float [] x2ray, float [] y2ray, float [] z2ray,
              int n, int ivec);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vecfld  (float [] xvray, float [] yvray,
              float [] xpray, float [] ypay, int n, int ivec);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vecmat (float [,] xv, float [,] yv,
       int nx, int ny, float [] xp, float [] yp, int ivec);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vecmat3d (float [,,] xv, float [,,] yv,
       float [,,] zv, int nx, int ny, int nz, float [] xp, float [] yp, 
       float [] zp, int ivec);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void vecopt(float xval, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vector (int nx1, int ny1, int nx2, 
      int ny2, int ivec);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void vectr3 (float x1, float y1, float z1,
           float x2, float y2, float z2, int ivec);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void vfoc3d (float x, float y, float z, 
      string cview);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void view3d (float xvu, float yvu, float zvu, 
     string cvu);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vkxbar (int nvfx);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vkybar (int nvfy);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vkytit (int nvfy);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void vltfil (string cfil, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vscl3d (float x);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void vtx3d (float [] x, float [] y, float [] z,
          int n, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void vtxc3d (float [] x, float [] y, float [] z,
          int [] ic, int n, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void vtxn3d (float [] x, float [] y, float [] z,
          float [] xn, float [] yn, float [] zn, int n, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vup3d  (float a);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgapp  (int ip, string clab);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int   wgappb (int ip, byte [] iray, int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgbas  (int ip, string ctyp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgbox  (int ip, string cstr, int isel);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgbut  (int ip, string cstr, int ival);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
   public static extern int   wgcmd  (int ip, string clab, string cmd);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgdlis (int ip, string cstr, int isel);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int   wgdraw (int ip);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgfil  (int ip, string clab, string cstr, string cmask);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void wgfin ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgicon  (int ip, string clab, int nw, int nh,
                                        string cfl);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgimg  (int ip, string clab, byte [] iray, 
                                       int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgini  (string ctyp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wglab  (int ip, string cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wglis  (int ip, string cstr, int isel);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int wgltxt (int ip, string clab, string ctext,
      int iper);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int   wgok   (int ip);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgpbut (int ip, string clab);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgpicon  (int ip, string clab, int nw, int nh,
                                        string cfl);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgpimg  (int ip, string clab, byte [] iray, 
                                       int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgpop  (int ip, string clab);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int   wgpopb (int ip, byte [] iray, int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int   wgquit (int ip);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int   wgsep (int ip);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgscl  (int ip, string cstr, 
     float x1, float x2, float xval, int ndez);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)]
    public static extern int   wgpbar  (int ip, float x1, float x2, 
               float xstp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int   wgstxt (int ip, int nsize, int nmax);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int   wgtbl (int ip, int nrows, int ncols);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgtxt  (int ip, string cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void widbar (int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void wimage (string cfil);  
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void winapp (string copt);  
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void wincbk (WincbkCB cb, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void windbr (float xk, int nx, int ny, 
      int nwidth, float a);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void window (int nx, int ny, int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void winfin (int iopt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void winfnt (string cfont);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void winico (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int winid  ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void winjus (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void winkey (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void winmod (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void winopt (int iopt, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void winsiz (int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void wintit (string cstr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void wintyp (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void wmfmod (string cmod, string ckey);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void world  ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void wpixel (int ix, int iy, int iclr);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void wpixls (byte [] iray, int ix, int iy, 
      int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void wpxrow (byte [] iray, int ix, int iy, int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int   writfl (int nu, byte [] cbuf, int nbyte); 
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void wtiff  (string cfil);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void x11fnt (string cfont, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void x11mod (string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern float x2dpos (float x, float y);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern float x3dabs (float x, float y, float z);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern float x3dpos (float x, float y, float z);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern float x3drel (float x, float y, float z);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void xaxgit ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void xaxis  (float xa, float xe, float xorg, 
      float xstp, int nl, string cstr, int it, int nx, int ny);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void xaxlg  (float xa, float xe, float xorg, 
      float xstp, int nl, string cstr, int it, int nx, int ny);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void xaxmap (float xa, float xe, float xorg, 
      float xstp, string cstr, int it, int ny);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void xcross ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void xdraw  (float x, float y);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void xjdraw (float x, float y, int ipen);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern float xinvrs (int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void xmove  (float x, float y);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern float xposn  (float x);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern float y2dpos (float x, float y);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern float y3dabs (float x, float y, float z);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern float y3dpos (float x, float y, float z);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern float y3drel (float x, float y, float z);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void yaxgit ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void yaxis  (float ya, float ye, float yor, 
      float ystp, int nl, string cstr, int it, int nx, int ny);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void yaxlg  (float ya, float ye, float yor,
      float ystp, int nl, string cstr, int it, int nx, int ny);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void yaxmap (float ya, float ye, float yor, 
      float ystp, string cstr, int it, int ny);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void ycross ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern  float yinvrs (int n);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void ypolar  (float ya, float ye, float yor, 
      float ystp, string cstr, int ndist);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern float yposn  (float y);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern float z3dpos (float x, float y, float z);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void zaxis  (float za, float ze, float zor, 
      float zstp, int nl, string cstr, int it, int id, int nx, int ny);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void zaxlg  (float za, float ze, float zor, 
      float zstp, int nl, string cstr, int it, int id, int nx, int ny);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void zbfers ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void zbffin ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int zbfini ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void zbflin (float x1, float y1, float z1, 
      float x2, float y2, float z2);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void zbfmod(string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void zbfres ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void zbfscl (float x);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void zbftri (float [] x, float [] y, float [] z,
     int [] ic);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void zscale (float za, float ze);
}
