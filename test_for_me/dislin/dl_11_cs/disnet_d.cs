/******************************************************************/
/**                       disnet_d.cs                            **/
/**                                                              **/
/** Dislin interface for .NET.                                   **/
/**                                                              **/
/** Date     : 15.03.2023                                        **/
/** Version  : 11.5 / Windows, 32- and 64-bit, double precision. **/
/******************************************************************/

using System.Runtime.InteropServices;
using System;
using System.Text;

public delegate double SurfunCB (double x, double y);
public delegate double SurfcpCB (double x, double y, int iopt);
public delegate void  SetcbkCB (ref double x, ref double y);
public delegate void  WincbkCB (int id, int nx, int ny, int nw, int nh);
public delegate void  SwgcbkCB (int i);
public delegate void  Swgcb2CB (int i, int irow, int icol);
public delegate void  Swgcb3CB (int i, int ival);
public delegate void  PiecbkCB (int iseg, double xdat, double xper,
                 ref int nrad, ref int noff, ref double a, ref int nvx,
                 ref int nvy, ref int idrw, ref int iann);

public class dislin {
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void abs3pt (double x, double y, double z, 
         ref double xp, ref double yp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void addlab (string cstr, double v, int itic, 
         string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void  angle (int ngrad);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void  arcell (int nx, int ny, int na, int nb, 
         double a, double b, double t);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void areaf (int [] nxray, int [] nyray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void autres (int ixdim, int iydim);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void autres3d (int ixdim, int iydim, int izdim);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void ax2grf ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void ax3len (int nxl, int nyl, int nzl);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
     public static extern void axclrs (int nclr, string copt, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void axends (string cstr, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void axgit  ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void axis3d (double x3, double y3, double z3);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void axsbgd (int nclr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void axsers  ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void axslen (int nxl, int nyl);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void axsorg (int nxa, int nya);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void axspos (int nxa, int nya);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void axsscl (string cscl, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void axstyp (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void barbor (int iclr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void barclr (int ic1, int ic2, int ic3);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void bargrp (int ngrp, double gap);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void barmod (string cmod, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void baropt (double xf, double ang); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
     public static extern void barpos (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void bars   (double [] xray, double [] y1ray, 
          double [] y2ray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void bars3d   (double [] xray, double [] yray, 
          double [] z1ray, double [] z2ray, double [] xwray, 
          double [] ywray, int [] icray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void bartyp (string ctyp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void barwth (double factor);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void basalf (string calph);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void basdat (int id, int im, int iy); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void bezier (double [] xray, double [] yray, int nray,
         double [] x, double [] y, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern short bitsi2 (int nbits, short mher, int iher, short mhin,
      int ihin);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int bitsi4 (int nbits, int mher,int iher, int mhin, 
        int ihin);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void bmpfnt (string cfont);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void bmpmod (int n, string cval, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void box2d  ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void box3d  ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void bufmod (string cmod, string ckey);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void center ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void cgmbgd (double xr, double xg, double xb);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void cgmpic (string cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void cgmver (int nclr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void chaang (double angle);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void chacod (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void chaspc (double xspc);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void chawth (double xwth);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void chnatt ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void chncrv (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void chndot ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void chndsh ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void chnbar (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void chnpie (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void circ3p (double x1, double y1, double x2,
       double y2, double x3, double y3, ref double xm, ref double ym, ref double r);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void circle (int nx, int ny, int nr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void circsp (int nspc);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void clip3d (string ctyp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int closfl (int nu); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void clpbor (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void clpmod (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void clpwin (int nx, int ny, int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void clrcyc (int index, int iclr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void clrmod (string cmode);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void clswin (int id);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void color  (string col);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void colran (int nca, int nce);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void colray (double [] zray, int [] nray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void complx ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void conclr (int [] nray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void concrv (double [] xray, double [] yray, int n,
      double zlev);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void cone3d (double xm, double ym, double zm, 
       double r, double h1, double h2, int n, int m);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void confll (double [] xray, double [] yray, 
       double [] zray, int n, int [] i1ray, int [] i2ray, int [] i3ray, 
       int ntri, double [] zlev, int nlev);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void congap (double xfac);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
     public static extern void conlab (string clab);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void conmat (double [,] zmat, int n, int m, 
      double zlev);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void conmod (double xfac, double xquot);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void conn3d (double x, double y, double z);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void connpt (double x, double y);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void conpts (double [] xray, int n, double []yray,
       int m, double [,] zmat, double zlev, double [] xpts, double [] ypts,
       int maxpts, int [] nray, int maxray, ref int nlins);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void conshd (double [] xray, int n, double [] yray,
      int m, double [,] zmat, double [] zlev, int nlev);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void conshd2 (double [,] xmat, double [,] ymat,
      double [,] zmat, int n, int m, double [] zlev, int nlev);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void conshd3d (double [] xray, int n, double [] yray,
      int m, double [,] zmat, double [] zlev, int nlev);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void contri (double [] xray, double [] yray, 
       double [] zray, int n, int [] i1ray, int [] i2ray, int [] i3ray,
       int ntri, double zlev);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void contur (double [] xray, int n, double [] yray,
       int m, double [,] zmat, double zlev);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void contur2 (double [,] xmat, double [,] ymat,
       double [,] zmat, int n, int m, double zlev);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void  cross  ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void  crvmat (double [,] zmat, int n, int m, 
      int ixpts, int iypts);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void crvqdr (double [] xray, double [] yray, 
       double [] zray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void crvt3d (double [] xray, double [] yray, 
       double [] zray, double [] rray, int [] icray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void crvtri (double [] xray, double [] yray, 
      double [] zray, int n, int [] i1ray, int [] i2ray, int [] i3ray, 
      int ntri);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void csrlin (ref int ix1, ref int iy1,
                                      ref int ix2, ref int iy2);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void csrmod (string cmod, string ckey);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void csrpol (int [] ix, int [] iy, int nmax, 
       ref int n, ref int iret);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int csrpos (ref int ix, ref int iy);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int csrkey ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void csrpt1 (ref int ix, ref int iy);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void csrrec (ref int ix1, ref int iy1,
                                      ref int ix2, ref int iy2);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void csrpts (int [] ix, int [] iy, int nmax, 
       ref int n, ref int iret);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void csrmov (int [] ix, int [] iy, int nmax, 
      ref int n, ref int iret);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void csrtyp (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void csruni (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int dwgbut (string cstr, int ival);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int dwgerr ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern string dwgfil (string clab, string cstr, 
      string cmask);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int dwglis (string clab, string clis, int ilis);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void dwgmsg (string cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern string dwgtxt (string clab, string cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void curv3d (double [] xray, double [] yray, 
       double [] zray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void curv4d (double [] xray, double [] yray, 
       double [] zray, double [] wray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void curve  (double [] xray, double [] yray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void curve3 (double [] xray, double [] yray, 
        double [] zray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void curvmp (double [] xray, double [] yray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void curvx3 (double [] xray, double y, 
        double [] zray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void curvy3 (double x, double [] yray, 
        double [] zray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void cyli3d (double xm, double ym, double zm, 
       double r, double h, int n, int m);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void dash   ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void dashl  ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void dashm  ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
     public static extern void dattim (string cdate, string ctime);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void dbffin ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int dbfini ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void dbfmod(string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void delglb (); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
     public static extern void digits (int ndig, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void disalf ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void disenv (string cfil);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void disfin (); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void disini (); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void disk3d (double xm, double ym, double zm, 
       double r1, double r2, int n, int m);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void doevnt ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void dot ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void dotl ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void duplx ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void ellips (int nx, int ny, int na, int nb);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void endgrf ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void erase  ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void errbar (double [] x, double [] y, 
        double [] err1, double [] err2, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void errdev (string cdev);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void errfil (string cfil);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void errmod (string cstr, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void eushft (string cnat, string cshf);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void expimg (string cstr, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void expzlb (string cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void fbars (double [] xray, double [] y1ray, 
        double [] y2ray, double [] y3ray, double [] y4ray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int fcha  (double x, int ndig, StringBuilder cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void field  (double [] xray, double [] yray,
              double [] uray, double [] vray, int n, int ivec);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void field3d  (double [] x1ray, double [] y1ray,
              double [] z1ray, double [] x2ray, double [] y2ray, double [] z2ray,
              int n, int ivec);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void filbox (int nx, int ny, int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void filclr (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void filmod (string cmod);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void filopt (string copt, string ckey);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int filsiz (string cfil, ref int nw, ref int nh); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int filtyp (string cfl);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void filwin (int nx, int ny, int nw, int nh);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void fitscls  ();
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern double fitsflt (string ckey);
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
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void fixspc (double xfac);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void flab3d ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int flen (double x, int ndig);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void frame  (int nfrm);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void frmclr  (int nclr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void frmbar (int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void frmess (int nfrm);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void gapcrv (double xgap);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void gapsiz (double x, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void gaxpar (double a1, double a2, string copt,
               string cax, ref double a, ref double b, 
               ref double or, ref double stp, ref int ndig);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern string getalf ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int getang ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int getbpp ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getclp (ref int nx, ref int ny, 
       ref int nw, ref int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern  int getclr ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getdig (ref int nxdig, ref int nydig, 
      ref int nzdig);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern string getdsp ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern string getfil ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void getgrf (ref double a, ref double e, 
       ref double org, ref double step, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int gethgt ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int gethnm ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getico (double x, double y, 
       ref double xp, ref double yp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getind (int index, ref double xr, 
       ref double xg, ref double xb);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void getlab (StringBuilder cx, StringBuilder cy,
      StringBuilder cz);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void getlen (ref int i1, ref int i2, ref int i3); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int getlev ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int getlin ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int getlit (double xp, double yp, double zp,
              double xn, double yn, double zn);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getmat (double [] xray, double [] yray, 
      double [] zray, int n, double [,] zmat, int nx, int ny, double zval, 
      int [,] imat, double [,] wmat);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern string getmfl ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern  string getmix (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getor  (ref int nx0, ref int ny0);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getpag (ref int nxpag, ref int nypag);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int getpat ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int getplv ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getpos (ref int nxa, ref int nya);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getran (ref int nca, ref int nce);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getrco (double x, double y, 
       ref double xp, ref double yp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getres (ref int npb, ref int nph);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getrgb (ref double xr, ref double xg, 
      ref double xb);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getscl (ref int nxscl, ref int nyscl, 
      ref int nzscl);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getscm (ref int ix, ref int iy, ref int iz);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getscr (ref int nwidth, ref int nheight);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern string getshf (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getsp1 (ref int nxdis, ref int nydis, 
       ref int nzdis);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void getsp2 (ref int nxdis, ref int nydis, 
        ref int nzdis);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void getsym (ref int nxsym, ref int nysym);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void gettcl (ref int nmaj, ref int nmin);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void gettic (ref int nxtic, ref int nytic, 
      ref int nztic);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern int gettyp ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern double getver ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getvk  (ref int nv, ref int nvfx, ref int nvfy);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern string getvlt ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int getwid ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void getwin (ref int ix, ref int iy, 
       ref int nwidth, ref int nheight);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int getxid (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void gifmod (string cmod, string ckey);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int gmxalf (string copt, StringBuilder ca, 
       StringBuilder cb);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void gothic ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void grace  (int ngrace);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void graf (double xa, double xe, double xor, double xstp,
        double ya, double ye, double yor, double ystp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void graf3 (double xa, double xe, double xor, double xstp,
              double ya, double ye, double yor, double ystp,
              double za, double ze, double zor, double zstp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void graf3d (double xa, double xe, double xor, 
              double xstp, double ya, double ye, double yor, double ystp,
              double za, double ze, double zor, double zstp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void grafmp (double xa, double xe, double xor, 
              double xstp, double ya, double ye, double yor, double ystp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void grafp (double xe, double xorg, double xstp, 
       double yorg, double ystp);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void grafr  (double [] xray, int n, 
       double [] yray, int m);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void grdpol (int ixgrid, int iygrid);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void grffin ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void grfimg (string cfil);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void grfini (double x1, double y1, double z1,
              double x2, double y2, double z2, 
              double x3, double y3, double z3);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void grid   (int ixgrid, int iygrid);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void grid3d (int ixgrid, int iygrid, string copt);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void gridim  (double x1, double x2, double x3, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void gridmp (int ixgrid, int iygrid);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void gridre  (double x1, double x2, double x3, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int gwgatt (int id, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int gwgbox (int id);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int gwgbut (int id);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void gwgfil (int id, StringBuilder cfile);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern double gwgflt (int id);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int gwggui ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int gwgint (int id);
 [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int gwglis (int id);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern double gwgscl (int id);
   [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void gwgsiz (int id, ref int nw, ref int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern double gwgtbf (int id, int irow, int icol);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int gwgtbi (int id, int irow, int icol);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void gwgtbl (int id, double [] xray, int n,
                         int idx, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void gwgtbs (int id, int irow, int icol, 
                         StringBuilder ctext);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void gwgtxt (int id, StringBuilder ctext);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int gwgxid (int id);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void height (int nhchar);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void helve  ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void helves ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void helvet ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void hidwin  (int id, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void histog (double [] xray, int n, 
      double [] x, double [] y, ref int m);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void hname  (int nhchar);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void hpgmod (string cmod, string ckey);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void hsvrgb (double  xh, double  xs, double  xv, 
              ref double xr, ref double xg, ref double xb);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void hsym3d (double h);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void hsymbl (int nhsym);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void htitle (int nhtit);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void hwfont ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void hwmode (string cmod, string ckey);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void hworig (int nx, int ny);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void hwpage (int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void hwscal (double xfac);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void imgbox (int nx, int ny, int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void imgclp (int nx, int ny, int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void imgfin ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void imgfmt (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void imgini ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void imgmod (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void imgtpr (int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void imgsiz (int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void inccrv (int ncrv);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int incdat (int id, int im, int iy);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void incfil (string cfil);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void incmrk (int nmrk);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int indrgb (double xr, double xg, double xb);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void intax  ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int intcha (int nx, StringBuilder cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int intlen (int nx);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int intrgb (double xr, double xg, double xb);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int intutf  (int [] iray, int nray, 
        StringBuilder cstr, int nmax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void isopts (double [] xray, int nx, 
      double [] yray, int ny, double [] zray, int nz, double [,,] wmat, 
      double wlev, double [] xtri, double [] ytri, double [] ztri, int nmax,
      ref int ntri);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void itmcat (StringBuilder clis, string cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void itmncat (StringBuilder clis, int nmx, 
      string cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int itmcnt (string clis);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern string itmstr (string clis, int nlis);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void jusbar (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void labclr (int iclr, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void labdig (int ndig, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void labdis (int ndis, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void labels (string clab, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void labjus (string copt, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void labl3d (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void labmod (string ckey, string cval, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void labpos (string cpos, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void labtyp (string ctyp, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int ldimg (string cfl, short [] iray, 
                   int nmax, int nc);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void legbgd (int ncol);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void legclr ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void legend (StringBuilder cbuf, int ncor);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void legini (StringBuilder cbuf, int nlin, 
                         int nmaxln);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void leglin (StringBuilder cbuf, string cstr, 
                 int ilin);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void legopt (double x1, double x2, double x3);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void legpat (int ityp, int ithk, int isym,
      int ipat, int iclr, int ilin);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void legpos (int nx, int ny);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void legsel (int [] nray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void legtbl  (int i, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void legtit (string cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void legtyp (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void legval (double x, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void lfttit ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void licmod (string cmod, string ckey);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void licpts (double [,] xv, double [,] yv,
       int nx, int ny, int [,] itmat, int [,] iwmat, double [,] wmat);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void light(string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void linclr (int [] nray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void lincyc (int index, int ityp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void line   (int nx, int ny, int nu, int nv);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void linesp (double xfac);
  [DllImport("dislnc.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void linfit  (double [] xray, double [] yray, int n,
              ref double a, ref double b, ref double r, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void linmod (string copt, string ckey);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void lintyp (int ntyp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void linwid (int i);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void litmod(int id, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void litop3(int id, 
        double xr, double xg, double xb, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void litopt(int id, double xval, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void litpos(int id, double x, double y, double z, 
      string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void lncap  (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void lnjoin (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void lnmlt  (double x);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void logtic (string cmod);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void lsechk (string cmod);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void mapbas (string cmod);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void mapfil (string cfil, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void mapimg (string cfil, double x1, double x2,
       double x3, double x4, double x5, double x6);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void maplab (string copt, string ckey);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void maplev (string cmod);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void mapmod (string cmod);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void mapopt (string copt, string ckey);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mappol (double xpol, double ypol);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mapref (double ylower, double yupper);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mapsph (double xrad);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void marker (int nsym);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void matop3(double xr, double xg, double xb, 
         string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void matopt(double xval, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mdfmat (int nx, int ny, double weight);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
     public static extern void messag (String s, int nx, int ny); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
     public static extern void metafl (string s); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mixalf ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mixleg ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern double moment (double [] xray, int n, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mpaepl (int i);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mplang (double x);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mplclr (int nbg, int nfg);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mplpos (int nx, int ny);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mplsiz (int nsize);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void mpslogo (int i1, int i2, int i3, string cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mrkclr (int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void msgbox (string cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mshclr (int ic);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mshcrv (int ic);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void mylab  (string cstr, int itick, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void myline (int [] nray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mypat  (int iang, int itype, int idens, 
         int icross);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void mysymb (double [] xray, double [] yray, int n,
      int isym, int iflag);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void myvlt  (double [] xr, double [] xg, 
        double [] xb, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void namdis (int ndis, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void name   (string cstr, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
   public static extern void namjus (string copt, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void nancrv (string cmode);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void neglog (double eps);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void newmix ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void newpag ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int nlmess (string cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int nlnumb (double x, int ndig);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void noarln ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void nobar ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void nobgd  ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void nochek ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void noclip ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void nofill ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void nograf ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void nohide ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void noline (string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void number (double x, int ndig, int nx, int ny);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void numfmt (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void numode (string cdec, string cgrp, 
      string cpos, string cfix);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int nwkday (int id, int im, int iy);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int nxlegn (string cbuf);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int nxpixl (int ix, int iy);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int nxposn (double x);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int nylegn (string cbuf);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int nypixl (int ix, int iy);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int nyposn (double y);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int nzposn (double z);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int openfl (string cfil, int nu, int irw); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void opnwin (int id);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void origin (int nx0, int ny0);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void page   (int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void pagera ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pagfll (int nclr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void paghdr (string cstr1, string cstr2, 
      int iopt, int idir);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void pagmod (string cmod);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void pagorg (string cpos);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void pagwin   (int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void patcyc (int index, int ipat);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int pdfbuf (byte [] cbuf, int nmax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void pdfmod (string cmod, string ckey);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void pdfmrk (string cfil, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void penwid (double x);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pie (int nxm, int nym, int nr, double a, double b);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void piebor (int iclr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void piecbk (PiecbkCB cb);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pieclr (int [] ic1, int [] ic2, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pieexp ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void piegrf (string cbuf, int nlin, 
      double [] xray, int nseg);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void pielab (string clab, string cpos);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pieopt (double xf, double a);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pierot (double angle);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void pietyp (string ctyp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void pieval(double xval, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void pievec (int ivec, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)]
    public static extern void pike3d (double x1, double y1, double z1, 
       double x2, double y2, double z2, double r, int n, int m);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void plat3d (double xm, double ym, double zm, 
       double xl, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void plyfin (string cfil, string cobj);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void plyini (string ctyp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void pngmod (string cmod, string ckey);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void point  (int nx, int ny, int nb, int nh, int ncol);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void polar (double xe, double xorg, double xstp, 
       double yorg, double ystp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int polclp (double [] xray, double [] yray, int nray,
         double [] x, double [] y, int nmax, double xv, string cedge);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void polcrv (string cpol);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void polmod (string cpos, string cdir);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pos2pt (double x, double y, 
       ref double xp, ref double yp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pos3pt (double x, double y, double z, 
       ref double xp, ref double yp, ref double zp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void posbar (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int posifl (int nu, int nbyte); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void proj3d (string cproj);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void projct (string cproj);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void psfont (string cfont);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void psmode (string cfont);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pt2pos (double x, double y, 
       ref double xp, ref double yp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void pyra3d (double xm, double ym, double zm, 
       double xl, double h1, double h2, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void qplcrv  (double [] xray, double [] yray, int n,
                string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void qplot  (double [] xray, double [] yray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void qplsca (double [] xray, double [] yray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void qplpie (double [] xray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void qplbar (double [] yray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void qplclr (double [,] zmat, int n, int m);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void qplscl  (double a, double b, double or,
             double step, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void qplsur (double [,] zmat, int n, int m);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void qplcon (double [,] zmat, int n, int m, int nlv);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void quad3d (double xm, double ym, double zm, 
       double xl, double yl, double zl);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int rbfpng (byte [] cbuf, int nmax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void rbmp   (string cfil);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int readfl (int nu, byte [] cbuf, int nbyte); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void reawgt ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void recfll (int nx, int ny, int nw, int nh, 
       int ncol);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rectan (int nx, int ny, int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rel3pt (double x, double y, double z, 
      ref double xp, ref double yp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void resatt ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void reset  (string cname);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void revscr ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rgbhsv (double xr, double xg, double xb, 
      ref double xh, ref double xs, ref double xv);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void rgif   (string cfil);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rgtlab ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void rimage (string cfil);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlarc  (double xm, double ym, double xa, double xb,
              double a,  double b,  double t);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlarea (double [] xray, double [] yray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlcirc (double xm, double ym, double r);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlconn (double x, double y);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlell  (double xm, double ym, double a, double b);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rline  (double x, double y, double u, double v);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void rlmess (string cstr, double x, double y);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlnumb (double x, int ndig, double xp, double yp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlpie  (double xm, double ym, double r, 
      double a, double b);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlpoin (double x, double y, int nb, int nh, 
      int ncol);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlrec  (double x, double y, double xw, double xh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlrnd  (double x, double y, double xb, double xh,
      int irnd);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlsec  (double xm, double ym, double r1, double r2,
       double a,  double b,  int ncol);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlstrt (double x, double y);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlsymb (int nsym, double x, double y);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlvec  (double x1, double y1, double x2, 
      double y2, int ivec);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rlwind (double xk, double x, double y, 
      int nwidth, double a);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rndrec (int nx, int ny, int nb, 
      int nh, int irnd);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rot3d (double x, double y, double z);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rpixel (int ix, int iy, ref int iclr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rpixls (byte [] iray, int ix, int iy, 
      int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void rpng   (string cfil);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void rppm   (string cfil);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rpxrow (byte [] iray, int ix, int iy, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void rtiff  (string cfil);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void rvynam ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void scale  (string cscl, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void sclfac (double xfac);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void sclmod (string cmode);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void scrmod (string cmode);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void sector (int nx, int ny, int nr1, 
      int nr2, double a, double b, int ncol);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void selwin (int id);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void sendbf ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void sendmb ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void sendok ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void serif ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void setbas (double xfac);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void setcbk (SetcbkCB cb, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void setclr (int ncol);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void setcsr (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void setexp (double fexp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void setfil (string cfil);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void setfce (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void setgrf (string c1, string c2, 
      string c3, string c4);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void setind (int index, double xr, double xg, double xb);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void setmix (string cstr, string cmix);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void setpag (string cpag);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void setres (int npb, int nph);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void setres3d (double xl, double yl, double zl);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void setrgb (double xr, double xg, double xb);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void setscl (double [] xray, int n, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void setvlt (string cvlt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void setxid (int id, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdcha ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdcrv (double [] x1ray, double [] y1ray, int n1,
              double [] x2ray, double [] y2ray, int n2);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdafr (int [] inray, int [] ipray, 
      int [] icray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdasi (int [] inray, int [] ipray, 
      int [] icray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdaus (int [] inray, int [] ipray, 
      int [] icray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdeur (int [] inray, int [] ipray, 
      int [] icray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdfac (double xfac);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void shdmap (string cmap);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void shdmod (string copt, string ctyp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdnor (int [] inray, int [] ipray, 
      int [] icray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdpat (int ipat);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdsou (int [] inray, int [] ipray, 
      int [] icray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shdusa (int [] inray, int [] ipray, 
      int [] icray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void shield (string carea, string cmode);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shlcir (int nx, int ny, int nr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shldel (int id);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shlell (int nx, int ny, int na, int nb, double t);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int shlind ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shlpie (int nx, int ny, int nr, 
      double a, double b);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shlpol (int [] nxray, int [] nyray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shlrct (int nx, int ny, int nw, int nh, double t);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shlrec (int nx, int ny, int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shlres (int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void shlsur ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void shlvis (int id, string cmode);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void simplx ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int skipfl (int nu, int nbyte); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void smxalf (string calph, string c1, 
      string c2, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void solid  ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void sortr1 (double [] xray, int n, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void sortr2 (double [] xray, double [] yray, 
      int n, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void spcbar (int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void sphe3d (double xm, double ym, double zm, 
       double r, int n, int m);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void spline (double [] xray,  double [] yray,  int n,
              double [] xsray, double [] ysray, ref int nspl);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void splmod (int ngrad, int npts);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void stmmod (string cmod, string ckey);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void stmopt (int n, string ckey);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void stmpts (double [,] xv, double [,] yv,
       int nx, int ny, double [] xp, double [] yp, double x0, double y0,
       double [] xray, double [] yray, int nmax, ref int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void stmpts3d (double [,,] xv, double [,,] yv,
       double [,,] zv, int nx, int ny, int nz, double [] xp, double [] yp, 
       double [] zp, double x0, double y0, double z0,
       double [] xray, double [] yray, double [] zray, int nmax, ref int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void stmtri (double [] xv, double [] yv,
       double [] xp, double [] yp, int n, int [] i1ray, int [] i2ray,
       int [] i3ray, int ntri, double [] xs, double [] ys, int nray);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void stmval (double x, string ckey);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void stream (double [,] xv, double [,] yv,
       int nx, int ny, double [] xp, double [] yp, double [] xs, double [] ys,
       int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void stream3d (double [,,] xv, double [,,] yv,
       double [,,] zv, int nx, int ny, int nz, double [] xp, double [] yp, 
       double [] zp, double [] xs, double [] ys, double [] zs, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void strt3d (double x, double y, double z);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void strtpt (double x, double y);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void surclr (int ictop, int icbot);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void surfce (double [] xray, int n, 
       double [] yray, int m, double [,] zmat);
  [DllImport ("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)]
     public static extern void surfcp (SurfcpCB cb, double a1, double a2, 
        double astp, double b1, double b2, double bstp);
  [DllImport ("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)]
    public static extern void surfun (SurfunCB cb, int ix, double x, int iy,
      double y);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void suriso (double [] xray, int nx, 
      double [] yray, int ny, double [] zray, int nz, double [,,] wmat, 
      double wlev);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void surmat (double [,] zmat, int nx, int ny, 
       int ixpts, int iypts);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void surmsh (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void suropt (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void surshc (double [] xray, int n, 
       double [] yray, int m, double [,] zmat, double [,] wmat);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void surshd (double [] xray, int n, 
       double [] yray, int m, double [,] zmat);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void sursze (double xmin, double xmax, 
       double ymin, double ymax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void surtri (double [] xray, double [] yray, 
      double [] zray, int n, int [] i1ray, int [] i2ray, int [] i3ray, int ntri);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void survis (string cvis);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swapi2 (short [] iray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swapi4 (int [] iray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgatt (int id, string cval, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)]
    public static extern void swgbgd (int id, double xr, double xg, double xb);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgbox (int id, int ival);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgbut (int id, int ival);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgcb2 (int id, Swgcb2CB cb);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgcb3 (int id, Swgcb3CB cb);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgcbk (int id, SwgcbkCB cb);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgclr (double xr, double xg, double xb,
      string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgdrw (double x);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)]
    public static extern void swgfgd (int id, double xr, double xg, double xb);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgfil (int id, string cval);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgfnt (string cfnt, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgfoc (int id);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swghlp (string cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgjus (string ctyp, string cwidg);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swglis (int ip, int ival);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgmix (string c, string cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgmod (string cmod);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
   public static extern void swgmrg (int ival, string cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgoff (int nx, int ny);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgopt (string cval, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgpop (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgpos (int nx, int ny);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgscl (int ip, double xval);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgval (int ip, double xval);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgint (int ip, int iv);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
     public static extern void swgiop (int n, string ckey);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgflt (int ip, double xval, int ndig);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgsiz (int nx, int ny);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgspc (double xw, double xh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgstp (double step);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgtbf (int ip, double xv, int ndig, 
                              int irow, int icol, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgtbi (int ip, int iv,  
                              int irow, int icol, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgtbl (int ip, double [] xray, int n, int ndig,  
                              int idx, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgtbs (int ip, string cstr,  
                              int irow, int icol, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgtit (string ctit);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgtxt (int ip, string cval);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void swgtyp (string ctyp, string cwidg);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgwin (int nx, int ny, int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void swgwth (int nchar);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void symb3d (int n, double xm, double ym, double zm); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void symbol (int nsym, int nx, int ny);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void symfil (string cdev, string cstat);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void symrot (double angle);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int tellfl (int nu); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void texmod (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void texopt (string copt, string ctyp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void texval(double xval, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void thkc3d (double x);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void thkcrv (int nthk);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void ticks  (int itick, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void thrfin (); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void thrini (int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void ticlen (int nmaj, int nmin);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void ticmod (string copt, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void ticpos (string cpos, string cax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void tifmod (int n, string cval, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tiforg (int nx, int ny);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tifwin (int nx, int ny, int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void timopt ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void titjus (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void title  ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void titlin (string cstr, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void titpos (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void torus3d (double xm, double ym, double zm, 
       double r1, double r2, double h, double a1, double a2, int n, int m);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tprini ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tprfin ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void tprmod (string copt, string ckey);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tprval (double x);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tr3axs (double x, double y, double z, double a);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tr3res ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tr3rot (double x, double y, double z);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tr3scl (double xscl, double yscl, double zscl);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tr3shf (double x, double y, double z);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void trfco1 (double [] xray, int n, 
      string cfrom, string cto); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void trfco2 (double [] xray, double [] yray, 
      int n, string cfrom, string cto); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void trfco3 (double [] xray, double [] yray, 
      double [] zray, int n, string cfrom, string cto);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void trfdat (int ndays, ref int id, 
      ref int im, ref int iy); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void trfmat (double [,] zmat, int nx, int ny, 
      double [,] zmat2, int nx2, int ny2);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void trfrel (double [] xray, double [] yray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void trfres ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void trfrot (double xang, int nx, int ny);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void trfscl (double xscl, double yscl);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void trfshf (int nx, int ny);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tria3d (double [] x, double [] y, double [] z);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int triang (double [] xray, double [] yray, int n,
       int [] i1ray, int [] i2ray, int [] i3ray, int nmax); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void triflc (double [] xray, double [] yray, 
        int [] iray, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void trifll  (double [] xray, double [] yray);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void triplx ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int  trmlen (string cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tripts (double [] xray, double [] yray, 
       double [] zray, int n, int [] i1ray, int [] i2ray, int [] i3ray,
       int ntri, double zlev, double [] xpts, double [] ypts,
       int maxpts, int [] nray, int maxray, ref int nlins);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void ttfont (string cfont);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void tube3d (double x1, double y1, double z1, 
       double x2, double y2, double z2, double r, int n, int m);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void txtbgd  (int nclr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void txtjus (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void txture (int [,] imat, int nx, int ny); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void units  (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void upstr  (StringBuilder cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int utfint  (StringBuilder cstr, 
           int [] iray, int nray);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vang3d (double a);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vclp3d (double x1, double x2);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vecclr (int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vecf3d  (double [] x1ray, double [] y1ray,
              double [] z1ray, double [] x2ray, double [] y2ray, double [] z2ray,
              int n, int ivec);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vecfld  (double [] xvray, double [] yvray,
              double [] xpray, double [] ypay, int n, int ivec);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vecmat (double [,] xv, double [,] yv,
       int nx, int ny, double [] xp, double [] yp, int ivec);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vecmat3d (double [,,] xv, double [,,] yv,
       double [,,] zv, int nx, int ny, int nz, double [] xp, double [] yp, 
       double [] zp, int ivec);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void vecopt(double xval, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vector (int nx1, int ny1, int nx2, 
      int ny2, int ivec);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
     public static extern void vectr3 (double x1, double y1, double z1,
           double x2, double y2, double z2, int ivec);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void vfoc3d (double x, double y, double z, 
      string cview);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void view3d (double xvu, double yvu, double zvu, 
     string cvu);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vkxbar (int nvfx);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vkybar (int nvfy);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vkytit (int nvfy);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void vltfil (string cfil, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vscl3d (double x);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void vtx3d (double [] x, double [] y, double [] z,
          int n, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void vtxc3d (double [] x, double [] y, double [] z,
          int [] ic, int n, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void vtxn3d (double [] x, double [] y, double [] z,
          double [] xn, double [] yn, double [] zn, int n, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void vup3d  (double a);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgapp  (int ip, string clab);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int   wgappb (int ip, byte [] iray, int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgbas  (int ip, string ctyp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgbox  (int ip, string cstr, int isel);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgbut  (int ip, string cstr, int ival);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
   public static extern int   wgcmd  (int ip, string clab, string cmd);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgdlis (int ip, string cstr, int isel);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int   wgdraw (int ip);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgfil  (int ip, string clab, string cstr, string cmask);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void wgfin ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgicon  (int ip, string clab, int nw, int nh,
                                        string cfl);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgimg  (int ip, string clab, byte [] iray, 
                                       int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgini  (string ctyp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wglab  (int ip, string cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wglis  (int ip, string cstr, int isel);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int wgltxt (int ip, string clab, string ctext,
      int iper);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int   wgok   (int ip);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgpbut (int ip, string clab);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgpicon  (int ip, string clab, int nw, int nh,
                                        string cfl);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgpimg  (int ip, string clab, byte [] iray, 
                                       int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgpop  (int ip, string clab);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int   wgpopb (int ip, byte [] iray, int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int   wgquit (int ip);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int   wgsep (int ip);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgscl  (int ip, string cstr, 
     double x1, double x2, double xval, int ndez);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)]
    public static extern int   wgpbar  (int ip, double x1, double x2, 
               double xstp);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int   wgstxt (int ip, int nsize, int nmax);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int   wgtbl (int ip, int nrows, int ncols);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern int   wgtxt  (int ip, string cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void widbar (int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void wimage (string cfil);  
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void winapp (string copt);  
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void wincbk (WincbkCB cb, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void windbr (double xk, int nx, int ny, 
      int nwidth, double a);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void window (int nx, int ny, int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void winfin (int iopt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void winfnt (string cfont);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void winico (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int winid  ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void winjus (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void winkey (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void winmod (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void winopt (int iopt, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void winsiz (int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void wintit (string cstr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void wintyp (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void wmfmod (string cmod, string ckey);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void world  ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void wpixel (int ix, int iy, int iclr);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void wpixls (byte [] iray, int ix, int iy, 
      int nw, int nh);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void wpxrow (byte [] iray, int ix, int iy, int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int   writfl (int nu, byte [] cbuf, int nbyte); 
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void wtiff  (string cfil);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void x11fnt (string cfont, string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void x11mod (string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern double x2dpos (double x, double y);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern double x3dabs (double x, double y, double z);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern double x3dpos (double x, double y, double z);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern double x3drel (double x, double y, double z);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void xaxgit ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void xaxis  (double xa, double xe, double xorg, 
      double xstp, int nl, string cstr, int it, int nx, int ny);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void xaxlg  (double xa, double xe, double xorg, 
      double xstp, int nl, string cstr, int it, int nx, int ny);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void xaxmap (double xa, double xe, double xorg, 
      double xstp, string cstr, int it, int ny);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void xcross ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void xdraw  (double x, double y);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void xjdraw (double x, double y, int ipen);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern double xinvrs (int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void xmove  (double x, double y);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern double xposn  (double x);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern double y2dpos (double x, double y);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern double y3dabs (double x, double y, double z);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern double y3dpos (double x, double y, double z);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern double y3drel (double x, double y, double z);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void yaxgit ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void yaxis  (double ya, double ye, double yor, 
      double ystp, int nl, string cstr, int it, int nx, int ny);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void yaxlg  (double ya, double ye, double yor,
      double ystp, int nl, string cstr, int it, int nx, int ny);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void yaxmap (double ya, double ye, double yor, 
      double ystp, string cstr, int it, int ny);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void ycross ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern  double yinvrs (int n);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void ypolar  (double ya, double ye, double yor, 
      double ystp, string cstr, int ndist);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern double yposn  (double y);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern double z3dpos (double x, double y, double z);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void zaxis  (double za, double ze, double zor, 
      double zstp, int nl, string cstr, int it, int id, int nx, int ny);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void zaxlg  (double za, double ze, double zor, 
      double zstp, int nl, string cstr, int it, int id, int nx, int ny);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void zbfers ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void zbffin ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern int zbfini ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void zbflin (double x1, double y1, double z1, 
      double x2, double y2, double z2);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
    public static extern void zbfmod(string copt);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void zbfres ();
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void zbfscl (double x);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void zbftri (double [] x, double [] y, double [] z,
     int [] ic);
  [DllImport("dislnc_d.dll", CallingConvention=CallingConvention.Cdecl)] 
    public static extern void zscale (double za, double ze);
}
