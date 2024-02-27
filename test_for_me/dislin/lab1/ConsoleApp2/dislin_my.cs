using System.Text;

namespace dislin_my {
    class Dislin_my {
        float[] chas;
       public Dislin_my(ref double[] Chass) {
            chas = Chass;
       }
        public static void Diag() {
            int nya = 2700;
            string ctit = "Bar Graphs (BARS)";
            StringBuilder cbuf = new StringBuilder(25);

            float[] x = { 0.0f, 10.0f, 20.0f, 30.0f, 40.0f, 50.0f, 60.0f, 70.0f, 80.0f, 90.0f, 100.0f };
            float[] x1 = { 0.0f, 10.0f, 20.0f, 30.0f, 40.0f, 50.0f, 60.0f, 70.0f, 80.0f, 90.0f, 100.0f };
            float[] y = { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f };
            float[] y1 = { 10.0f, 10.5f, 20.5f, 10.3f, 20.0f, 10.2f, 7.0f, 10.4f, 10.1f, 20.2f };

            dislin.scrmod("revers");
            dislin.setpag("da4p");
            dislin.metafl("cons");
            dislin.disini();
            dislin.pagera();
            dislin.complx();
            dislin.ticks(5, "x");
            dislin.intax();
            dislin.axslen(1700, 1000);
            dislin.titlin(ctit, 1);

            dislin.legini(cbuf, 1, 8);
            dislin.leglin(cbuf, "FIRST", 1);
            dislin.legtit(" ");
            dislin.shdpat(100);
            dislin.axspos(300, nya - 2 * 500);
            dislin.graf(0.0f, 100.0f, 0.0f, 10.0f, 0.0f, 100.0f, 0.0f, 10.0f);
            dislin.color("blue");
            dislin.bars(x, y, y1, 10);
            dislin.color("fore");
            dislin.reset("bargrp");
            dislin.height(50);
            dislin.title();
            dislin.legend(cbuf, 7);
            dislin.endgrf();
            dislin.disfin();
        }
    }
}
