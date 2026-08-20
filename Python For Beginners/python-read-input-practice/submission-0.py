def add_two_numbers() -> int:
    res = 0
    user_input = input()
    string_list = user_input.split(",")
    for element in string_list:
        res += int(element)
    return res



# do not modify below this line
print(add_two_numbers())
print(add_two_numbers())
print(add_two_numbers())
print(add_two_numbers())
