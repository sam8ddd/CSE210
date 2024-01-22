# Calculate the trajectory for a hooking or slicing
# golf ball by giving the ball sidespin, with the same
# angular velocity used in the calculations in Figure 2.13

from numpy import sin,cos,radians,array,pi,sqrt
from pylab import plot,show
from matplotlib import pyplot as plt
from mpl_toolkits.mplot3d import Axes3D

def C(v):
    if v<14:
        return 0.5
    else:
        return 7/v
    
def calcV(vx,vy,vz):
    return 
    
# constants and initial conditions
g = 9.8
ρ = 1   # air density
A = 0.02159**2*pi   # area of golf ball in m^2
m = 0.04593   # kg
θ = radians(9)
v0 = 70
dt = 0.01

def plotTraj(β):
    xList = [0]
    yList = [0]
    zList = [0]
    vxList = [v0*cos(θ)]
    vyList = [v0*sin(θ)]
    vzList = [0]

    while yList[-1] >= 0:
        xList.append(xList[-1] + vxList[-1]*dt)
        yList.append(yList[-1] + vyList[-1]*dt)
        zList.append(zList[-1] + vzList[-1]*dt)

        α = β   # α = S0*ω/m, assuming constant ω
                   # Slicing the ball, positive α, is upward ω.
                   # Hooking the ball, negative α, is downward ω.
        v = sqrt(vxList[-1]**2 + vyList[-1]**2 + vzList[-1]**2)
        drag = C(v)*ρ*A*v**2/m
        vxList.append(vxList[-1]-dt*drag*(vxList[-1])/v + dt*α*-sin(vxList[-1]/sqrt(vxList[-1]**2 + vzList[-1]**2)))
        vyList.append(vyList[-1]-dt*g-dt*drag*(vyList[-1])/v)
        vzList.append(vzList[-1]-dt*drag*(vzList[-1])/v + dt*α*cos(vxList[-1]/sqrt(vxList[-1]**2 + vzList[-1]**2)))
        
    return xList,yList,zList

ωVals = [0.25,2.5,25,-25]
xResults = []
yResults = []
zResults = []
for i in range(len(ωVals)):
    x,y,z = plotTraj(ωVals[i])
    xResults.append(x)
    yResults.append(y)
    zResults.append(z)

fig = plt.figure(figsize = (8,8))
ax = Axes3D(fig)
for i in range(len(xResults)):
    ax.scatter(zResults[i],xResults[i],yResults[i],'r-')
    
ax.set_xlim(-60,60)
ax.set_ylim(0,120)
    
plotTraj(0.25)
plotTraj(0.5)
plt.show()