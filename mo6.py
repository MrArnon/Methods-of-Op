import math as m
import sympy as s
from sympy.matrices import *
import matplotlib.pyplot as plt
import numpy as np
from mpl_toolkits.mplot3d import axes3d

def valuePoint(func, chastn,  wow): #значение ф-ции в точке
  value = func.subs(chastn, wow)
  return value

def funcDif(f,perem, wow):          # частные производные
  diffur = s.diff(f, perem, wow)
  return diffur

def gradFunc(f,cm1, cm2, val, degree):
  ret = valuePoint(valuePoint(funcDif(f,cm1,degree), cm1, val), cm2, val)
  return ret
def graphic (f):
    ax = axes3d.Axes3D(plt.figure())
    x = np.linspace(-5, 5, 100)
    plt.xlabel("ось X")
    y=np.linspace(-5,5,100)
    plt.ylabel("ось Y")
    z=f(x,y)
    ax.plot3D(x,y,z)
    plt.grid(True)
    plt.show()
def func (x,y):
  return x*x+2*y*y-4
  #return x*x+y*y
  #return x**2+x*y+y*2-x
  #return 4*(x**2)+3*(x**2)-4*x*y+x
u0 = 1.1     # х0
eps = 0.1  # точность > 0
alpha = 0.1  # начальный шаг > 0
 
x = s.Symbol('x')
y = s.Symbol('y')

function=x*x+2*y*y-4
#function = x*x+y*y
#function = x**2+x*y+y*2-x
#function=4*(x**2)+3*(x**2)-4*x*y+x
grad = gradFunc(function,x, y, u0, 1) + gradFunc(function,y, x, u0, 1)
gradNorm = m.sqrt((gradFunc(function, x, y, u0, 1))**2 + (gradFunc(function,y, x, u0, 1))**2)
a = Matrix(([gradFunc(function, x, y, u0, 2),gradFunc(funcDif(function,y,1),x,y,u0,1)],[gradFunc(funcDif(function,x,1),y,x,u0,1),gradFunc(function, y, x, u0, 2)]))
graphic(func)
while (abs(gradNorm) >= eps):
  u0 = u0 - grad*((a.inv()).det())
  valueOfU0 = gradFunc(function,x, y, u0, 0)
  grad = gradFunc(function,x, y, u0, 1) + gradFunc(function,y, x, u0, 1)
  gradNorm = m.sqrt((gradFunc(function,x, y, u0, 1))**2 + (gradFunc(function,y, x, u0, 1))**2)
  a = Matrix(([gradFunc(function, x, y, u0, 2),gradFunc(funcDif(function,y,1),x,y,u0,1)],[gradFunc(funcDif(function,x,1),y,x,u0,1),gradFunc(function, y, x, u0, 2)]))
  #print (gradNorm)
#print(u0, gradFunc(function, x, y, u0, 0))
print(u0)