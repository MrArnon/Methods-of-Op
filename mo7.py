from scipy.optimize import minimize, rosen
import matplotlib.pyplot as plt
import numpy as np
from mpl_toolkits.mplot3d import axes3d
def func(x,y):
    return (1-x)**2+y+5
    #return (1-x)**2+100*(y-x**2)**2
    #return np.exp(x*y)
def graphic (f):
    ax = axes3d.Axes3D(plt.figure())
    x = np.linspace(-3,3 , 100)
    plt.xlabel("ось X")
    y=np.linspace(-3,3,100)
    plt.ylabel("ось Y")
    z=f(x,y)
    ax.plot3D(x,y,z)
    plt.grid(True)
    plt.show()
rz = lambda x: (1-x[0])**2 +x[1]+5
#rz=lambda  x: np.exp(x[0]*x[1])
h_1 = lambda x: (x[0] - 2 * x[1] + 2)
#h_1=lambda x:x[0]+x[1]-1
#h_2 = lambda x: (-x[0] - 2 * x[1] + 6)
#h_2=lambda x:1
#h_3 = lambda x: (-x[0] + 2 * x[1] + 2)
#h_3=lambda x:1
x_c = [2.3, 3]
#x_c=[0,0]
i = 1
r = 1
b = 0.2
eps = 0.01
graphic(func)
while i < 1000:
    #curr_func = lambda x: rz(x) + r * (1.0 / (h_1(x) ** 2 + h_2(x) ** 2 + h_3(x) ** 2))
    curr_func = lambda x: rz(x) + r * (1.0 / (h_1(x) ** 2))
    if curr_func(x_c) < eps:
        break
    x_c = minimize(curr_func, x_c).x
    i += 1
    r  *= b
print(x_c)
print(rz(x_c))
#print(i)