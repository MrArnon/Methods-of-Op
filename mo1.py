from matplotlib import mlab
import pylab


def bisection_method(f, a, b, e):
    while abs(b - a) >= e:
        d = (b - a) / 3
        u1 = (a + b - d) / 2
        u2 = (a + b + d) / 2
        a, b = (a, u2) if f(u1) <= f(u2) else (u1, b)
    return (a + b) / 2


func = lambda x: x ** 2 + 2*x + 3
a1 = int(input("a->"))
b1 = int(input("b->"))
e1 = float(input("eps->"))

# values
val = bisection_method(func, a1, b1, e1)
print("point: ", val)
print("value: ", func(val))

# graphics
x_list = mlab.frange(-5, 5, 2)
y_list = [func(x) for x in x_list]
pylab.plot(x_list, y_list)
pylab.show()
