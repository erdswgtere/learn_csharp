using System.Text;

namespace dislin_my {
    public class Dislin_my {
        static float[] chas;
        static float[] randvalues;
        public Dislin_my(ref double[] Chass, ref double[] Values) {
            float[] floatChass = new float[Chass.Length];
            for (var i = 0; i < Chass.Length; ++i)
                floatChass[i] = (float)Chass[i] * 1000;

            float[] floatValues = new float[Values.Length];

            for (var i = 0; i < Values.Length; ++i) {
                floatValues[i] = (float)Values[i] * 100;
            }

            chas = floatChass;
            randvalues = floatValues;
        }
        public void Diag() {
            int nya = 2700;

            string ctit = "Bar Graphs (BARS)";
            StringBuilder cbuf = new StringBuilder(25);

            float[] x = { 0.5f, 5.0f, 10.0f, 15.0f, 20.0f, 30.0f, 40.0f, 50.0f, 60.0f, 70.0f, 80.0f, 90.0f, 100.0f };
            float[] y = { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f };

            dislin.scrmod("revers");
            dislin.setpag("da4p");
            dislin.metafl("cons");
            dislin.disini();
            dislin.pagera();
            dislin.complx();
            dislin.ticks(5, "x");
            dislin.intax();
            dislin.axslen(1800, 1000);
            dislin.titlin(ctit, 1);

            dislin.barwth(0.9f);
            dislin.barbor(490);
            dislin.legini(cbuf, 1, 25);
            dislin.leglin(cbuf, "Lemer_generator", 1);
            dislin.legtit(" ");
            dislin.shdpat(100);
            dislin.axspos(200, nya - 2 * 500);
            dislin.graf(0.0f, 110.0f, 0.0f, 5.0f, 0.0f, 110.0f, 0.0f, 10.0f);
            dislin.color("blue");
            dislin.bars(x, y, chas, 15);
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
