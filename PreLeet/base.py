# count supper, digit, lowrcase
word = input("please enter")

word_array = list(word)
suppercount = 0
lowcount = 0
digit = 0
undefine = 0
for i in word_array:
	if i.islower():
		lowcount += 1
	elif i.isupper():
		suppercount += 1
	elif i.isdigit():
		digit += 1
	else:
		undefine += 1
	
print(suppercount)
print(lowcount)
print(digit)
print(undefine)

# reverse a String
word = input("please enter")

string = ""

for i in range(len(word) - 1, -1, -1):
	string += word[i]
	
print(string)

# check palinedrome 
word = input("please enter")

word = word.lower()
reverse_word = ""
for i in range(len(word) - 1, -1, -1):
	reverse_word += word[i]

if (reverse_word == word):
	print("this is a palinedrome")
else:
	print("this is not a palinedrome")

# compare strings & find substrings
word1= input("please enter")
word1 = word1.lower()
word2= input("please enter")
word2 = word2.lower()


if word1 == word2:
	print("they are the same")
elif word1 != word2:
	if word1 in word2:
		print("word1 is a substrings of word2")
	elif word2 in word1:
		print("word2 is a substrings of word1")
	else:
		print("they are not the same")

# Create a list of numbers from user input
num = input("please enter")
numbers = []
for i in num:
	numbers.append(int(i))
print(numbers)

 # Loop through the list and calculate the total sum
num = input("please enter")
numbers = []
for i in num:
	numbers.append(int(i))
print(sum(numbers))

#Find the minimum and maximum number in your list.
num = input("please enter")
numbers = []

for i in num:
	numbers.append(int(i))

min_value = numbers[0]
max_value = numbers[0]
for a in numbers:
	if max_value < a:
		max_value = a
	if min_value > a:
		min_value = a
		
print("the maximum is" + str(max_value))
print("the minimum is" + str(min_value))