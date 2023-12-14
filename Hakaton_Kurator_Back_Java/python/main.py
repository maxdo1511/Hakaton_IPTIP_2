import matplotlib.pyplot as plt
import sys
import os
import traceback
import calendar
from scipy.interpolate import interp1d

import numpy as np

__location__ = os.getcwd()

try:

    POINTS_MARKER = "--points"
    PATH_MARKER = "--path"
    NAME_MARKER = "--name"
    COLOR_MARKER = "--color"
    PRECISION_MARKER = "--precision"

    x = []
    y = []
    month_names = [calendar.month_name[i] for i in range(1, 13)]

    color = "blue"
    name = "default"
    path = "graphics/g_1.png"
    precision = 1000
    flag = False

    args = sys.argv
    for arg in args:
        if arg.startswith("--"):
            flag = False
        if flag:
            chis = arg.split("-")
            x.append(float(chis[0]))
            y.append(float(chis[1]))
        else:
            if arg == POINTS_MARKER:
                flag = True

    for i in range(len(args)):
        if args[i] == PATH_MARKER:
            path = args[i + 1]
        if args[i] == COLOR_MARKER:
            color = args[i + 1]
        if args[i] == NAME_MARKER:
            name = args[i + 1]
        if args[i] == PRECISION_MARKER:
            precision = int(args[i + 1])

    

    if len(set(x)) < 4:
        f = interp1d(x, y, kind='linear')
    else:
        f = interp1d(x, y, kind='cubic')

    monthes = [month_names[int(month)%12] for month in x]

    x_smooth = np.linspace(np.min(x), np.max(x), precision)
    #x_smooth = np.linspace(np.min(x), np.max(x), precision)
    y_smooth = [np.clip(i, 0, 5) for i in f(x_smooth)]

    plt.plot(x_smooth, y_smooth, marker='o', linestyle='-', color=color, markersize=1)

    plt.grid(True, axis="y")
    plt.ylim(0, 5)
    plt.xticks(x, labels=monthes)
    plt.gca().xaxis.set_ticks_position('top')

    plt.savefig(path)
except Exception as err:
    
    with open(os.path.join(__location__, "charts", "error.txt"), "w") as f:
        f.write(str(err))