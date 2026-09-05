import math

class AreaCalc:
    # TODO: Implement calculate method
    
    def calculate(self, length: float, width: float = None) -> float:
        res = 0

        if width == None:
            res = round((length**2) * math.pi, 2)
        else:
            res = length * width
        
        return res

    

    
# Don't modify the following code
calc = AreaCalc()
print(calc.calculate(5))    
print(calc.calculate(4, 6))
