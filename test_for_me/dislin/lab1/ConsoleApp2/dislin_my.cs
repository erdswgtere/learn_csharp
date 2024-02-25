using System.Text;

namespace dislin_my {
    class Dislin {
        public static void Diag() {
            int nya = 2700;
            string ctit = "Bar Graphs (BARS)";
            StringBuilder cbuf = new StringBuilder(25);

            float[] x = { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f, 6.0f, 7.0f, 8.0f, 9.0f, 10.0f };
            float[] y = { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f };
            float[] y1 = { 1.0f, 1.5f, 2.5f, 1.3f, 2.0f, 1.2f, 0.7f, 1.4f, 1.1f, 2.2f };

            dislin.scrmod("revers");
            dislin.setpag("da4p");
            dislin.metafl("cons");
            dislin.disini();
            dislin.pagera();
            dislin.complx();
            dislin.ticks(1, "x");
            dislin.intax();
            dislin.axslen(1700, 900);
            dislin.titlin(ctit, 1);

            dislin.legini(cbuf, 1, 8);
            dislin.leglin(cbuf, "FIRST", 1);

            dislin.legtit(" ");
            dislin.shdpat(5);
            dislin.axspos(300, nya - 2 * 500);
            dislin.graf(0.0f, 10.0f, 0.0f, 1.0f, 0.0f, 5.0f, 0.0f, 1.0f);
            dislin.labels("second", "bars");
            dislin.labpos("outside", "bars");
            dislin.color("blue");
            dislin.bars(x, y, y1, 10);
            dislin.color("fore");
            dislin.height(50);
            dislin.title();
            dislin.legend(cbuf, 7);
            dislin.endgrf();
            dislin.disfin();
        }
    }
}
