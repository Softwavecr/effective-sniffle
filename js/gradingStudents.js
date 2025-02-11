function gradingStudents(grades) {
    let finalgrades = [];
    grades.forEach(grade => {        
        if(grade < 38 || grade % 5 == 0 || grade % 5 < 3)
            finalgrades.push(grade);
        else if(grade % 5 > 2)
            finalgrades.push(grade + (5- (grade % 5)));               
    });
    return finalgrades;
}

let fg = gradingStudents([73, 67, 38, 33]);
console.log(fg);
