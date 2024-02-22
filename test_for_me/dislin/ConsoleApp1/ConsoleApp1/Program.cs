using System;
using System.Text;

public class App {
    public static void Main() {
        int nya = 2700, i;
        string ctit = "Bar Graphs (BARS)";
        StringBuilder cbuf = new StringBuilder(25);

        float[] x = { 1.0f, 2.0f, 3.0f, 4.0f, 5.0f, 6.0f, 7.0f, 8.0f, 9.0f };
        float[] y = { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f };
        float[] y1 = { 1.0f, 1.5f, 2.5f, 1.3f, 2.0f, 1.2f, 0.7f, 1.4f, 1.1f, 2.2f};
        float[] y2 = { 2.0f, 2.7f, 3.5f, 2.1f, 3.2f, 1.9f, 2.0f, 2.3f, 1.8f };
        float[] y3 = { 4.0f, 3.5f, 4.5f, 3.7f, 4.0f, 2.9f, 3.0f, 3.2f, 2.6f };

        dislin.scrmod("revers");
        dislin.setpag("da4p");
        dislin.metafl("cons");
        dislin.disini();
        dislin.pagera();
        dislin.complx();
        dislin.ticks(1, "x");
        dislin.intax(); ;
        dislin.axslen(1600, 700);
        dislin.titlin(ctit, 3);

        dislin.legini(cbuf, 3, 8);
        dislin.leglin(cbuf, "FIRST", 1);
        dislin.leglin(cbuf, "SECOND", 2);
        dislin.leglin(cbuf, "THIRD", 3);
        dislin.legtit(" ");
        dislin.shdpat(5);
        for (i = 1; i <= 3; i++) {
            if (i > 1) dislin.labels("none", "x");
            dislin.axspos(300, nya - (i - 1) * 800);
            dislin.graf(0.0f, 10.0f, 0.0f, 1.0f, 0.0f, 5.0f, 0.0f, 1.0f);

            if (i == 1) {
               
            }
            else if (i == 2) {
                dislin.height(30);
                dislin.labels("delta", "bars");
                dislin.labpos("center", "bars");
                dislin.color("red");
                dislin.bars(x, y, y1, 9);
                dislin.color("green");
                dislin.bars(x, y1, y2, 9);
                dislin.color("blue");
                dislin.bars(x, y2, y3, 9);
                dislin.color("fore");
                dislin.reset("height");
            }
            else if (i == 3) {
                dislin.labels("second", "bars");
                dislin.labpos("outside", "bars");
                dislin.color("red");
                dislin.bars(x, y, y1, 10);
                dislin.color("fore");
            }

            if (i != 3) dislin.legend(cbuf, 7);

            if (i == 3) {
                dislin.height(50);
                dislin.title();
            }

            dislin.endgrf();
        }
        dislin.disfin();
    }
}