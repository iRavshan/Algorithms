import math

def MainFunc(x):
    y = math.sin(24 * x) + math.exp(12 * x) - 24/15
    return y

def LinearSplineFunc(x1, y1, x2, y2):
    a1 = (y2 - y1) / (x2 - x1)
    a0 = y1 - a1 * x1
    function = str(a0) + " + " + str(a1)+ "x"
    return(function)

item = 0
x = []
y = []

#Barcha x va f(x) ning qiymatini hisoblash

while(item <= 2 * math.pi):
    x.append(item)
    y.append(MainFunc(item))
    item = item + 2 * math.pi / 5
print(y)

item = 0

#Barcha chiziqli splayn funksiyalarni tuzish

for i in range(5):
    print(LinearSplineFunc(x[i], y[i], x[i + 1], y[i + 1]))
