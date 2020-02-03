


# This code is uncompleted, I get a runtime error on second test and I cannot figure out why












from math import sqrt, floor, ceil
import random 

def Sort(points, x, y):
   points.sort(key = lambda p: sqrt((p.x - x)**2 + (p.y - y)**2))
   return points

def CalcDistance(fromP, toP):
    return sqrt((toP.x - fromP.x)**2 + (toP.y - fromP.y)**2)

def ClassifyPoint(Points, Groups):
    for point in Points:
        shortest = Groups[0]
        #get shortest cluster point
        for group in Groups:
            if CalcDistance(point, shortest) > CalcDistance(point, group):
                shortest = group

        point.belongs = shortest

    for group in Groups:
        stack = []
        for point in Points:
            if point.belongs == group:
                stack.append(point)
        if len(stack) == 0:
            group.x = random.randint(floor(minPoint.x),ceil(maxPoint.x))
            group.y = random.randint(floor(minPoint.y),ceil(maxPoint.y))
            continue
        meanX = sum([p.x for p in stack]) / len(stack)
        meanY = sum([p.y for p in stack]) / len(stack)
        group.x = meanX
        group.y = meanY
        # print("mean clusterpoint = " + str(meanX) + "," + str(meanY))
    return Groups


class Point:
    def __init__(self, X, Y):
        self.x = X
        self.y = Y
        self.belongs = None

    def Print(self):
        print(str(self.x) + "," + str(self.y))



TestCases = int(input())

for t in range(TestCases):
    n, k = input().split(' ')
    coords = []
    for i in range(int(n)):
        cord = input().split(' ')
        # print(cord)
        coords.append(Point(float(cord[0]),float(cord[1])))
    
    newcoords = Sort(coords, 0, 0)
    minPoint = newcoords[0]
    maxPoint = newcoords[len(newcoords) -1]

    localMin = 999999
    for gen in range(20):
        clusterPoints = []
        for i in range(int(k)):
            p = Point(random.randint(floor(minPoint.x),ceil(maxPoint.x)), random.randint(floor(minPoint.y),ceil(maxPoint.y)))
            # print("new clusterpoint at: ", end = '')
            # p.Print()
            clusterPoints.append(p)


        for i in range(10):
            clusterPoints = ClassifyPoint(coords, clusterPoints)

        largestSquare = 0
        for group in clusterPoints:
            groupedPoints = []
            for point in coords:
                if point.belongs == group:
                    groupedPoints.append(point)
            longest = groupedPoints[0]
            for point in groupedPoints:
                if CalcDistance(group, point) > CalcDistance(group, longest):
                    longest = point
            if CalcDistance(group, longest) > largestSquare:
                largestSquare = CalcDistance(group, longest)

        if largestSquare*2 < localMin:
            localMin = largestSquare*2

    print("Case #" + str(t+1) + ": " + str(floor(localMin)))