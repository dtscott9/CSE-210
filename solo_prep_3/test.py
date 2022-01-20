import random

number = random.randint(1,10)

print(number)

numguess = -1

while numguess != number:
    numguess = int(input("What is your guess? "))

    if numguess < number:
        print("Higher")
    elif numguess > number:
        print("lower")
    elif numguess == number:
        print("You guessed it")