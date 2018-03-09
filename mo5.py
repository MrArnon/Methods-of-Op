import matplotlib.pyplot as plt
import numpy as np
from mpl_toolkits.mplot3d import axes3d
from matplotlib import cm
def func (x1,x2):
    #return x1*x1+2*(x2*x2)*np.exp(x1+x2)
    return x1*x1*x1+2*(x2*x2)-3*x1-4*x2
def dx1 (x1,x2):
   #return 2*x1 +2*(x2*x2)*np.exp(x1+x2)
    return 3*(x1*x1)-3
def dx2 (x1,x2):
    #return 2*(x2*x2)*np.exp(x1+x2)+4*x2*np.exp(x1+x2)
    return 4*x2-4
def grad (dx1,dx2,x1,x2):
    return ( np.sqrt(dx1(x1,x2)*dx1(x1,x2) + dx2(x1,x2)*dx2(x1,x2)))
def new_step (xn,x1,x2,dx,h):
    xn=xn-h*dx(x1,x2)
    return xn
def min_grad (eps,xo,yo,h,f):
    x1=xo
    x2=yo
    gr=grad (dx1,dx2,x1,x2)
    while(eps<np.abs(gr)):
        x1=new_step(x1,x1,x2,dx1,h)
        x2=new_step(x2,x1,x2,dx2,h)
        gr = grad(dx1, dx2, x1, x2)
    print("Min point", x1, " . ", x2)
    print("Min value",f(x1,x2))
def graphic (f):
    ax = axes3d.Axes3D(plt.figure())
    x = np.linspace(-3, 3, 100)
    y=np.linspace(-3,3,100)
    z=f(x,y)
    ax.plot3D(x,y,z)
    plt.grid(True)
    plt.show()
def main():
    xo=float(input("xo->"))
    yo=float(input("yo->"))
    eps=float(input("accuracy eps->"))
    h=float(input("step h->"))
    min_grad(eps,xo,yo,h,func)
    graphic(func)
main()