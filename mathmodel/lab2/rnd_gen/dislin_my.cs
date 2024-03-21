using System.Text;

namespace dislin_my {
    public class Dislin_my {
        static float[] chas;
        static float[] randvalues;
        static float[] funcmas;
        public Dislin_my(ref double[] Chass, ref double[] Values, ref double[] Funcmas) {
            float[] floatChass = new float[Chass.Length];
            for (var i = 0; i < Chass.Length; ++i) {
                floatChass[i] = (float)Chass[i] * 800;
            }

            float[] floatValues = new float[Values.Length];

            for (var i = 0; i < Values.Length; ++i) {
                floatValues[i] = (float)Values[i] * 10;
            }

            float[] floatFuncmas = new float[Funcmas.Length];

            for (var i = 0; i < Funcmas.Length; ++i) {
                floatFuncmas[i] = (float)Funcmas[i] * 100;
            }

            funcmas = floatFuncmas;
            chas = floatChass;
            randvalues = floatValues;
        }
        public void Diag() {
            int nya = 2700;
            string ctit = "Bar Graphs (BARS)";
            StringBuilder cbuf = new StringBuilder(25);

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
            dislin.barwth(0.3f);
            dislin.barbor(490);
            dislin.legini(cbuf, 1, 25);
            dislin.leglin(cbuf, "Normal_gen", 1);
            dislin.legtit(" ");
            dislin.shdpat(100);
            dislin.axspos(200, nya - 2 * 500);
            dislin.graf(0.0f, 100.0f, 0.0f, 5.0f, 0.0f, 100.0f, 0.0f, 10.0f);
            dislin.color("blue");
            dislin.bars(randvalues, y, chas, 15);
            dislin.color("fore");
            dislin.reset("bargrp");
            dislin.height(50);
            dislin.title();
            dislin.legend(cbuf, 7);
            dislin.endgrf();
            dislin.disfin();
        }
        public void Diag_for_datafunc() {
            int nya = 2700;

            string ctit = "Bar Graphs (BARS)";
            StringBuilder cbuf = new StringBuilder(25);

            
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
            dislin.barbor(89);
            dislin.legini(cbuf, 1, 25);
            dislin.leglin(cbuf, "raspred", 1);
            dislin.legtit(" ");
            dislin.shdpat(100);
            dislin.axspos(200, nya - 2 * 500);
            dislin.graf(0.0f, 100.0f, 0.0f, 5.0f, 0.0f, 100.0f, 0.0f, 10.0f);
            dislin.color("red");
            dislin.bars(funcmas, y, chas, 15);
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


// dislin.graf(-50.0f, 50.0f, -50.0f, 5.0f, 0.0f, 100.0f, 0.0f, 10.0f);
// dislin.graf(0.0f, 100.0f, 0.0f, 5.0f, 0.0f, 100.0f, 0.0f, 10.0f);