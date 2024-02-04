%% тут показываем весь график функции
x = -10:1:10;
y = ; %%тут пишется функция для построения графика(до знака ;)
graf = plot(x, y);
lg = legend('f(x) = 0.3 .* exp(x) - cos(x).^2 + 2');
h = title('MyPlot');
ax = gca();
set(ax, 'xlim', [-10 10], 'ylim', [-10 10]);
set(ax, 'xtick', [-10:1:10], 'ytick', [-10:1:10]);
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

