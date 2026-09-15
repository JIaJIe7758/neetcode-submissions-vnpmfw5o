from typing import List, Tuple


def best_student(scores: List[Tuple[str, int]]) -> str:
    
    my_tuple = ()
    temp = 0
    for x, y in scores:
        if len(my_tuple) == 0 or y > temp:
            my_tuple = (x,y)
            temp = y
    
    return my_tuple[0]


# do not modify below this line
print(best_student([("Alice", 90), ("Bob", 80), ("Charlie", 70)]))
print(best_student([("Alice", 90), ("Bob", 80), ("Charlie", 100)]))
print(best_student([("Alice", 90), ("Bob", 100), ("Charlie", 70)]))
print(best_student([("Alice", 90), ("Bob", 90), ("Charlie", 80), ("David", 100)]))
