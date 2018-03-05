import matplotlib.pyplot as plt
import numpy as np
from scipy.misc import derivative
def func (x) :
   #r#eturn x*x +3
   return x*x -4*x +4
def diff_func(x):
    #print(derivative (func,x))
    return derivative (func,x)
def graphic(a,b):
    x = np.linspace(a, b, 1000)
    y=func(x)
    plt.plot(x,y)
    plt.show()
def nyothon (f,a,b,df,eps):
    try:
        x0=(a+b)/2
        xn=f(x0)
        xn1=xn-f(xn)/df(xn)
        while abs(xn1-xn)> eps:
            xn=xn1
            xn1=xn-f(xn)/df(xn)
        return xn1
    except RuntimeWarning:
        print ("Divide by zero")
    except ValueError:
        print("Value not ivalable")
def n_method (f,a,b,df,eps):
    try:
        xo=(a+b)/2
        while True:
            x1=xo-(f(xo)/df(xo))
            if abs(x1-xo)<eps :
                return x1
            xo=x1
    except RuntimeWarning:
        print ("Divide by zero")
    except ValueError:
        print("Value not ivalable")
def main():
    a=float(input("a->"))
    b=float(input("b->"))
    eps=float(input("accuracy eps->"))
    x1=nyothon(func,a,b,diff_func,eps)
    print("Min point",x1)
    print("Min value",func(x1))
    graphic(a,b)
main()