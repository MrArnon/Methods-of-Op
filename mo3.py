import matplotlib.pyplot as plt
import numpy as np
def func (x) :
    #return (np.exp(x)+np.exp(-x))/2
    #return x*x -x +3
    return np.cos(x) - x * x * x
def parabola (f,a,b,eps,h,x):
    if (x == 0):
        x+=0.1
    while( abs(f(x+h)-2*f(x)+f(x-h))/(h*h)<=0):
        x+=0.1
    x1=x-0.5*h*(f(x+h)-f(x-h))/(f(x+h)-2*f(x)+f(x-h))
    while (abs((x1-x))>eps):
        x=x1
        x1 = x - 0.5 * h * (f(x + h) - f(x - h)) / (f(x + h) - 2 * f(x) + f(x - h))
    if(x1 <a or x1>b):
        if (abs(x1-a) < (x1-b)):
            x1=b
        else:
            x1=a
    return x1
def graphic(a,b):
    x = np.linspace(a, b, 1000)
    y=func(x)
    plt.plot(x,y)
    plt.show()

def main():
    a=float(input("a->"))
    b=float(input("b->"))
    eps=float(input("accuracy eps->"))
    h=float(input("step h ->"))
    x0=float(input("point x0 ->"))
    x1=parabola(func,a,b,eps,h,x0)
    print("Min point",x1)
    print("Min value",func(x1))
    graphic(a,b)
main()



