dark_props = {'defaultfigurecolor', 'k', ...
              'defaultfigureinverthardcopy', false, ...
              'defaultaxescolor', 'k', ...
              'defaultaxesxcolor', 'w', ...
              'defaultaxesycolor', 'w', ...
              'defaulttextcolor', 'w'};
set (0, dark_props{:})
x = -10:1:10;
y = 0.5.*exp(-x.^2) + x.*cos(x);
f = figure('color', 'k');
graf = plot(x, y);
lg = legend('0.5.*exp(-x.^2) + x.*cos(x)');
h  = title('21');
ax = gca();
%%%%%%%%%%%%%%% Настройки осей %%%%%%%%%%%%%%%%%%%%%%%%%%
set(ax, 'xlim', [-10 10], 'ylim', [-10 10]);
set(ax, 'xtick', [-10:1:10], 'ytick', [-10:1:10]);
set(ax, 'color', 'k');
set(ax, 'xcolor', 'w', 'ycolor', 'w');
set(ax, 'xgrid', 'on', 'ygrid', 'on');
set(ax, 'gridcolor', [1 1 1]);
set(ax, 'gridlinestyle', '-');
set(ax, 'gridalpha', 0.15);
set(ax, 'fontsize', 12);
set(ax, 'xlabel', 'x', 'ylabel', 'f(x)');
%%%%%%%%%%%%% Настройка заголовк а%%%%%%%%%%%%%%%%%%%%%%%
set(h, 'color', 'w');
set(h, 'fontsize', 14);
%%%%%%%%%%%%% Настройки графика %%%%%%%%%%%%%%%%%%%%%%%%
set(graf, 'color', 'c');
set(graf, 'LineWidth', 3);
%%%%%%%%%%%%% Настройка легенды
set(lg, 'color', 'k', 'edgecolor', 'w', 'textcolor', 'w');
set(lg, 'fontsize', 10, 'fontweight', 'bold');
saveas(f, '21.svg');

