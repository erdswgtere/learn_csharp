dark_props = {'defaultfigurecolor', 'k', ...
              'defaultfigureinverthardcopy', false, ...
              'defaultaxescolor', 'k', ...
              'defaultaxesxcolor', 'w', ...
              'defaultaxesycolor', 'w', ...
              'defaulttextcolor', 'w'};
set (0, dark_props{:})
x = 4.5:0.1:4.8; % массив значений x
y = 0.5.*exp(-x.^2) + x.*cos(x);
f = figure('color', 'k'); % Цвет фона графика
graf = plot(x, y); % График
lg = legend('0.5.*exp(-x.^2) + x.*cos(x)'); % Легенда
h  = title('21'); % Заголовок
% gca() возвращает текущие оси (декартовы, полярные или географические)
% Если нет осей, то создает объект декартовых осей
ax = gca(); % Оси
%%%%%%%%%%%%%%% Настройки осей %%%%%%%%%%%%%%%%%%%%%%%%%%
set(ax, 'xlim', [4.65 4.75], 'ylim', [-2 2]); % Ограничение осей
set(ax, 'xtick', [4.65:0.01:4.75], 'ytick', [-2:0.5:2]); % Вектор возрастающих значений (тики, галочки)
set(ax, 'color', 'k'); % цвет фона области построения
set(ax, 'xcolor', 'w', 'ycolor', 'w'); % цвет осей
set(ax, 'xgrid', 'on', 'ygrid', 'on'); % показать сетку
set(ax, 'gridcolor', [1 1 1]); % цвет сетки
set(ax, 'gridlinestyle', '-'); % стиль линии сетки
set(ax, 'gridalpha', 0.15);    % прозрачность сетки
set(ax, 'fontsize', 12);       % размер шрифта
set(ax, 'xlabel', 'x', 'ylabel', 'f(x)'); % подписи осей
%%%%%%%%%%%%% Настройка заголовк а%%%%%%%%%%%%%%%%%%%%%%%
set(h, 'color', 'w');    % цвет шрифта
set(h, 'fontsize', 14);  % размер шрифта
%%%%%%%%%%%%% Настройки графика %%%%%%%%%%%%%%%%%%%%%%%%
set(graf, 'color', 'c'); % цвет графика
set(graf, 'LineWidth', 3); % толщина графиа
%%%%%%%%%%%%% Настройка легенды
set(lg, 'color', 'k', 'edgecolor', 'w', 'textcolor', 'w');
set(lg, 'fontsize', 10, 'fontweight', 'bold');
saveas(f, '21_loc.svg'); % 'Сохранить как'

