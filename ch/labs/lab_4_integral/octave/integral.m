f = @(x) x ./ sqrt(realpow(x, 2) + 2.5);
[q, nfev] = quadv(f, 1.4, 2.6);
q
nfev
