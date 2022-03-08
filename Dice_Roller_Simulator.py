import random

while True:
    print("Rolling the dice...")
    print("The values are:")
    print(random.randint(1, 6))
    print(random.randint(1, 6))

    roll_again = input("Roll the dice again? (Y/N) ")
    if roll_again.lower() != "y":
        break