f = @(t, y) -4*t.^3+4.*t.*y;
opt = odeset ("RelTol", 1e-6, "AbsTol", 1e-6, 'InitialStep', 0.025,'MaxStep', 0.5);
[t, y] = ode45 (f, [0 1], 0.5, opt);
output_precision(10)
y


