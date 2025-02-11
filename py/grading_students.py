def grading_students(grades):
    finalgrades = []

    for grade in grades:
        if grade < 38 or grade % 5 == 0 or grade % 5 < 3:
            finalgrades.append(grade)
        elif grade % 5 > 2:
            finalgrades.append(grade + (5 - (grade % 5)))

    return finalgrades

fg = grading_students([73, 67, 38, 33])
print(fg)