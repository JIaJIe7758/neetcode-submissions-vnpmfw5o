def remove_fourth_character(word: str) -> str: 
    firstPart = word[:3]
    secondPart = word[4:]
    return firstPart + secondPart


# do not modify below this line
print(remove_fourth_character("NeetCode"))
print(remove_fourth_character("Hello"))
