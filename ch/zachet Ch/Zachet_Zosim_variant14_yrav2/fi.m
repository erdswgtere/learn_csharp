 x1 = 1.6:0.05:2.5;
 function g = fi(x1)
g = -0.25.*(pi.^2-4.*x1.^2).*sin(x1);
end
y1 = fi(x1)
function [q] = f(t, y1)
q = [2.*t.*sin(t)+ y1.*cot(t)];
end
opt = odeset ("RelTol", 1e-6, "AbsTol", 1e-6, 'InitialStep', 0.025,'MaxStep', 0.05);
[x45, y45] = ode45 (@(t, y1) f(t, y1), [pi./2 pi./2+1], 0, opt);
figure();
plot(x1, y1,'-r;exact solution;', x45, y45,'*b;ode45;');
grid on;
