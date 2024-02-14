from numpy import array,zeros,copy,pi,linspace,meshgrid
from matplotlib import pyplot as plt


class Vgrid:
    def __init__(self,size,V0):
        self.size = size
        self.V = zeros([size,size]) # initialize voltage 2-dim array
        self.V0 = V0
        self.a = 2/(1+pi/self.size)

    def setV(self):
        self.V[self.size//5:self.size*4//5,self.size//2] = self.V0
    
    def relax(self):
        doLoop = True
        while doLoop:
            Vold = copy(self.V)
            V[1:-1,1:-1] = 0.25*(V[:-2,1:-1] + V[2:,1:-1] + V[1:-1,:-2] + V[1:-1,2:])
            dV = V - Vold
            V = Vold * self.a*dV
            self.setV()

            doLoop = any(dV > eps)
    
    def plot(self):
        x = linspace(0,1,self.size)
        y = linspace(0,1,self.size)
        X,Y = meshgrid(x,y)

        fig = plt.figure(figsize = (10,10))
        ax1 = fig.add_subplot(1,1,1,projection='3d')
        ax1.plot_surface(X,Y,self.V)
        ax1.view.init(elev = 40,azim = 70)
        plt.show()
    
eps = 10e-4
myV = Vgrid(11,1)
myV.relax()
myV.plot