x = -4:0.1:6.5;
y = x ./ sqrt(x .* x + 2); %% здесь подынтегральное выражение(функция под интегралом)
graf = plot(x, y, 'r');
lg = legend('x .* x + 2 ');
h  = title('Integral');
ax = gca();
set(ax, 'xlim', [-4 4], 'ylim', [-4 4]);
set(ax, 'xtick', [-4:0.5:4], 'ytick', [-4:0.5:4]);
set(ax, 'color', 'w');
set(ax, 'xcolor', 'k', 'ycolor', 'k');
set(ax, 'xgrid', 'on', 'ygrid', 'on');
set(ax, 'gridcolor', [0 0 0]);
set(ax, 'gridlinestyle', '-');
set(ax, 'gridalpha', 0.15);
set(ax, 'fontsize', 12);
set(ax, 'xlabel', 'x', 'ylabel', 'f(x)');
 set(h, 'fontsize', 14);
set(graf, 'LineWidth', 2);
set(lg, 'edgecolor', 'k')
set(lg, 'fontsize', 9, 'fontweight', 'bold', 'location', 'southeast');
