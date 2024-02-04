 x1 = 0:0.05:1;
 function g = fi(x1)
g = x1.^2 + 1./ 2;
end
y1 = fi(x1)
function [q] = f(t, y1)
q = [-4.*t.^3 + 4 .* t .* y1];
end
opt = odeset ("RelTol", 1e-6, "AbsTol", 1e-6, 'InitialStep', 0.025,'MaxStep', 0.05);
[x45, y45] = ode45 (@(t, y1) f(t, y1), [0 1], 0.5, opt);
figure();% График решения функции ode45 и точного решения.
plot(x1, y1,'-r;exact solution;', x45, y45,'*b;ode45;');
grid on;
