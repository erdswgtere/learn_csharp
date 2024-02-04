f = @(t, y) 2.*t.*sin(t)+ y.*cot(t);
opt = odeset ("RelTol", 1e-6, "AbsTol", 1e-6, 'InitialStep', 0.025,'MaxStep', 0.5);
[t, y] = ode45 (f, [pi./2 (pi./2)+1], 0, opt);
output_precision(10)
y


