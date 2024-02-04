%% этот файл нужен чтобы показать промежуток где есть корни
x = -10:1:10;
y = 0.5.*exp(-x.^2)+x.*cos(x); %%тут пишется функция для построения графика(до знака ;)
graf = plot(x, y);
lg = legend('f(x) = 0.3 .* exp(x) - cos(x).^2 + 2');
h = title('MyPlot');
ax = gca();
set(ax, 'xlim', [-1 1], 'ylim', [-2 2]); %% в 8 и 9 строки регулируешь цифры чтобы приблизить обзор к пересечению с осью X то есть к корню чтобы приблизиться
set(ax, 'xtick', [-1:0.5:1], 'ytick', [-2:1:2]);
set(ax, 'xcolor', 'k', 'ycolor', 'k');
set(ax, 'xgrid', 'on', 'ygrid', 'on');
set(ax, 'gridcolor', 'k');
set(ax, 'fontsize', 10);
set(ax, 'xlabel', 'x', 'ylabel', 'f(x)');
set(h, 'fontsize', 14);
set(graf, 'color', 'r');
set(graf, 'LineWidth', 3);
set(lg, 'edgecolor', 'k');
set(lg, 'fontsize', 9, 'fontweight', 'bold');

